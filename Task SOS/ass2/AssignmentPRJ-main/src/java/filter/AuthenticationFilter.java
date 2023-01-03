/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package filter;

import dao.AccountDAO;
import jakarta.servlet.Filter;
import jakarta.servlet.FilterChain;
import jakarta.servlet.FilterConfig;
import jakarta.servlet.ServletException;
import jakarta.servlet.ServletRequest;
import jakarta.servlet.ServletResponse;
import jakarta.servlet.annotation.WebFilter;
import jakarta.servlet.http.Cookie;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import jakarta.servlet.http.HttpSession;
import java.io.IOException;
import java.io.PrintStream;
import java.io.PrintWriter;
import java.io.StringWriter;

import model.Account;

/**
 *
 * @author Admin
 */
@WebFilter(filterName = "AuthenticationFilter", urlPatterns = {"/add-to-card","/buy-now", "/carts","/checkout","/delete-cart","/updateProfile","/update-quantity","/history-orders"})
public class AuthenticationFilter implements Filter {

    @Override
    public void doFilter(ServletRequest request, ServletResponse response,
            FilterChain chain)
            throws IOException, ServletException {
        HttpServletRequest req = (HttpServletRequest) request;
        HttpServletResponse res = (HttpServletResponse) response;

        HttpSession session = req.getSession();
        //Kiểm tra đăng nhập 
        Account account = (Account) session.getAttribute("account");

        if (account != null) {
            //cho qua
            chain.doFilter(request, response);
        } else {
            //check cookie
            //kiểm tra cookie 
            Cookie[] cookies = req.getCookies();
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
                Account accountLogin = new AccountDAO().login(username, password);
                if (account != null) { // cookie hợp lệ
                    session.setAttribute("account", account);
                    chain.doFilter(request, response);
                    return;
                }
            }
            res.sendRedirect("http://localhost:8080/AssignmentPRJ/login");
        }
    }

    @Override
    public void destroy() {
    }

    /**
     * Init method for this filter
     *
     * @param filterConfig
     */
    @Override
    public void init(FilterConfig filterConfig) {

    }

}
