/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dao;

import context.DBContext;
import java.util.List;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;
import model.Account;
import model.Order;
import model.OrderDetail;
import model.Shipping;

/**
 *
 * @author Admin
 */
public class OrderDAO {

    Connection conn;
    PreparedStatement ps;
    ResultSet rs;

    public int createAndGetId(Order order) {
        try {
            String sql = "INSERT INTO    [dbo].[Orders]\n"
                    + "           ([account_id]\n"
                    + "           ,[totalPrice]\n"
                    + "           ,[note]\n"
                    + "           ,[shipping_id])\n"
                    + "     VALUES\n"
                    + "           (?,?,?,?)";
            conn = new DBContext().getConnection();
            ps = conn.prepareStatement(sql, Statement.RETURN_GENERATED_KEYS);
            ps.setInt(1, order.getAccountId());
            ps.setDouble(2, order.getTotalPrice());
            ps.setString(3, order.getNote());
            ps.setInt(4, order.getShippingId());
            ps.executeUpdate();

            rs = ps.getGeneratedKeys();
            if (rs.next()) {
                return rs.getInt(1);
            }
        } catch (Exception ex) {
            Logger.getLogger(OrderDAO.class.getName()).log(Level.SEVERE, null, ex);
        }
        return 0;
    }

    public List<Order> getAllOrdersByAccountId(int accountId) {
        try {
            String query = " select * from Orders where account_id=? order by id desc";

            conn = new DBContext().getConnection();
            ps = conn.prepareStatement(query);
            ps.setInt(1, accountId);
            rs = ps.executeQuery();
            List<Order> listOrders = new ArrayList<>();
            while (rs.next()) {
                List<OrderDetail> listOrderDetails = new OrderDetailDAO().getAllOrderDetailsByOrderId(rs.getInt(1));
                Order order = new Order(rs.getInt(1), rs.getInt(2), rs.getDouble(3),
                        rs.getString(4), rs.getString(5), rs.getInt(6), rs.getInt(7), listOrderDetails);
                listOrders.add(order);
            }
            return listOrders;
        } catch (Exception ex) {
            ex.printStackTrace(System.out);
        }
        return null;
    }

    public List<Order> getAllOrders() {
        try {
            String query = "  select Orders.*, Account.displayName from Orders join Account "
                    + "on Orders.account_id = Account.id order by id desc ";

            conn = new DBContext().getConnection();
            ps = conn.prepareStatement(query);
            rs = ps.executeQuery();
            List<Order> listOrders = new ArrayList<>();
            while (rs.next()) {
                List<OrderDetail> listOrderDetails = new OrderDetailDAO().getAllOrderDetailsByOrderId(rs.getInt(1));
                Order order = new Order(rs.getInt(1), rs.getInt(2), rs.getDouble(3),
                        rs.getString(4), rs.getString(5), rs.getInt(6), rs.getInt(7), rs.getString(8), listOrderDetails);
                listOrders.add(order);
            }
            return listOrders;
        } catch (Exception ex) {
            ex.printStackTrace(System.out);
        }
        return null;
    }

    public Order getAllOrdersByOrderId(int orderId) {
        try {
            String query = "select * from Orders where id=?";

            conn = new DBContext().getConnection();
            ps = conn.prepareStatement(query);
            ps.setInt(1, orderId);
            rs = ps.executeQuery();
            while (rs.next()) {
                List<OrderDetail> listOrderDetails = new OrderDetailDAO().getAllOrderDetailsByOrderId(rs.getInt(1));
                Shipping shipping = new ShippingDAO().getShippingByShippingId(rs.getInt(6));
                Account account = new AccountDAO().getAccountById(rs.getInt(2));
                return new Order(rs.getInt(1),
                        rs.getInt(2),
                        rs.getDouble(3),
                        rs.getString(4),
                        rs.getString(5),
                        rs.getInt(6),
                        rs.getInt(7), shipping, account, listOrderDetails);
            }
        } catch (Exception ex) {
            ex.printStackTrace(System.out);
        }
        return null;
    }

    public void updateStatusOrderByOrderId(int orderId, int status) {
        try {
            String sql = "UPDATE    [dbo].[Orders]\n"
                    + "   SET [status] = ?\n"
                    + " WHERE id= ?";
            conn = new DBContext().getConnection();
            ps = conn.prepareStatement(sql);
            ps.setInt(1, status);
            ps.setInt(2, orderId);
            ps.executeUpdate();
        } catch (Exception ex) {
            Logger.getLogger(OrderDAO.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

    public void rejectStatusbyID(int orderId, int status ) {
        try {
            String sql = "UPDATE    [dbo].[Orders]\n"
                    + "   SET [status] = '2'\n"
                    + " WHERE id= ?";
            conn = new DBContext().getConnection();
            ps = conn.prepareStatement(sql);
            
            ps.setInt(1, orderId);
            ps.executeUpdate();
        } catch (Exception ex) {
            Logger.getLogger(OrderDAO.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

}
