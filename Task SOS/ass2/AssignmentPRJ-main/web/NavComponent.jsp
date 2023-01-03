

<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<nav class="navbar navbar-expand-lg navbar-dark bg-dark fixed-top">
    <div class="container">
        <a class="navbar-brand" style="color: orange" href="home">Male Fashion</a>
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarResponsive" aria-controls="navbarResponsive" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarResponsive">
            <ul  class="navbar-nav ml-auto">
                <li class="nav-item active">
                    <a class="nav-link" href="home">Home
                        <span class="sr-only">(current)</span>
                    </a>
                </li>
                <c:if test="${sessionScope.account.role eq 'ADMIN'}">
                    <li class="nav-item">
                        <a class="nav-link" href="manager-product">Manager Product</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="manager-account">Manager Account</a>
                    </li>
                </c:if>
                <li class="nav-item">
                    <div class="d-flex">
                        <a  class="nav-link active" href="carts"><svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-cart" viewBox="0 0 16 16">
                                <path d="M0 1.5A.5.5 0 0 1 .5 1H2a.5.5 0 0 1 .485.379L2.89 3H14.5a.5.5 0 0 1 .491.592l-1.5 8A.5.5 0 0 1 13 12H4a.5.5 0 0 1-.491-.408L2.01 3.607 1.61 2H.5a.5.5 0 0 1-.5-.5zM3.102 4l1.313 7h8.17l1.313-7H3.102zM5 12a2 2 0 1 0 0 4 2 2 0 0 0 0-4zm7 0a2 2 0 1 0 0 4 2 2 0 0 0 0-4zm-7 1a1 1 0 1 1 0 2 1 1 0 0 1 0-2zm7 0a1 1 0 1 1 0 2 1 1 0 0 1 0-2z"/>
                            </svg></a>
                        <span id="cart_number" style="color: orange">${sessionScope.carts.size()}</span>
                    </div>
                </li>
                <c:choose>
                    <c:when test="${sessionScope.account != null}">                  
                        <li class="active">
                            <a href="profile" class="nav-link">Hello ${sessionScope.account.displayName}</a>
                        </li>
                    </c:when>
                    <c:otherwise>
                        <li class="nav-item">
                            <a class="nav-link active" href="login">Login</a>
                        </li>
                    </c:otherwise>
                </c:choose>

            </ul>
            <form action="search" style="margin-left: 2px" class="d-flex">
                <input value="${keyword}" name="keyword" class="form-control me-2" type="search" placeholder="Search" aria-label="Search">
                    <button class="btn btn-outline-light" type="submit">Search</button>
            </form>
        </div>
    </div>
</nav>
