/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package controller.sync;

import dao.CategoryDAO;
import dao.ProductDAO;
import model.Product;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.List;
import jakarta.servlet.ServletException;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import model.Category;

/**
 *
 * @author Admin
 */
public class UpdateProductController extends HttpServlet {

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
            out.println("<title>Servlet UpdateProductController</title>");
            out.println("</head>");
            out.println("<body>");
            out.println("<h1>Servlet UpdateProductController at " + request.getContextPath() + "</h1>");
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
        int id = Integer.parseInt(request.getParameter("productId"));
        int pageIndex = Integer.parseInt(request.getParameter("pageIndex"));
        Product p = new ProductDAO().getProductById(id);
        List<Category> listCategory = new CategoryDAO().getAll();

        request.setAttribute("P", p);
        request.getSession().setAttribute("urlUpdate", "manager-product?pageIndex=" + pageIndex);
        request.setAttribute("listCategory", listCategory);
        request.getRequestDispatcher("updateProduct.jsp").forward(request, response);
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
        List<Category> listCategory = new CategoryDAO().getAll();

        int id = Integer.parseInt(request.getParameter("productId"));
        String name = request.getParameter("name");
        String code = request.getParameter("code");
        int quantity = Integer.parseInt(request.getParameter("quantity"));
        String description = request.getParameter("description");
        String ImageUrl = request.getParameter("img");
        int categoryId = Integer.parseInt(request.getParameter("category"));
        double price = 0;

        try {
            price = Double.parseDouble(request.getParameter("price"));
            Product p = new Product();
            p.setId(id);
            p.setCategoryId(categoryId);
            p.setCode(code);
            p.setDescription(description);
            p.setImage(ImageUrl);
            p.setName(name);
            p.setPrice(price);
            p.setQuantity(quantity);

            ProductDAO pdao = new ProductDAO();
            pdao.updateProductById(p);

            String urlUpdate = (String) request.getSession().getAttribute("urlUpdate");
            if (urlUpdate == null) {
                urlUpdate = "manager-product";
            }
            if (pdao.countCode(code) != 1) {
                throw new Error();
            }
            response.sendRedirect(urlUpdate);
        }
        catch (Error e){
            request.setAttribute("samecode", "cant update an existed code");
            Product p = new Product();
            p.setId(id);
            p.setCategoryId(categoryId);
            p.setPrice(price);
            p.setDescription(description);
            p.setImage(ImageUrl);
            p.setName(name);
            p.setQuantity(quantity);
            request.setAttribute("listCategory", listCategory);
            request.setAttribute("P", p);
            request.getRequestDispatcher("updateProduct.jsp").forward(request, response);
        }
        catch (IOException | NumberFormatException e) {
            request.setAttribute("error", "price is a number");
            Product p = new Product();
            p.setId(id);
            p.setCategoryId(categoryId);
            p.setCode(code);
            p.setDescription(description);
            p.setImage(ImageUrl);
            p.setName(name);
            p.setQuantity(quantity);
            request.setAttribute("listCategory", listCategory);
            request.setAttribute("P", p);
            request.getRequestDispatcher("updateProduct.jsp").forward(request, response);
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
