/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package controller.sync;

import dao.AccountDAO;
import java.io.IOException;
import java.io.PrintWriter;
import jakarta.servlet.ServletException;
import jakarta.servlet.http.Cookie;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import jakarta.servlet.http.HttpSession;
import model.Account;

/**
 *
 * @author Admin
 */
public class AdminLogin extends HttpServlet {

    /**
     * Processes requests for both HTTP <code>GET</code> and <code>POST</code>
     * methods.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    // <editor-fold defaultstate="collapsed" desc="HttpServlet methods. Click on the + sign on the left to edit the code.">
    /**
     * Handles the HTTP <code>GET</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        //kiểm tra cookie 
        Cookie[] cookies = request.getCookies();
        String username = null;
        String password = null;
        for (Cookie cooky : cookies) {
            if (cooky.getName().equals("username")) {
                username = cooky.getValue();
            }
            if (cooky.getName().equals("password")) {
                password = cooky.getValue();
            }
            if (username != null && password != null) {
                break;
            }
        }
        if (username != null && password != null) {
            Account account = new AccountDAO().loginAdmin(username, password);
            if (account != null) { // cookie hợp lệ
                request.getSession().setAttribute("account", account);
                response.sendRedirect("home");
                return;
            }
        }
        request.getRequestDispatcher("adminlogin.jsp").forward(request, response);

    }

    /**
     * Handles the HTTP <code>POST</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {

        //check login
        String username = request.getParameter("username");
        String password = request.getParameter("password");
        boolean remember = request.getParameter("remember") != null;
        //check username, password
        Account account = new AccountDAO().loginAdmin(username, password);

        if (account != null) {  //hop le -> luu len section 
            //remember
            if (remember) {
                Cookie usernameCookie = new Cookie("username", username);
                usernameCookie.setMaxAge(60 * 60 * 24 * 2);
                Cookie passwordCookie = new Cookie("password", password);
                passwordCookie.setMaxAge(60 * 60 * 24 * 2);
                response.addCookie(usernameCookie);
                response.addCookie(passwordCookie);
            }
            //khong remember
            request.getSession().setAttribute("account", account);
            response.sendRedirect("home");
        } else {//khong hop le -> tra ve loi
            request.setAttribute("error", "username or password incorrect");
            request.getRequestDispatcher("adminlogin.jsp").forward(request, response);
        }
    }

    /**
     * Returns a short description of the servlet.
     *
     * @return a String containing servlet description
     */
    @Override
    public String getServletInfo() {
        return "Short description";
    }// </editor-fold>

}
