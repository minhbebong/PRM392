/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package controller.sync;

import dao.AccountDAO;
import java.util.List;
import java.io.IOException;
import java.io.PrintWriter;
import jakarta.servlet.ServletException;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import jakarta.servlet.http.HttpSession;
import model.Account;

/**
 *
 * @author Admin
 */
public class ManagerAccountController extends HttpServlet {

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
            out.println("<title>Servlet ManagerAccountController</title>");
            out.println("</head>");
            out.println("<body>");
            out.println("<h1>Servlet ManagerAccountController at " + request.getContextPath() + "</h1>");
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
        int pageIndex = 1;
        final int PAGE_SIZE = 3;

        String raw_page = request.getParameter("pageIndex");
        if (raw_page != null) {
            pageIndex = Integer.parseInt(raw_page);
        }

        List<Account> listAccounts = new AccountDAO().getAccountsUserAndPagging(pageIndex, PAGE_SIZE);
        int totalPage = new AccountDAO().countPage(PAGE_SIZE);

        request.setAttribute("pageIndex", pageIndex);
        request.setAttribute("totalPage", totalPage);
        request.setAttribute("listAccounts", listAccounts);
        request.getSession().setAttribute("urlUpdateAccount", "manager-account?pageIndex=" + pageIndex);
        request.getRequestDispatcher("managerAccount.jsp").forward(request, response);
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
        request.setCharacterEncoding("UTF-8");
        response.setCharacterEncoding("UTF-8");
        int accountId = Integer.parseInt(request.getParameter("accountId"));
        if (request.getParameter("admin") != null) {
            new AccountDAO().updateAccountRoleByID(accountId);
            HttpSession session = request.getSession();
            String urlUpdateAccount = (String) session.getAttribute("urlUpdateAccount");
            if (urlUpdateAccount == null) {
                urlUpdateAccount = "manager-account";
            }
            response.sendRedirect(urlUpdateAccount);
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
