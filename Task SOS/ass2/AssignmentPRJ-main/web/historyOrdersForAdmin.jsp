

<%@ taglib prefix="fmt" uri="http://java.sun.com/jsp/jstl/fmt" %>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html lang="en">

    <head>

        <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
        <meta name="description" content="">
        <meta name="author" content="">

        <title>Shop Homepage - Start Bootstrap Template</title>

        <!-- Bootstrap core CSS -->
        <link href="vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">

        <!-- Custom styles for this template -->
        <link href="css/shop-homepage.css" rel="stylesheet">
        <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.3.1/css/all.css" integrity="sha384-mzrmE5qonljUremFsqc01SB46JvROS7bZs3IO2EmfFsd15uHvIt+Y8vEf7N7fWAU" crossorigin="anonymous">

    </head>

    <body style="padding-top: 0">

        <!-- Navigation -->
        <%@include file="NavComponent.jsp" %>

        <!--container-->
        <div class="container" style="margin-top: 7rem;margin-bottom: 7rem">

            <div class="mt-3">
                <h4>History Order</h4>
                <table class="w-100 table table-striped mt-3">
                    <thead>
                        <tr>
                            <th>Created Date</th>
                            <th>Account Name</th>
                            <th>Product Name</th>
                            <th>Product Price</th>
                            <th>Total Price</th>
                            <th>Status</th>
                            <th>Action</th>
                        </tr>
                    </thead>
                    <tbody> 
                        <c:forEach items="${listOrders}" var="O"> 
                            <tr>   
                                <td>
                                    ${O.createdDate}
                                </td>
                                <td>
                                    ${O.accountName}
                                </td>
                                <td>
                                    <div>
                                        <c:forEach items="${O.list}" var="D">
                                            ${D.productName}<br/>
                                        </c:forEach>
                                    </div>
                                </td>
                                <td>
                                    <div>
                                        <c:forEach items="${O.list}" var="D">
                                            ${D.productPrice}<br/>
                                        </c:forEach>
                                    </div>
                                </td>
                                <td>
                                    ${O.totalPrice}
                                </td>
                                <td>
                                    <c:choose>
                                        <c:when test="${O.status == 1}">
                                            <h5 class="btn-outline-success">
                                                checked <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-check" viewBox="0 0 16 16">
                                                <path d="M10.97 4.97a.75.75 0 0 1 1.07 1.05l-3.99 4.99a.75.75 0 0 1-1.08.02L4.324 8.384a.75.75 0 1 1 1.06-1.06l2.094 2.093 3.473-4.425a.267.267 0 0 1 .02-.022z"/>
                                                </svg>
                                            </h5>
                                        </c:when>
                                        <c:when test="${O.status == 2}">
                                            <h5 class="btn-outline-danger">
                                                rejected by customer<svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-x" viewBox="0 0 16 16">
                                                <path d="M4.646 4.646a.5.5 0 0 1 .708 0L8 7.293l2.646-2.647a.5.5 0 0 1 .708.708L8.707 8l2.647 2.646a.5.5 0 0 1-.708.708L8 8.707l-2.646 2.647a.5.5 0 0 1-.708-.708L7.293 8 4.646 5.354a.5.5 0 0 1 0-.708z"/>
                                                </svg>
                                            </h5>
                                        </c:when> 
                                        <c:otherwise>
                                            <h5 class="btn-outline-danger">
                                                unchecked<svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-x" viewBox="0 0 16 16">
                                                <path d="M4.646 4.646a.5.5 0 0 1 .708 0L8 7.293l2.646-2.647a.5.5 0 0 1 .708.708L8.707 8l2.647 2.646a.5.5 0 0 1-.708.708L8 8.707l-2.646 2.647a.5.5 0 0 1-.708-.708L7.293 8 4.646 5.354a.5.5 0 0 1 0-.708z"/>
                                                </svg>
                                            </h5>
                                        </c:otherwise>
                                    </c:choose>
                                </td>
                                <td>
                                    <a href="see-detail?orderId=${O.id}">See details</a>
                                </td>
                            </tr>
                        </c:forEach>
                    </tbody>
                </table>
                <div class="text-right">
                    <a href="home" class="btn btn-success ml-2">back to home 
                        <i class="fas fa-arrow-right ml-2"></i>
                    </a>
                </div>
            </div>


        </div>
        <!-- /.container -->

        <!-- Footer -->
        <%@include file="footerComponent.jsp" %>

        <!-- Bootstrap core JavaScript -->
        <script src="vendor/jquery/jquery.min.js"></script>
        <script src="vendor/bootstrap/js/bootstrap.bundle.min.js"></script>

    </body>

</html>

