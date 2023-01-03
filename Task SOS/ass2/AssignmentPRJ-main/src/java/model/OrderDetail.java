/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package model;

/**
 *
 * @author Admin
 */
public class OrderDetail {
    private int id;
    private int orderId;
    private String productName;
    private String productImg;
    private double productPrice;
    private int quantity;

    public OrderDetail() {
    }

    public OrderDetail(int id, int orderId, String productName, String productImg, double productPrice, int quantity) {
        this.id = id;
        this.orderId = orderId;
        this.productName = productName;
        this.productImg = productImg;
        this.productPrice = productPrice;
        this.quantity = quantity;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public int getOrderId() {
        return orderId;
    }

    public void setOrderId(int orderId) {
        this.orderId = orderId;
    }

    public String getProductName() {
        return productName;
    }

    public void setProductName(String productName) {
        this.productName = productName;
    }

    public String getProductImg() {
        return productImg;
    }

    public void setProductImg(String productImg) {
        this.productImg = productImg;
    }

    public double getProductPrice() {
        return productPrice;
    }

    public void setProductPrice(double productPrice) {
        this.productPrice = productPrice;
    }

    public int getQuantity() {
        return quantity;
    }

    public void setQuantity(int quantity) {
        this.quantity = quantity;
    }

    @Override
    public String toString() {
        return "OrderDetail{" + "id=" + id + ", orderId=" + orderId + ", productName=" + productName + ", productImg=" + productImg + ", productPrice=" + productPrice + ", quantity=" + quantity + '}';
    }
    
    
    
}
