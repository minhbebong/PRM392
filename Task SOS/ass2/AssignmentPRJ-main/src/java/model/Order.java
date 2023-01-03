/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package model;

import java.util.List;

/**
 *
 * @author Admin
 */
public class Order {

    private int id;
    private int accountId;
    private double totalPrice;
    private String note;
    private String createdDate;
    private int shippingId;
    private int status;
    private String accountName;
    private Shipping shipping;
    private Account account;
    private List<OrderDetail> list;

    public Order() {
    }

    public Order(int id, int accountId, double totalPrice, String note, String createdDate, int shippingId) {
        this.id = id;
        this.accountId = accountId;
        this.totalPrice = totalPrice;
        this.note = note;
        this.createdDate = createdDate;
        this.shippingId = shippingId;
    }

    public Order(int id, int accountId, double totalPrice, String note, String createdDate, int shippingId, int status, List<OrderDetail> list) {
        this.id = id;
        this.accountId = accountId;
        this.totalPrice = totalPrice;
        this.note = note;
        this.createdDate = createdDate;
        this.shippingId = shippingId;
        this.status = status;
        this.list = list;
    }

    public Order(int id, int accountId, double totalPrice, String note, String createdDate, int shippingId, int status, String accountName, List<OrderDetail> list) {
        this.id = id;
        this.accountId = accountId;
        this.totalPrice = totalPrice;
        this.note = note;
        this.createdDate = createdDate;
        this.shippingId = shippingId;
        this.status = status;
        this.accountName = accountName;
        this.list = list;
    }

    public Order(int id, int accountId, double totalPrice, String note, String createdDate, int shippingId, int status, Shipping shipping, Account account, List<OrderDetail> list) {
        this.id = id;
        this.accountId = accountId;
        this.totalPrice = totalPrice;
        this.note = note;
        this.createdDate = createdDate;
        this.shippingId = shippingId;
        this.status = status;
        this.shipping = shipping;
        this.account = account;
        this.list = list;
    }

    public String getAccountName() {
        return accountName;
    }

    public void setAccountName(String accountName) {
        this.accountName = accountName;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public int getAccountId() {
        return accountId;
    }

    public void setAccountId(int accountId) {
        this.accountId = accountId;
    }

    public double getTotalPrice() {
        return totalPrice;
    }

    public void setTotalPrice(double totalPrice) {
        this.totalPrice = totalPrice;
    }

    public String getNote() {
        return note;
    }

    public void setNote(String note) {
        this.note = note;
    }

    public String getCreatedDate() {
        return createdDate;
    }

    public void setCreatedDate(String createdDate) {
        this.createdDate = createdDate;
    }

    public int getShippingId() {
        return shippingId;
    }

    public void setShippingId(int shippingId) {
        this.shippingId = shippingId;
    }

    public List<OrderDetail> getList() {
        return list;
    }

    public void setList(List<OrderDetail> list) {
        this.list = list;
    }

    public int getStatus() {
        return status;
    }

    public void setStatus(int status) {
        this.status = status;
    }

    public Shipping getShipping() {
        return shipping;
    }

    public void setShipping(Shipping shipping) {
        this.shipping = shipping;
    }

    public Account getAccount() {
        return account;
    }

    public void setAccount(Account account) {
        this.account = account;
    }

}
