/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package controller.sync;

import dao.CategoryDAO;
import dao.ProductDAO;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.List;
import jakarta.servlet.ServletException;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import jakarta.servlet.http.HttpSession;
import model.Category;
import model.Product;

/**
 *
 * @author Admin
 */
public class PriceFilterController extends HttpServlet {

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
        try (PrintWriter out = response.getWriter()) {
            /* TODO output your page here. You may use following sample code. */
            out.println("<!DOCTYPE html>");
            out.println("<html>");
            out.println("<head>");
            out.println("<title>Servlet PriceFilterController</title>");
            out.println("</head>");
            out.println("<body>");
            out.println("<h1>Servlet PriceFilterController at " + request.getContextPath() + "</h1>");
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
        Product p = new ProductDAO().getLatestProduct();

        int price = Integer.parseInt(request.getParameter("price"));
        int from = 0;
        int to = 0;
        switch (price) {
            case 0:
                response.sendRedirect("home");
                return;
            case 1:
                from = 0;
                to = 49;
                break;
            case 2:
                from = 50;
                to = 99;
                break;
            default:
                from = 100;
                to = new ProductDAO().getMaxPrice();
                break;
        }
        List<Category> listCategory = new CategoryDAO().getAll();
        List<Product> listProduct = new ProductDAO().getAllPaggingWhenFilter(pageIndex, PAGE_SIZE, from, to);
        int totalPage = new ProductDAO().countPageWhenFilterPrice(PAGE_SIZE, from, to);
        HttpSession session = request.getSession();

        session.setAttribute("listCategory", listCategory);
        request.setAttribute("pageIndex", pageIndex);
        request.setAttribute("listProduct", listProduct);
        request.getSession().setAttribute("P", p);
        request.setAttribute("price", price);
        request.setAttribute("totalPage", totalPage);
        session.setAttribute("urlHistory", "price-filter?pageIndex=" + pageIndex +"&price="+ price);
        request.getRequestDispatcher("filterPrice.jsp").forward(request, response);
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
        processRequest(request, response);
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
