/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package controller.sync;


import dao.CategoryDAO;
import dao.ProductDAO;
import jakarta.servlet.ServletException;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.List;
import model.Product;
import model.Category;

/**
 *
 * @author Admin
 */
public class AddProductController extends HttpServlet {

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
            out.println("<title>Servlet AddProductController</title>");
            out.println("</head>");
            out.println("<body>");
            out.println("<h1>Servlet AddProductController at " + request.getContextPath() + "</h1>");
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

        List<Category> listCategory = new CategoryDAO().getAll();
        request.setAttribute("listCategory", listCategory);
        request.getRequestDispatcher("addProduct.jsp").forward(request, response);
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
        ProductDAO pdao = new ProductDAO();
        String name = request.getParameter("name");
        String code = request.getParameter("code");
        int quantity = Integer.parseInt(request.getParameter("quantity"));
        String description = request.getParameter("description");
        String ImageUrl = request.getParameter("img");
        int catId = Integer.parseInt(request.getParameter("category"));
        double price = 0;

        try {
            price = Double.parseDouble(request.getParameter("price"));
            Product p = new Product();
            p.setCategoryId(catId);
            p.setCode(code);
            p.setDescription(description);
            p.setImage(ImageUrl);
            p.setName(name);
            p.setPrice(price);
            p.setQuantity(quantity);
            if (pdao.countCode(code) != 0) {
                throw new ArithmeticException();
            }
            else {
                pdao.addProduct(p);
                response.sendRedirect("manager-product");
            }
//            pdao.addProduct(p);
//            response.sendRedirect("manager-product");

        }
        catch (ArithmeticException a) {
            request.setAttribute("samecode", "cant generate new code if code exist");
            request.setAttribute("name", name);
            request.setAttribute("quantity", quantity);
            request.setAttribute("price", price);
            request.setAttribute("description", description);
            request.setAttribute("ImageUrl", ImageUrl);
            request.setAttribute("catId", catId);
            request.setAttribute("listCategory", listCategory);
            request.getRequestDispatcher("addProduct.jsp").forward(request, response);
        } catch (IOException | NumberFormatException e) {
            request.setAttribute("errorprice", "price is a number");
            request.setAttribute("name", name);
            request.setAttribute("code", code);
            request.setAttribute("quantity", quantity);
            request.setAttribute("description", description);
            request.setAttribute("ImageUrl", ImageUrl);
            request.setAttribute("catId", catId);
            request.setAttribute("listCategory", listCategory);
            request.getRequestDispatcher("addProduct.jsp").forward(request, response);
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
