

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

    <body>

        <!-- Navigation -->
        <%@include file="NavComponent.jsp" %>

        <!--container-->
        <div class="container" style="margin-top: 7rem;margin-bottom: 7rem">

            <c:choose>
                <c:when test="${sessionScope.carts.size()==0 || sessionScope.carts==null}">
                    <div style="margin-bottom: 22rem" class="cart-empty">
                        <div class="alert alert-danger" role="alert">
                            Shopping Cart Empty
                        </div>
                        <a class="btn btn-primary" href="home">Go Back Home</a>
                    </div>
                </c:when>
                <c:otherwise>
                    <div class="mt-3">
                        <h4>Shopping Cart</h4>
                        <table class="w-100 table table-striped mt-3">
                            <thead>
                                <tr>
                                    <th>Image</th>
                                    <th>Name of Product</th>
                                    <th>Price</th>
                                    <th>Quantity</th>
                                    <th>Total Price</th>
                                    <th>Action</th>
                                </tr>
                            </thead>
                            <tbody>
                                <c:forEach items="${carts}" var="C" varStatus="track">
                                <form action="update-quantity">
                                    <tr>    
                                    <input type="hidden" name="productId" value="${C.value.product.id}" />
                                    <td>
                                        <img src="${C.value.product.image}" style="width: 100px">
                                    </td>
                                    <td>${C.value.product.name}</td>
                                    <td>
                                        $ ${C.value.product.price}
                                    </td>
                                    <td>
                                        <input onchange="this.form.submit()" type="text" min="1" max="${C.value.product.quantity}" name="quantity" value="${C.value.quantity}" style="width: 60px"/>
                                    </td>
                                    <td>
                                        $ ${C.value.quantity * C.value.product.price}
                                    </td>
                                    <td>
                                        <a href="delete-cart?productId=${C.value.product.id}" class="btn btn-danger"><i class="bi bi-trash"></i>Delete</i></a>
                                    </td>
                                    </tr>
                                </form>
                            </c:forEach>
                            </tbody>
                        </table>
                        <hr/>
                        <div class="text-right">
                            <h4>Total Money:${totalPrice}</h4>
                        </div>
                        <hr/>
                        <div class="text-right">
                            <a href="checkout" class="btn btn-success ml-2">Continue
                                <i class="fas fa-arrow-right ml-2"></i>
                            </a>
                        </div>

                    </div>
                </c:otherwise>
            </c:choose>


        </div>
        <!-- /.container -->

        <!-- Footer -->
        <%@include file="footerComponent.jsp" %>

        <!-- Bootstrap core JavaScript -->
        <script src="vendor/jquery/jquery.min.js"></script>
        <script src="vendor/bootstrap/js/bootstrap.bundle.min.js"></script>


    </body>

</html>

