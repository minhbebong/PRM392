using Microsoft.EntityFrameworkCore;
using PRN211_Assignment2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_Assignment2
{
    public class CartHandler
    {
        public static CartHandler Instance { get; set; } = new CartHandler();

        public string CartId
        {
            get
            {
                if (Program.Settings.CartId is null)
                {
                    Program.Settings.CartId = Guid.NewGuid().ToString();
                }
                return Program.Settings.CartId;
            }
        }

        public CartHandler()
        {

        }

        public void AddToCart(Album album, string? cartId = null, int count = 1)
        {
            cartId = cartId ?? CartId;

            var cart = Program.MusicStoreContext?.Carts.FirstOrDefault(e => e.AlbumId == album.AlbumId && e.CartId == cartId);

            if (cart is not null)
            {
                cart.Count++;
            }
            else
            {
                cart = new Cart()
                {
                    CartId = cartId,
                    AlbumId = album.AlbumId,
                    Count = count,
                    DateCreated = DateTime.Now
                };

                Program.MusicStoreContext?.Carts.Add(cart);
            }

            Program.MusicStoreContext?.SaveChanges();
        }

        public void Remove(Album album, string? cartId = null)
        {
            cartId = cartId ?? CartId;

            var cart = Program.MusicStoreContext?.Carts.FirstOrDefault(e => e.AlbumId == album.AlbumId && e.CartId == cartId);

            if (cart is not null)
            {
                cart.Count--;

                if (cart.Count <= 0)
                {
                    Program.MusicStoreContext?.Carts.Remove(cart);
                }
            }

            Program.MusicStoreContext?.SaveChanges();
        }

        public void EmptyCart(string? cartId = null)
        {
            cartId = cartId ?? CartId;

            var carts = Program.MusicStoreContext?.Carts.Where(e => e.CartId == cartId);
            Program.MusicStoreContext?.Carts.RemoveRange(carts!);
            Program.MusicStoreContext?.SaveChanges();
        }

        public List<Cart>? GetCartItems(string? cartId = null) => Program.MusicStoreContext?.Carts.Where(e => e.CartId == (cartId ?? CartId)).Include(e => e.Album).ToList();

        public int GetCount(string? cartId = null) => GetCartItems(cartId)?.Select(e => e.Count).Sum() ?? 0;

        public decimal GetTotal(string? cartId = null) => GetCartItems(cartId)?.Select(e => e.Count * e.Album.Price).Sum() ?? 0;

        public int CreateOrder(Order order, string? cartId = null)
        {
            cartId = cartId ?? CartId;

            try
            {
                Program.MusicStoreContext?.Orders.Add(order);
                Program.MusicStoreContext?.SaveChanges();
            }
            catch
            {
                return -1;
            }

            order = Program.MusicStoreContext?.Orders.ToList().MaxBy(e => e.OrderId)!;

            if (order is null) return -1;

            foreach (var item in GetCartItems(cartId)!)
            {
                var orderDetail = new OrderDetail()
                {
                    AlbumId = item.AlbumId,
                    OrderId = order.OrderId,
                    UnitPrice = item.Album.Price,
                    Quantity = item.Count
                };

                Program.MusicStoreContext?.OrderDetails.Add(orderDetail);
            }

            try
            {
                EmptyCart(cartId);
            }
            catch
            {
                return -1;
            }

            return order.OrderId;
        }

        public void MigrateCart(string? cartId = null)
        {
            cartId = cartId ?? CartId;

            if (Program.Settings.User is null) return;

            var carts = Program.MusicStoreContext?.Carts.Include(e => e.Album).Where(e => e.CartId == cartId).ToList();

            foreach (var cart in carts!)
            {
                AddToCart(cart.Album, Program.Settings.User.UserName, cart.Count);
            }
            Program.MusicStoreContext?.SaveChanges();
            Program.Settings.CartId = Program.Settings.User.UserName;
        }
    }
}
