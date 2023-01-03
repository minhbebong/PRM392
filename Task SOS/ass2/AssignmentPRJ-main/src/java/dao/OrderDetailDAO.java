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
import java.util.Map;
import java.util.logging.Level;
import java.util.logging.Logger;
import model.Cart;
import model.OrderDetail;

/**
 *
 * @author Admin
 */
public class OrderDetailDAO {

    Connection conn;
    PreparedStatement ps;
    ResultSet rs;

    public void saveCart(int orderID, Map<Integer, Cart> carts) {
        try {

            String sql = "INSERT INTO    [dbo].[OrderDetail]\n"
                    + "           ([order_id]\n"
                    + "           ,[productName]\n"
                    + "           ,[productImage]\n"
                    + "           ,[productPrice]\n"
                    + "           ,[quantity])\n"
                    + "     VALUES\n"
                    + "           (?,?,?,?,?)";
            conn = new DBContext().getConnection();
            ps = conn.prepareStatement(sql);
            ps.setInt(1, orderID);
            for (Map.Entry<Integer, Cart> entry : carts.entrySet()) {
                Integer productId = entry.getKey();
                Cart cart = entry.getValue();
                ps.setString(2, cart.getProduct().getName());
                ps.setString(3, cart.getProduct().getImage());
                ps.setDouble(4, cart.getProduct().getPrice());
                ps.setInt(5, cart.getQuantity());
                ps.executeUpdate();
            }
        } catch (Exception ex) {
            Logger.getLogger(ShippingDAO.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

    public List<OrderDetail> getAllOrderDetailsByOrderId(int orderId) {
        try {
            String query = "select * from OrderDetail where order_id= ?";

            conn = new DBContext().getConnection();
            ps = conn.prepareStatement(query);
            ps.setInt(1, orderId);
            rs = ps.executeQuery();
            List<OrderDetail> list = new ArrayList<>();
            while (rs.next()) {
                OrderDetail O = new OrderDetail(rs.getInt(1), rs.getInt(2), rs.getString(3),
                        rs.getString(4), rs.getDouble(5), rs.getInt(6));
                list.add(O);
            }
            return list;
        } catch (Exception ex) {
            ex.printStackTrace(System.out);
        }
        return null;
    }


}
