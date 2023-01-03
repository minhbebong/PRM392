package dao;

import context.DBContext;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;
import model.Category;
import model.Product;

/**
 *
 * @author ThinkPro
 */
public class ProductDAO {

    Connection conn;
    PreparedStatement ps;
    ResultSet rs;

    public List<Product> getAllPagging(int pageIndex, int pageSize) {
        try {
            String query = "SELECT * FROM (\n"
                    + "  SELECT Product.*, \n"
                    + "    ROW_NUMBER() OVER (ORDER BY id ASC) AS RN\n"
                    + "  FROM Product\n"
                    + ") AS X\n"
                    + "WHERE RN > ?*?-?\n"
                    + "AND RN <= ?*?-?";

            conn = new DBContext().getConnection();
            ps = conn.prepareStatement(query);
            ps.setInt(1, pageIndex );
            ps.setInt(2, pageSize );
            ps.setInt(3, pageSize );
            ps.setInt(4, pageIndex +1);
            ps.setInt(5, pageSize);
            ps.setInt(6, pageSize );
            rs = ps.executeQuery();

            List<Product> list = new ArrayList<>();
            while (rs.next()) {
                Product P = new Product(
                        rs.getInt(1),
                        rs.getInt(2),
                        rs.getString(3),
                        rs.getString(4),
                        rs.getInt(5),
                        rs.getDouble(6),
                        rs.getString(7),
                        rs.getString(8),
                        rs.getDate(9));

                list.add(P);
            }
            return list;
        } catch (Exception ex) {
            ex.printStackTrace(System.out);
        }
        return null;
    }

    public List<Product> getAllPaggingCat(int pageIndex, int pageSize) {
        try {
            String query = "SELECT * FROM (\n"
                    + "  SELECT Product.*, \n"
                    + "    ROW_NUMBER() OVER (ORDER BY id ASC) AS RN\n"
                    + "  FROM Product\n"
                    + ") AS X\n"
                    + "WHERE RN > ?*?-?\n"
                    + "AND RN <= ?*?-?";

            conn = new DBContext().getConnection();
            ps = conn.prepareStatement(query);
            ps.setInt(1, pageIndex);
            ps.setInt(2, pageSize);
            ps.setInt(3, pageSize);
            ps.setInt(4, pageIndex + 1);
            ps.setInt(5, pageSize);
            ps.setInt(6, pageSize);
            rs = ps.executeQuery();

            List<Product> list = new ArrayList<>();
            while (rs.next()) {
                Category category = new CategoryDAO().getCategoryNameByCatId(rs.getInt(2));
                Product P = new Product(
                        rs.getInt(1),
                        rs.getInt(2),
                        rs.getString(3),
                        rs.getString(4),
                        rs.getInt(5),
                        rs.getDouble(6),
                        rs.getString(7),
                        rs.getString(8),
                        category);

                list.add(P);
            }
            return list;
        } catch (Exception ex) {
            ex.printStackTrace(System.out);
        }
        return null;
    }

    public int countCode(String code) {
        try {
            String query = "SELECT COUNT(code)\n"
                    + "  FROM [dbo].[Product]\n"
                    + "Where [code] = '" +code+"'";

            conn = new DBContext().getConnection();
            ps = conn.prepareStatement(query);
            rs = ps.executeQuery();

            int count=0;
            if (rs.next()) {
                 count = rs.getInt(1);
            }
            
            return count;
        } catch (Exception ex) {
            ex.printStackTrace(System.out);
        }
        return 0;
    }

    public int countPage(int pageSize) {
        try {
            String query = "select Count(*) from product";

            conn = new DBContext().getConnection();
            ps = conn.prepareStatement(query);
            rs = ps.executeQuery();

            int count = 0;
            if (rs.next()) {
                count = rs.getInt(1);
            }
            int numOfPage = count / pageSize;
            if (count % pageSize != 0) {
                numOfPage++;
            }
            return numOfPage;
        } catch (Exception ex) {
            ex.printStackTrace(System.out);
        }
        return 0;
    }

    public List<Product> getProductByCategoryId(int categoryId, int pageIndex, int pageSize) {
        try {
            String query = "SELECT * FROM (\n"
                    + "SELECT Product.*,ROW_NUMBER() OVER (ORDER BY id ASC) AS RN \n"
                    + " FROM Product where categoryId = ? ) AS X WHERE RN > ?*?-? AND RN <= ?*?-?";

            conn = new DBContext().getConnection();
            ps = conn.prepareStatement(query);
            ps.setInt(1, categoryId);
            ps.setInt(2, pageIndex);
            ps.setInt(3, pageSize);
            ps.setInt(4, pageSize);
            ps.setInt(5, pageIndex + 1);
            ps.setInt(6, pageSize);
            ps.setInt(7, pageSize);
            rs = ps.executeQuery();

            List<Product> list = new ArrayList<>();
            while (rs.next()) {
                Product P = new Product(
                        rs.getInt(1),
                        rs.getInt(2),
                        rs.getString(3),
                        rs.getString(4),
                        rs.getInt(5),
                        rs.getDouble(6),
                        rs.getString(7),
                        rs.getString(8),
                        rs.getDate(9));

                list.add(P);
            }
            return list;
        } catch (Exception ex) {
            ex.printStackTrace(System.out);
        }
        return null;
    }

    public int countPageWhenFilterCategory(int categoryId, int pageSize) {
        try {
            String query = "select Count(*) from product where categoryId = ? ";

            conn = new DBContext().getConnection();
            ps = conn.prepareStatement(query);
            ps.setInt(1, categoryId);
            rs = ps.executeQuery();

            int count = 0;
            if (rs.next()) {
                count = rs.getInt(1);
            }
            int numOfPage = count / pageSize;
            if (count % pageSize != 0) {
                numOfPage++;
            }
            return numOfPage;
        } catch (Exception ex) {
            ex.printStackTrace(System.out);
        }
        return 0;
    }
    public int countCategory(int categoryId, int pageSize) {
        try {
            String query = "select Count(*) from product where categoryId = ? ";

            conn = new DBContext().getConnection();
            ps = conn.prepareStatement(query);
            ps.setInt(1, categoryId);
            rs = ps.executeQuery();

            int count = 0;
            if (rs.next()) {
                count = rs.getInt(1);
            }
            
            return count;
        } catch (Exception ex) {
            ex.printStackTrace(System.out);
        }
        return 0;
    }

    public Product getProductById(int productID) {
        try {
            String query = "SELECT * FROM Product where id=?";

            conn = new DBContext().getConnection();
            ps = conn.prepareStatement(query);
            ps.setInt(1, productID);

            rs = ps.executeQuery();

            if (rs.next()) {
                Product P = new Product(
                        rs.getInt(1),
                        rs.getInt(2),
                        rs.getString(3),
                        rs.getString(4),
                        rs.getInt(5),
                        rs.getDouble(6),
                        rs.getString(7),
                        rs.getString(8),
                        rs.getDate(9));
                return P;
            }

        } catch (Exception ex) {
            ex.printStackTrace(System.out);
        }
        return null;
    }

    public List<Product> search(String keyword) {
        try {
            String query = "select * from Product where name like ?";

            conn = new DBContext().getConnection();
            ps = conn.prepareStatement(query);
            ps.setString(1, "%" + keyword + "%");
            rs = ps.executeQuery();

            List<Product> list = new ArrayList<>();
            while (rs.next()) {
                Product P = new Product(
                        rs.getInt(1),
                        rs.getInt(2),
                        rs.getString(3),
                        rs.getString(4),
                        rs.getInt(5),
                        rs.getDouble(6),
                        rs.getString(7),
                        rs.getString(8),
                        rs.getDate(9));

                list.add(P);
            }
            return list;
        } catch (Exception ex) {
            ex.printStackTrace(System.out);
        }
        return null;
    }

    public List<Product> SearchAndPaging(String keyword, int pageIndex, int pageSize) {
        try {
            String query = "SELECT * FROM (\n"
                    + "SELECT Product.*,ROW_NUMBER() OVER (ORDER BY id ASC) AS RN \n"
                    + " FROM Product where name like ? ) AS X WHERE RN > ?*?-? AND RN <= ?*?-?";

            conn = new DBContext().getConnection();
            ps = conn.prepareStatement(query);
            ps.setString(1, "%" + keyword + "%");
            ps.setInt(2, pageIndex);
            ps.setInt(3, pageSize);
            ps.setInt(4, pageSize);
            ps.setInt(5, pageIndex + 1);
            ps.setInt(6, pageSize);
            ps.setInt(7, pageSize);
            rs = ps.executeQuery();

            List<Product> list = new ArrayList<>();
            while (rs.next()) {
                Product P = new Product(
                        rs.getInt(1),
                        rs.getInt(2),
                        rs.getString(3),
                        rs.getString(4),
                        rs.getInt(5),
                        rs.getDouble(6),
                        rs.getString(7),
                        rs.getString(8),
                        rs.getDate(9));

                list.add(P);
            }
            return list;
        } catch (Exception ex) {
            ex.printStackTrace(System.out);
        }
        return null;

    }

    public int countPageWhenSearch(String keyword, int pageSize) {
        try {
            String query = "select Count(*) from product where name like ? ";

            conn = new DBContext().getConnection();
            ps = conn.prepareStatement(query);
            ps.setString(1, "%" + keyword + "%");
            rs = ps.executeQuery();

            int count = 0;
            if (rs.next()) {
                count = rs.getInt(1);
            }
            int numOfPage = count / pageSize;
            if (count % pageSize != 0) {
                numOfPage++;
            }
            return numOfPage;
        } catch (Exception ex) {
            ex.printStackTrace(System.out);
        }
        return 0;
    }

    public void DeleteProductById(int id) {
        try {
            String query = "DELETE FROM  [dbo].[Product]\n"
                    + "      WHERE id=?";

            conn = new DBContext().getConnection();
            ps = conn.prepareStatement(query);
            ps.setInt(1, id);
            ps.executeUpdate();

        } catch (Exception ex) {
            ex.printStackTrace(System.out);
        }
    }

    public void addProduct(Product p) {
        try {
            String query = "INSERT INTO  [dbo].[Product]\n"
                    + "           ([categoryId]\n"
                    + "           ,[code]\n"
                    + "           ,[name]\n"
                    + "           ,[quantity]\n"
                    + "           ,[price]\n"
                    + "           ,[description]\n"
                    + "           ,[img])\n"
                    + "     VALUES\n"
                    + "           (?,?,?,?,?,?,?)";

            conn = new DBContext().getConnection();
            ps = conn.prepareStatement(query);
            ps.setInt(1, p.getCategoryId());
            ps.setString(2, p.getCode());
            ps.setString(3, p.getName());
            ps.setInt(4, p.getQuantity());
            ps.setDouble(5, p.getPrice());
            ps.setString(6, p.getDescription());
            ps.setString(7, p.getImage());

            ps.executeUpdate();

        } catch (Exception ex) {
            ex.printStackTrace(System.out);
        }
    }

    public void updateProductById(Product p) {
        try {
            String query = "UPDATE [dbo].[Product]\n"
                    + "   SET [categoryId] =? \n"
                    + "      ,[code] = ?\n"
                    + "      ,[name] = ?\n"
                    + "      ,[quantity] = ?\n"
                    + "      ,[price] = ?\n"
                    + "      ,[description] = ?\n"
                    + "      ,[img] = ?\n"
                    + " WHERE [id] =? ";

            conn = new DBContext().getConnection();
            ps = conn.prepareStatement(query);
            ps.setInt(1, p.getCategoryId());
            ps.setString(2, p.getCode());
            ps.setString(3, p.getName());
            ps.setInt(4, p.getQuantity());
            ps.setDouble(5, p.getPrice());
            ps.setString(6, p.getDescription());
            ps.setString(7, p.getImage());
            ps.setInt(8, p.getId());

            ps.executeUpdate();

        } catch (Exception ex) {
            ex.printStackTrace(System.out);
        }
    }

    public Product getLatestProduct() {
        try {
            String query = "select top 1 * from Product order by id desc ";

            conn = new DBContext().getConnection();
            ps = conn.prepareStatement(query);
            rs = ps.executeQuery();

            while (rs.next()) {
                return new Product(rs.getInt(1), rs.getInt(2), rs.getString(3), rs.getString(4), rs.getInt(5), rs.getInt(6),
                        rs.getString(7),
                        rs.getString(8),
                        rs.getDate(9));
            }
        } catch (Exception ex) {
            ex.printStackTrace(System.out);
        }
        return null;
    }

    public void updateQuantityProduct(int productId, int quantityOfCart) {
        try {
            String query = "UPDATE  [dbo].[Product]\n"
                    + "   SET [quantity] = quantity - ?\n"
                    + " WHERE id=?";

            conn = new DBContext().getConnection();
            ps = conn.prepareStatement(query);
            ps.setInt(1, quantityOfCart);
            ps.setInt(2, productId);
            ps.executeUpdate();

        } catch (Exception ex) {
            ex.printStackTrace(System.out);
        }
    }

    public int getMaxPrice() {
        try {
            String query = "select MAX(price) from Product";

            conn = new DBContext().getConnection();
            ps = conn.prepareStatement(query);
            rs = ps.executeQuery();
            if (rs.next()) {
                return rs.getInt(1);
            }
        } catch (Exception ex) {
            ex.printStackTrace(System.out);
        }
        return 0;
    }

    public List<Product> getAllPaggingWhenFilter(int pageIndex, int pageSize, int from, int to) {
        try {
            String query = "SELECT * FROM (\n"
                    + "  SELECT Product.*, \n"
                    + "    ROW_NUMBER() OVER (ORDER BY id ASC) AS RN\n"
                    + "  FROM Product where price between ? and ?\n"
                    + ") AS X\n"
                    + "WHERE RN > ?*?-?\n"
                    + "AND RN <= ?*?-?";

            conn = new DBContext().getConnection();
            ps = conn.prepareStatement(query);
            ps.setInt(1, from);
            ps.setInt(2, to);
            ps.setInt(3, pageIndex);
            ps.setInt(4, pageSize);
            ps.setInt(5, pageSize);
            ps.setInt(6, pageIndex + 1);
            ps.setInt(7, pageSize);
            ps.setInt(8, pageSize);
            rs = ps.executeQuery();

            List<Product> list = new ArrayList<>();
            while (rs.next()) {
                Product P = new Product(
                        rs.getInt(1),
                        rs.getInt(2),
                        rs.getString(3),
                        rs.getString(4),
                        rs.getInt(5),
                        rs.getDouble(6),
                        rs.getString(7),
                        rs.getString(8),
                        rs.getDate(9));

                list.add(P);
            }
            return list;
        } catch (Exception ex) {
            ex.printStackTrace(System.out);
        }
        return null;
    }

    public int countPageWhenFilterPrice(int pageSize, int from, int to) {
        try {
            String query = "select COUNT(*) from Product where price between ? and ?";

            conn = new DBContext().getConnection();
            ps = conn.prepareStatement(query);

            ps.setInt(1, from);
            ps.setInt(2, to);
            rs = ps.executeQuery();

            int count = 0;
            if (rs.next()) {
                count = rs.getInt(1);
            }
            int numOfPage = count / pageSize;
            if (count % pageSize != 0) {
                numOfPage++;
            }
            return numOfPage;
        } catch (Exception ex) {
            ex.printStackTrace(System.out);
        }
        return 0;
    }
}
