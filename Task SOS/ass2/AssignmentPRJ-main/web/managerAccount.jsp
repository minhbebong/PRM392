

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

        <script type="text/javascript">
            function doDelete(id) {
                if (confirm("are U sure to delete Account with id = " + id + " ?")) {
                    window.location = "delete-account?id=" + id;
                }
            }
        </script>
        <!-- Bootstrap core CSS -->
        <link href="vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">

        <!-- Custom styles for this template -->
        <link href="css/shop-homepage.css" rel="stylesheet">
        <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.3.1/css/all.css" integrity="sha384-mzrmE5qonljUremFsqc01SB46JvROS7bZs3IO2EmfFsd15uHvIt+Y8vEf7N7fWAU" crossorigin="anonymous">

    </head>

    <body style="padding-top: 0">
        <!--container-->
        <div class="container" style="margin-bottom: 7rem">
            <div class="mt-3">
                <nav class="navbar navbar-light bg-light">
                    <div class="container-fluid">
                        <a class="navbar-brand">Manager Account</a>
                        <div style="margin-right: 500px">
                            <a href="home" class="btn  bg-success text-white" type="submit">Back to home</a>
                        </div>
                    </div>
                </nav>
                <form action="manager-account" method="POST">
                    <table class="w-100 table table-striped mt-3">
                        <thead>
                            <tr>
                                <th>ID</th>
                                <th>username</th>
                                <th>address</th>
                                <th>email</th>
                                <th>phone</th>
                                <th>role</th>
                                <th>Action</th>
                            </tr>
                        </thead>
                        <tbody>

                            <c:forEach items="${listAccounts}" var="A">
                            <input type="hidden" name="accountId" value="${A.id}">
                            <tr>
                                <td>${A.id}</td>
                                <td>${A.username}</td>
                                <td>${A.address}</td>
                                <td>${A.email}</td>
                                <td>${A.phone}</td>
                                <td>${A.role}</td>
                                <td><button type="submit"  class="btn  bg-success text-white" name="admin">Let's be admin</button></td>
                                <td><a onclick="doDelete(${A.id})" href="#" class="btn bg-danger text-white" type="submit" name="delete">Delete</a></td>
                            </tr>  
                        </c:forEach>

                        </tbody>
                    </table>
                </form>
                <nav style="float: right" class="float-end" aria-label="Page navigation example">
                    <ul class="pagination">
                        <li class="page-item ${pageIndex==1?"disabled":""}"><a class="page-link" href="manager-account?pageIndex=${pageIndex-1}">Previous</a></li>
                            <c:forEach begin="1" end="${totalPage}" var="i">
                            <li class="page-item ${pageIndex == i?"active":""}"><a class="page-link" href="manager-account?pageIndex=${i}">${i}</a></li>                        
                            </c:forEach>
                        <li class="page-item ${pageIndex==totalPage?"disabled":""}"><a class="page-link" href="manager-account?pageIndex=${pageIndex+1}">Next</a></li>
                    </ul>
                </nav>
            </div>
        </div>

        <!-- Bootstrap core JavaScript -->
        <script src="vendor/jquery/jquery.min.js"></script>
        <script src="vendor/bootstrap/js/bootstrap.bundle.min.js"></script>

    </body>

</html>

