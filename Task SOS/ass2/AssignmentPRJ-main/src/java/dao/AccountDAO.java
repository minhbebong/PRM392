/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dao;

import java.util.*;
import javax.mail.*;
import javax.mail.internet.*;
import context.DBContext;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;
import java.util.Properties;
import java.util.logging.Level;
import java.util.logging.Logger;
import model.Account;
import model.Category;
import model.Order;

public class AccountDAO {

    Connection conn;
    PreparedStatement ps;
    ResultSet rs;

    public Account CheckAccountExist(String username) {
        try {
            String query = "select * from Account where username=?";

            conn = new DBContext().getConnection();
            ps = conn.prepareStatement(query);
            ps.setString(1, username);
            rs = ps.executeQuery();
            while (rs.next()) {
                Account a = Account.builder()
                        .id(rs.getInt(1))
                        .username(rs.getString(2))
                        .password(rs.getString(3))
                        .displayName(rs.getString(4))
                        .address(rs.getString(5))
                        .email(rs.getString(6))
                        .phone(rs.getString(7))
                        .role(rs.getString(8)).build();
                return a;
            }
        } catch (Exception ex) {
            ex.printStackTrace(System.out);
        }
        return null;
    }

    public Account loginUser(String username, String password) {
        try {
            String query = "select * from Account where username=? and password=? and role='USER'";

            conn = new DBContext().getConnection();
            ps = conn.prepareStatement(query);
            ps.setString(1, username);
            ps.setString(2, password);
            rs = ps.executeQuery();
            while (rs.next()) {
                Account a = Account.builder()
                        .id(rs.getInt(1))
                        .username(rs.getString(2))
                        .password(rs.getString(3))
                        .displayName(rs.getString(4))
                        .address(rs.getString(5))
                        .email(rs.getString(6))
                        .phone(rs.getString(7))
                        .role(rs.getString(8))
                        .passEmail(rs.getString(9))
                        .build();
                return a;
            }
        } catch (Exception ex) {
            ex.printStackTrace(System.out);
        }
        return null;
    }

    public Account login(String username, String password) {
        try {
            String query = "select * from Account where username=? and password=? ";

            conn = new DBContext().getConnection();
            ps = conn.prepareStatement(query);
            ps.setString(1, username);
            ps.setString(2, password);
            rs = ps.executeQuery();
            while (rs.next()) {
                Account a = Account.builder()
                        .id(rs.getInt(1))
                        .username(rs.getString(2))
                        .password(rs.getString(3))
                        .displayName(rs.getString(4))
                        .address(rs.getString(5))
                        .email(rs.getString(6))
                        .phone(rs.getString(7))
                        .role(rs.getString(8))
                        .passEmail(rs.getString(9))
                        .build();
                return a;
            }
        } catch (Exception ex) {
            ex.printStackTrace(System.out);
        }
        return null;
    }

    public Account loginAdmin(String username, String password) {
        try {
            String query = "select * from Account where username=? and password=? and role='ADMIN'";

            conn = new DBContext().getConnection();
            ps = conn.prepareStatement(query);
            ps.setString(1, username);
            ps.setString(2, password);
            rs = ps.executeQuery();
            while (rs.next()) {
                Account a = Account.builder()
                        .id(rs.getInt(1))
                        .username(rs.getString(2))
                        .password(rs.getString(3))
                        .displayName(rs.getString(4))
                        .address(rs.getString(5))
                        .email(rs.getString(6))
                        .phone(rs.getString(7))
                        .role(rs.getString(8))
                        .passEmail(rs.getString(9))
                        .build();
                return a;
            }
        } catch (Exception ex) {
            ex.printStackTrace(System.out);
        }
        return null;
    }

    public void Register(Account a) {
        try {
            String sql = "INSERT INTO   [dbo].[Account]\n"
                    + "           ([username]\n"
                    + "           ,[password]\n"
                    + "           ,[displayName]\n"
                    + "           ,[address]\n"
                    + "           ,[email]\n"
                    + "           ,[phone]\n"
                    + "           ,[role]\n"
                    + "           ,[passwordEmail])\n"
                    + "     VALUES\n"
                    + "           (?,?,?,?,?,?,'USER',?)";
            conn = new DBContext().getConnection();
            ps = conn.prepareStatement(sql);
            ps.setString(1, a.getUsername());
            ps.setString(2, a.getPassword());
            ps.setString(3, a.getDisplayName());
            ps.setString(4, a.getAddress());
            ps.setString(5, a.getEmail());
            ps.setString(6, a.getPhone());
            ps.setString(7, a.getPassEmail());
            ps.executeUpdate();
        } catch (Exception ex) {
            Logger.getLogger(AccountDAO.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

    public void updateAccount(int id, String name, String email, String phone, String address, String role) {
        try {
            String sql = "UPDATE   [dbo].[Account]\n"
                    + "   SET [displayName] = ?\n"
                    + "      ,[address] = ?\n"
                    + "      ,[email] = ?\n"
                    + "      ,[phone] = ?\n"
                    + "      ,[role] = ?\n"
                    + " WHERE id=?";
            conn = new DBContext().getConnection();
            ps = conn.prepareStatement(sql);
            ps.setString(1, name);
            ps.setString(2, address);
            ps.setString(3, email);
            ps.setString(4, phone);
            ps.setString(5, role);
            ps.setInt(6, id);
            ps.executeUpdate();
        } catch (Exception ex) {
            Logger.getLogger(AccountDAO.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

    public Account getAccountById(int id) {
        try {
            String query = "select * from Account where id=?";

            conn = new DBContext().getConnection();
            ps = conn.prepareStatement(query);
            ps.setInt(1, id);
            rs = ps.executeQuery();
            while (rs.next()) {
                Account a = Account.builder()
                        .id(rs.getInt(1))
                        .username(rs.getString(2))
                        .password(rs.getString(3))
                        .displayName(rs.getString(4))
                        .address(rs.getString(5))
                        .email(rs.getString(6))
                        .phone(rs.getString(7))
                        .role(rs.getString(8)).build();
                return a;
            }
        } catch (Exception ex) {
            ex.printStackTrace(System.out);
        }
        return null;
    }

    public void updateAccountAndPass(int id, String name, String email, String phone, String address, String role, String newPass) {
        try {
            String sql = "UPDATE   [dbo].[Account]\n"
                    + "   SET [displayName] = ?\n"
                    + "      ,[address] = ?\n"
                    + "      ,[email] = ?\n"
                    + "      ,[phone] = ?\n"
                    + "      ,[role] = ?\n"
                    + "      ,[password] = ?\n"
                    + " WHERE id=?";
            conn = new DBContext().getConnection();
            ps = conn.prepareStatement(sql);
            ps.setString(1, name);
            ps.setString(2, address);
            ps.setString(3, email);
            ps.setString(4, phone);
            ps.setString(5, role);
            ps.setString(6, newPass);
            ps.setInt(7, id);
            ps.executeUpdate();
        } catch (Exception ex) {
            Logger.getLogger(AccountDAO.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

    public static void send(String to, String sub,
            String msg, final String user, final String pass) {
        //create an instance of Properties Class   
        Properties props = new Properties();

        /* Specifies the IP address of your default mail server
     	   for e.g if you are using gmail server as an email sever
           you will pass smtp.gmail.com as value of mail.smtp host. 
           As shown here in the code. 
           Change accordingly, if your email id is not a gmail id
         */
        props.put("mail.smtp.host", "smtp.gmail.com");
        //below mentioned mail.smtp.port is optional
        props.put("mail.smtp.port", "587");
        props.put("mail.smtp.auth", "true");
        props.put("mail.smtp.starttls.enable", "true");

        /* Pass Properties object(props) and Authenticator object   
           for authentication to Session instance 
         */
        Session session = Session.getInstance(props, new javax.mail.Authenticator() {
            @Override
            protected PasswordAuthentication getPasswordAuthentication() {
                return new PasswordAuthentication(user, pass);
            }
        });

        try {

            /* Create an instance of MimeMessage, 
 	      it accept MIME types and headers 
             */
            MimeMessage message = new MimeMessage(session);
            message.setFrom(new InternetAddress(user));
            message.addRecipient(Message.RecipientType.TO, new InternetAddress(to));
            message.setSubject(sub);
            message.setContent(msg, "text/html");

            /* Transport class is used to deliver the message to the recipients */
            Transport.send(message);

        } catch (MessagingException e) {
            e.printStackTrace();
        }
    }

    public void SendEmailAcceptToCustomer(Order order, Account accountAdmin, String emailCus) {
        String subject = "Order Confirmation Notice";
        String message = "<!DOCTYPE html>\n"
                + "<html lang=\"en\">\n"
                + "\n"
                + "<head>\n"
                + " <meta charset=\"UTF-8\">\n"
                + "</head>\n"
                + "\n"
                + "<body>\n"
                + "    <h1 style=\"color: blue;\">Huy Hoang Watch</h1>\n"
                + "    <h3 style=\"color: blue;\">Your order has been processing.</h3>\n"
                + "    <div>Full Name: " + order.getShipping().getName() + "</div>\n"
                + "    <div>Phone :" + order.getShipping().getPhone() + "</div>\n"
                + "    <div>address : " + order.getShipping().getAddress() + "</div>\n"
                + "    <h3 style=\"color: blue;\">Thank you very much!</h3>\n"
                + "\n"
                + "</body>\n"
                + "\n"
                + "</html>";
        AccountDAO.send(emailCus, subject, message, accountAdmin.getEmail(), accountAdmin.getPassEmail());
    }

    public void SendEmailRefuseToCustomer(Order order, Account accountAdmin, String emailCus) {
        String subject = "Order Confirmation Notice";
        String message = "<!DOCTYPE html>\n"
                + "<html lang=\"en\">\n"
                + "\n"
                + "<head>\n"
                + " <meta charset=\"UTF-8\">\n"
                + "</head>\n"
                + "\n"
                + "<body>\n"
                + "    <h1 style=\"color: blue;\">Huy Hoang Watch</h1>\n"
                + "    <h3 style=\"color: red;\">Your order has been cancelled.</h3>\n"
                + "    <h3 style=\"color: blue;\">Thank you very much!</h3>\n"
                + "\n"
                + "</body>\n"
                + "\n"
                + "</html>";
        AccountDAO.send(emailCus, subject, message, accountAdmin.getEmail(), accountAdmin.getPassEmail());
    }

    public List<Account> getAccountsUserAndPagging(int pageIndex, int pageSize) {
        try {
            String query = "SELECT * FROM (\n"
                    + "  SELECT Account.*, \n"
                    + "    ROW_NUMBER() OVER (ORDER BY id ASC) AS RN\n"
                    + "  FROM Account where role='USER'\n"
                    + ") as X\n"
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

            List<Account> list = new ArrayList<>();
            while (rs.next()) {
                Account account = Account.builder().id(rs.getInt(1)).username(rs.getString(2))
                        .displayName(rs.getString(4)).address(rs.getString(5))
                        .email(rs.getString(6)).phone(rs.getString(7)).role(rs.getString(8)).build();

                list.add(account);
            }
            return list;
        } catch (Exception ex) {
            ex.printStackTrace(System.out);
        }
        return null;
    }

    public int countPage(int pageSize) {
        try {
            String query = "select Count(*) from Account where role='USER'";

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

    public void updateAccountRoleByID(int accountId) {
        try {
            String sql = "UPDATE   [dbo].[Account]\n"
                    + "   SET [role] = 'ADMIN'\n"
                    + " WHERE id=?";
            conn = new DBContext().getConnection();
            ps = conn.prepareStatement(sql);
            ps.setInt(1, accountId);
            ps.executeUpdate();
        } catch (Exception ex) {
            Logger.getLogger(AccountDAO.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

    public void deleteAccountByID(int accountId) {
        try {
            String sql = "delete [dbo].[Account]\n"
                    + " WHERE id=?";
            conn = new DBContext().getConnection();
            ps = conn.prepareStatement(sql);
            ps.setInt(1, accountId);
            ps.executeUpdate();
        } catch (Exception ex) {
            Logger.getLogger(AccountDAO.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
}
