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

    <body style="padding-top: 0 !important">
        <section class=" h-custom" style="background-color: #eee;">
            <div class="container h-100 py-5">
                <div class="row d-flex justify-content-center align-items-center h-100">
                    <div class="col">
                        <div class="card shopping-cart" style="border-radius: 15px;">
                            <div class="card-body text-black">
                                <a style="font-size: 20px" href="history-orders"><i class="fas fa-angle-left me-2"></i>Back to history orders</a>
                                <div class="row">
                                    <div class="col-lg-6 px-5 py-4">

                                        <h3 class="mb-5 pt-2 text-center fw-bold text-uppercase">products</h3>
                                        <c:forEach items="${O.list}" var="OD">
                                            <div class="d-flex align-items-center mb-5">
                                                <div class="flex-shrink-0">
                                                    <img src="${OD.productImg}"
                                                         class="img-fluid" style="width: 150px;" alt="Generic placeholder image">
                                                </div>
                                                <div class="flex-grow-1 ms-3">
                                                    <h5 class="text-primary">${OD.productName}</h5>
                                                    <div class="d-flex align-items-center">
                                                        <p class="fw-bold mb-0 me-5 pe-3">$${OD.productPrice}</p>
                                                        <div  class="mx-5">
                                                            Quantity: ${OD.quantity}
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </c:forEach>
                                        <hr class="mb-4" style="height: 2px; background-color: #1266f1; opacity: 1;">

                                        <div class="d-flex justify-content-between p-2 mb-2" style="background-color: #e1f5fe;">
                                            <h5 class="fw-bold mb-0">Total:</h5>
                                            <h5 class="fw-bold mb-0">$${O.totalPrice}</h5>
                                        </div>

                                    </div>
                                    <div class="col-lg-6 px-5 py-4">

                                        <h3 class="mb-5 pt-2 text-center fw-bold text-uppercase">Information of Customer</h3>

                                        <div class="card-body">
                                            <div class="row mb-3">
                                                <div class="col-sm-4">
                                                    <h6 class="mb-0">Name</h6>
                                                </div>
                                                <div class="col-sm-8 text-secondary">
                                                    ${O.shipping.name}
                                                </div>
                                            </div>
                                            <div class="row mb-3">
                                                <div class="col-sm-4">
                                                    <h6 class="mb-0">Phone</h6>
                                                </div>
                                                <div class="col-sm-8 text-secondary">
                                                    ${O.shipping.phone}
                                                </div>
                                            </div>
                                            <div class="row mb-3">
                                                <div class="col-sm-4">
                                                    <h6 class="mb-0">Email</h6>
                                                </div>
                                                <div class="col-sm-8 text-secondary">
                                                    ${O.account.email}
                                                </div>
                                            </div>
                                            <div class="row mb-3">
                                                <div class="col-sm-4">
                                                    <h6 class="mb-0">Address</h6>
                                                </div>
                                                <div class="col-sm-8 text-secondary">
                                                    ${O.shipping.address}
                                                </div>
                                            </div>
                                            <div class="row mb-3">
                                                <div class="col-sm-4">
                                                    <h6 class="mb-0">Created date</h6>
                                                </div>
                                                <div class="col-sm-8 text-secondary">
                                                    ${O.createdDate}
                                                </div>
                                            </div>
                                            <div class="row mb-3">
                                                <div class="col-sm-4">
                                                    <h6 class="mb-0">Note</h6>
                                                </div>
                                                <div class="col-sm-8 text-secondary">
                                                    ${O.note}
                                                </div>
                                            </div>
                                        </div>

                                        <c:choose>
                                            <c:when test="${O.shipping.name=='Administrator' && account.displayName=='Administrator' && O.status == 0}">
                                                <form action="accept-order">
                                                    <input type="hidden" name="orderId" value="${O.id}" />
                                                    <input type="hidden" name="email" value="${O.account.email}" />

                                                    <input type="hidden" name="status" value="0" />
                                                    <button type="submit" class="btn btn-outline-success btn-block btn-lg">
                                                        cant checked your self <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-check" viewBox="0 0 16 16">
                                                        <path d="M10.97 4.97a.75.75 0 0 1 1.07 1.05l-3.99 4.99a.75.75 0 0 1-1.08.02L4.324 8.384a.75.75 0 1 1 1.06-1.06l2.094 2.093 3.473-4.425a.267.267 0 0 1 .02-.022z"/>
                                                        </svg>
                                                    </button>
                                                </form> 
                                            </c:when>
                                            <c:when test="${O.status == 1}">
                                                <form action="accept-order">
                                                    <input type="hidden" name="orderId" value="${O.id}" />
                                                    <input type="hidden" name="email" value="${O.account.email}" />
                                                    <input type="hidden" name="status" value="0" />
                                                    <button type="submit" class="btn btn-outline-success btn-block btn-lg">
                                                        checked <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-check" viewBox="0 0 16 16">
                                                        <path d="M10.97 4.97a.75.75 0 0 1 1.07 1.05l-3.99 4.99a.75.75 0 0 1-1.08.02L4.324 8.384a.75.75 0 1 1 1.06-1.06l2.094 2.093 3.473-4.425a.267.267 0 0 1 .02-.022z"/>
                                                        </svg>
                                                    </button>
                                                </form> 
                                            </c:when>
                                            <c:otherwise>
                                                <form action="accept-order" method="POST">
                                                    <input type="hidden" name="orderId" value="${O.id}" />
                                                    <input type="hidden" name="email" value="${O.account.email}" />
                                                    <input type="hidden" name="status" value="1" />
                                                    <button type="submit" class="btn btn-primary btn-block btn-lg">
                                                        accept order
                                                    </button>
                                                </form>
                                            </c:otherwise>
                                        </c:choose>
                                    </div>
                                </div>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>

        <!-- Bootstrap core JavaScript -->
        <script src="vendor/jquery/jquery.min.js"></script>
        <script src="vendor/bootstrap/js/bootstrap.bundle.min.js"></script>

    </body>

</html>