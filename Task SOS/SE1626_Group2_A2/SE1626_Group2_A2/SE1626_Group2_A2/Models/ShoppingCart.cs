﻿using Microsoft.EntityFrameworkCore;
using SE1626_Group3_A2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;

namespace SE1626_Group3_A2.Models
{
    public partial class ShoppingCart
    {
        MusicStoreContext storeDB = new MusicStoreContext();
        string ShoppingCartId { get; set; }
        string CartId;
        string UserName;
        //     public const string CartSessionKey = "CartId";
        public static ShoppingCart GetCart(string user)
        {
            var cart = new ShoppingCart();
            cart.UserName = user;
            cart.ShoppingCartId = cart.GetCartId();
            return cart;
        }
        public void AddToCart(Album album, int recordID)
        {
            // Get the matching cart and album instances
            Cart cartItem;
            if (recordID != -1)
            {
                cartItem = storeDB.Carts.SingleOrDefault(
                c => c.CartId == ShoppingCartId
                && c.AlbumId == album.AlbumId && c.RecordId == recordID);
            }
            else
            {
                cartItem = storeDB.Carts.Where(
                 c => c.CartId == ShoppingCartId
                 && c.AlbumId == album.AlbumId).OrderBy(c=> c.RecordId).LastOrDefault();
            }
            if (cartItem == null)
            {
                // Create a new cart item if no cart item exists
                cartItem = new Cart
                {
                    AlbumId = album.AlbumId,
                    CartId = ShoppingCartId,
                    Count = 1,
                    DateCreated = DateTime.Now
                };

                storeDB.Carts.Add(cartItem);
            }
            else
            {
                // If the item does exist in the cart, then add one to the quantity
                cartItem.Count++;
            }
            // Save changes
            storeDB.SaveChanges();
        }
        public int RemoveFromCart(int id)
        {
            // Get the matching cart and album id
            var cartItem = storeDB.Carts.SingleOrDefault(
                c => c.CartId == ShoppingCartId
                && c.RecordId == id);

            int itemCount = 0;
            if (cartItem != null)
            {
                if (cartItem.Count > 1)
                {
                    cartItem.Count--;
                    itemCount = cartItem.Count;
                }
                else
                {
                    storeDB.Carts.Remove(cartItem);
                }
                // Save changes
                storeDB.SaveChanges();
            }
            return itemCount;
        }
        public void EmptyCart()
        {
            var cartItems = storeDB.Carts
                .Where(cart => cart.CartId == ShoppingCartId);

            foreach (var cartItem in cartItems)
            {
                storeDB.Carts.Remove(cartItem);
            }
            // Save changes
            storeDB.SaveChanges();
        }
        public List<Cart> GetCartItems()
        {
            return storeDB.Carts.Where(cart => cart.CartId == ShoppingCartId)
                .Include(cart => cart.Album)
                .ToList();
        }
        public int GetCount()
        {
            // Get the count of each item in the cart and sum them up
            int? count = (from cartItems in storeDB.Carts
                          where cartItems.CartId == ShoppingCartId
                          select (int?)cartItems.Count).Sum();
            // Return 0 if all entries are null
            return count ?? 0;
        }
        public decimal GetTotal()
        {
            // Multiply album price by count of that album to get
            // the current price for each of those albums in the cart
            // sum all album price totals to get the cart total

            decimal? total = (from cartItems in storeDB.Carts
                              where cartItems.CartId == ShoppingCartId
                              select (int?)cartItems.Count * cartItems.Album.Price).Sum();
          
            return total ?? 0;
        }
        public int CreateOrder(Order order)
        {

            var cartItems = GetCartItems();

            // Save the order
            try
            {
                storeDB.Orders.Add(order);
                storeDB.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
            int orderID = storeDB.Orders.Select(o => o.OrderId).Max();
            // Iterate over the items in the cart, adding the order details for each
            foreach (var item in cartItems)
            {
                var orderDetail = new OrderDetail
                {
                    AlbumId = item.AlbumId,
                    OrderId = orderID,
                    UnitPrice = item.Album.Price,
                    Quantity = item.Count
                };
                try
                {
                    storeDB.OrderDetails.Add(orderDetail);
                    storeDB.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return -1;
                }
            }
            // Empty the shopping cart
            EmptyCart();
            // Return the OrderId as the confirmation number
            return orderID;
        }
        public string GetCartId()
        {
            if (CartId == null)
            {
                if (UserName != null)
                    CartId = UserName;
                else
                {
                    Guid tempCartId = Guid.NewGuid();
                    CartId = tempCartId.ToString();
                }
            }
            return CartId;
        }

        // When a user has logged in, migrate their shopping cart to
        // be associated with their username
        public void MigrateCart(string oldID)
        {
            var shoppingCart = storeDB.Carts.Where(c => c.CartId == oldID);
            List<Cart> carts = storeDB.Carts.ToList();
            foreach (Cart item in shoppingCart)
            {
                Cart getCart = carts.Where(c => c.CartId == ShoppingCartId && c.AlbumId == item.AlbumId).OrderBy(c=>c.RecordId).LastOrDefault();
                if(getCart != null)
                {
                    getCart.Count += item.Count;
                }
                else
                {
                    Cart newCart = new Cart
                    {
                        AlbumId = item.AlbumId,
                        CartId = ShoppingCartId,
                        Count = item.Count,
                        DateCreated = item.DateCreated
                    };
                    storeDB.Carts.Add(newCart);
                }
                storeDB.Carts.Remove(item);
            }
            storeDB.SaveChanges();
        }
    }


}
