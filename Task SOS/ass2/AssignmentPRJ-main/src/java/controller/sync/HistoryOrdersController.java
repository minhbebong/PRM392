/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package controller.sync;

import dao.OrderDAO;
import java.util.List;
import java.io.IOException;
import java.io.PrintWriter;
import jakarta.servlet.ServletException;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import jakarta.servlet.http.HttpSession;
import model.Account;
import model.Order;

/**
 *
 * @author Admin
 */
public class HistoryOrdersController extends HttpServlet {

    /**
     * Processes requests for both HTTP <code>GET</code> and <code>POST</code>
     * methods.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    protected void processRequest(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        response.setContentType("text/html;charset=UTF-8");
        try ( PrintWriter out = response.getWriter()) {
            /* TODO output your page here. You may use following sample code. */
            out.println("<!DOCTYPE html>");
            out.println("<html>");
            out.println("<head>");
            out.println("<title>Servlet HistoryOrdersController</title>");
            out.println("</head>");
            out.println("<body>");
            out.println("<h1>Servlet HistoryOrdersController at " + request.getContextPath() + "</h1>");
            out.println("</body>");
            out.println("</html>");
        }
    }

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
        HttpSession session = request.getSession();
        Account a = (Account) session.getAttribute("account");
        if (a != null && a.getRole().equals(Account.ADMIN)) {
            List<Order> listOrders = new OrderDAO().getAllOrders();
            request.setAttribute("listOrders", listOrders);
            request.getRequestDispatcher("historyOrdersForAdmin.jsp").forward(request, response);
        } else {
            List<Order> listOrders = new OrderDAO().getAllOrdersByAccountId(a.getId());
            request.setAttribute("listOrders", listOrders);
            request.getRequestDispatcher("historyOrdersForUser.jsp").forward(request, response);

        }
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

        HttpSession session = request.getSession();
        Account a = (Account) session.getAttribute("account");
        if (a != null && a.getRole().equals(Account.ADMIN)) {
            List<Order> listOrders = new OrderDAO().getAllOrders();
            request.setAttribute("listOrders", listOrders);
            request.getRequestDispatcher("historyOrdersForAdmin.jsp").forward(request, response);
        } else {
            List<Order> listOrders = new OrderDAO().getAllOrdersByAccountId(a.getId());
            request.setAttribute("listOrders", listOrders);
            if (request.getParameter("delete") != null) {
                String orderid = request.getParameter("orderid");
                (new OrderDAO()).rejectStatusbyID(Integer.parseInt(orderid), 2);
            }
            request.getRequestDispatcher("historyOrdersForUser.jsp").forward(request, response);
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
