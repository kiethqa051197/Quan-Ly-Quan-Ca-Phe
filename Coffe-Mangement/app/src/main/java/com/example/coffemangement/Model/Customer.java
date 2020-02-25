package com.example.coffemangement.Model;

import net.sourceforge.jtds.jdbc.DateTime;

public class Customer {
    private int id;
    private String name;
    private String phone;
    private DateTime createDate;
    private int status;

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getPhone() {
        return phone;
    }

    public void setPhone(String phone) {
        this.phone = phone;
    }

    public DateTime getCreateDate() {
        return createDate;
    }

    public void setCreateDate(DateTime createDate) {
        this.createDate = createDate;
    }

    public int getStatus() {
        return status;
    }

    public void setStatus(int status) {
        this.status = status;
    }

    public Customer(int id, String name, String phone, DateTime createDate, int status) {
        this.id = id;
        this.name = name;
        this.phone = phone;
        this.createDate = createDate;
        this.status = status;
    }
}
