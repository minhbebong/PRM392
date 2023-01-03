

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

    </head>

    <body>


        <div class="container"  style="margin-bottom: 7rem">
            <div class="row">
                <div class="col-lg-3"></div>
                <div class="col-lg-6">
                    <form action="update-product" method="post">
                        <h3>Update product</h3>
                        <input type="hidden" name="productId" value="${P.id}" />
                        <div class="form-group">
                            <label for="name">name</label>
                            <input value="${P.name}" name="name" type="text" class="form-control" id="name" aria-describedby="emailHelp" required>
                        </div>
                        <div class="form-group">
                            <label for="code">code</label>
                            <h3 style="color: red">${samecode}</h3>
                            <input value="${P.code}" name="code" type="text" class="form-control" id="code" required>
                        </div>
                        <div class="form-group">
                            <label for="quantity">quantity</label>
                            <input value="${P.quantity}" name="quantity" min="0" type="number" class="form-control" id="quantity" required>
                        </div>

                        <div class="form-group">
                            <label for="price">price</label>
                            <h3 style="color: red">${error}</h3>
                            <input value="${P.price}" name="price" type="text" class="form-control" id="price" aria-describedby="emailHelp" required>
                        </div>
                        <div class="form-floating">
                            <label for="description">description</label>
                            <textarea name="description" class="form-control" placeholder="input description" id="description" style="height: 100px">${P.description}</textarea>

                        </div>
                        <div class="form-group">
                            <label for="img">ImageUrl</label>
                            <input value="${P.image}" name="img" type="text" class="form-control" id="img" required>
                        </div> 
                        <div class="form-group mb-5">
                            <label for="status">Category: </label>
                            <select name="category">
                                <c:forEach items="${listCategory}" var="C">
                                    <option ${C.id == P.categoryId?"selected":""} value="${C.id}">${C.categoryName}</option>
                                </c:forEach>
                            </select>
                        </div>
                        <a href="manager-product" style="margin-left: 5px" class="btn  bg-dark text-white" type="submit">cancel</a>
                        <button href="update-product" style="margin-left: 5px" class="btn  bg-success text-white" type="submit">Update</button>
                    </form>
                </div>
                <div class="col-lg-3"></div>
            </div>
        </div>



        <!-- Bootstrap core JavaScript -->
        <script src="vendor/jquery/jquery.min.js"></script>
        <script src="vendor/bootstrap/js/bootstrap.bundle.min.js"></script>

    </body>

</html>