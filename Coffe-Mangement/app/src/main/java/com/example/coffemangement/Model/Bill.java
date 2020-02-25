package com.example.coffemangement.Model;

import net.sourceforge.jtds.jdbc.DateTime;

public class Bill {
    private int id;
    private Table table;
    private Customer customer;
    private DateTime dateCheckIn;
    private DateTime dateCheckOut;
    private int status;
    private int discount;
    private int idStaff;

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public Table getTable() {
        return table;
    }

    public void setTable(Table table) {
        this.table = table;
    }

    public Customer getCustomer() {
        return customer;
    }

    public void setCustomer(Customer customer) {
        this.customer = customer;
    }

    public DateTime getDateCheckIn() {
        return dateCheckIn;
    }

    public void setDateCheckIn(DateTime dateCheckIn) {
        this.dateCheckIn = dateCheckIn;
    }

    public DateTime getDateCheckOut() {
        return dateCheckOut;
    }

    public void setDateCheckOut(DateTime dateCheckOut) {
        this.dateCheckOut = dateCheckOut;
    }

    public int getStatus() {
        return status;
    }

    public void setStatus(int status) {
        this.status = status;
    }

    public int getDiscount() {
        return discount;
    }

    public void setDiscount(int discount) {
        this.discount = discount;
    }

    public int getIdStaff() {
        return idStaff;
    }

    public void setIdStaff(int idStaff) {
        this.idStaff = idStaff;
    }

    public Bill(int id, Table table, Customer customer, DateTime dateCheckIn, DateTime dateCheckOut, int status, int discount, int idStaff) {
        this.id = id;
        this.table = table;
        this.customer = customer;
        this.dateCheckIn = dateCheckIn;
        this.dateCheckOut = dateCheckOut;
        this.status = status;
        this.discount = discount;
        this.idStaff = idStaff;
    }
}
