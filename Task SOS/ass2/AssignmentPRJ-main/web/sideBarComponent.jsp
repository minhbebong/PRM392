

<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<div class="col-lg-3">
    <h3 class="my-4">Category</h3>
    <ul class="list-group">
        <c:forEach items="${sessionScope.listCategory}" var="C">
            <c:if test="${categoryId eq C.id}">
                <li class="list-group-item active" aria-current="true">
                    
                    <a  class="text-decoration-none text-white" href="filter?categoryId=${C.id}">${C.categoryName}</a> (${totalCategory})
                </li>
            </c:if>
            <c:if test="${categoryId != C.id}">
                <li class="list-group-item  " aria-current="true">
                    <a class="text-decoration-none" href="filter?categoryId=${C.id}">${C.categoryName}</a>
                </li>
            </c:if>
        </c:forEach>
    </ul>

    <form action="price-filter">
        <ul class="list-group mt-4 mb-4">
            PRICE
            <li class="list-group-item">
                <input ${price==null?"checked":""} onclick="this.form.submit()"  name="price" class="form-check-input me-1" type="radio" value="0" aria-label="...">
                All products
            </li>
            <li class="list-group-item">
                <input ${price==1?"checked":""} onclick="this.form.submit()"  name="price" class="form-check-input me-1" type="radio" value="1" aria-label="...">
                Under 50$
            </li>
            <li class="list-group-item">
                <input ${price==2?"checked":""} onclick="this.form.submit()" name="price" class="form-check-input me-1" type="radio" value="2" aria-label="...">
                50$ -100$
            </li>
            <li class="list-group-item">
                <input ${price==3?"checked":""} onclick="this.form.submit()" name="price" class="form-check-input me-1" type="radio" value="3" aria-label="...">
                Over $100
            </li>
        </ul>
    </form>
    <div class="row" style="text-align: center; margin-top: 16px">
        <h4 style="width: 100%">New Product</h4>
        <div class="col-lg-12">
            <div class="card h-100">
                <a href="detail?productId=${P.id}"><img class="card-img-top" src="${P.image}" alt=""></a>
                <div class="card-body">
                    <h4 class="card-title">
                        <a href="#">${P.name}</a>
                    </h4>
                    <h5>$ ${P.price}</h5>
                    <p class="card-text">${P.description}</p>
                </div>
                <div class="card-footer">
                    <small class="text-muted">&#9733; &#9733; &#9733; &#9733; &#9734;</small>
                </div>
                <c:choose>
                    <c:when test="${P.quantity==0}">
                    <a class="add-to-cart btn btn-default" type="button" style="background-color: #dc3545" >Sold out</a>
                    </c:when>
                    <c:otherwise>
                        <div class="action">
                            <a class="btn btn-primary" href="add-to-card?productId=${P.id}">Add To Cart</a>
                        </div>
                    </c:otherwise>
                </c:choose>
            </div>
        </div>
    </div>
</div>
