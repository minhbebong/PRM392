/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dao;

import context.DBContext;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;
import model.Category;

/**
 *
 * @author ThinkPro
 */
public class CategoryDAO {

    Connection conn;
    PreparedStatement ps;
    ResultSet rs;

    public List<Category> getAll() {
        try {
            String query = "select * from category";

            conn = new DBContext().getConnection();
            ps = conn.prepareStatement(query);
            rs = ps.executeQuery();

            List<Category> list = new ArrayList<>();
            while (rs.next()) {
                Category C = new Category(rs.getInt(1), rs.getString(2), rs.getInt(3));
                list.add(C);
            }
            return list;
        } catch (Exception ex) {
            ex.printStackTrace(System.out);
        }
        return null;
    }

    public Category getCategoryNameByCatId(int categoryID) {
        try {
            String query = "select * from category where id= ?";

            conn = new DBContext().getConnection();
            ps = conn.prepareStatement(query);
            ps.setInt(1, categoryID);
            rs = ps.executeQuery();

            if (rs.next()) {
                return new Category(rs.getInt(1), rs.getString(2), rs.getInt(3));
            }
        } catch (Exception ex) {
            ex.printStackTrace(System.out);
        }
        return null;
    }
}
