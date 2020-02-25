package com.example.coffemangement.Model;

import java.util.Date;

public class Staff {
    private int id;
    private String fullname;
    private Date dateofbirth;
    private String idCard;
    private String address;
    private String phone;
    private int status;

    public Staff(int id, String fullname, Date dateofbirth, String idCard, String address, String phone, int status) {
        this.id = id;
        this.fullname = fullname;
        this.dateofbirth = dateofbirth;
        this.idCard = idCard;
        this.address = address;
        this.phone = phone;
        this.status = status;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getFullname() {
        return fullname;
    }

    public void setFullname(String fullname) {
        this.fullname = fullname;
    }

    public Date getDateofbirth() {
        return dateofbirth;
    }

    public void setDateofbirth(Date dateofbirth) {
        this.dateofbirth = dateofbirth;
    }

    public String getIdCard() {
        return idCard;
    }

    public void setIdCard(String idCard) {
        this.idCard = idCard;
    }

    public String getAddress() {
        return address;
    }

    public void setAddress(String address) {
        this.address = address;
    }

    public String getPhone() {
        return phone;
    }

    public void setPhone(String phone) {
        this.phone = phone;
    }

    public int getStatus() {
        return status;
    }

    public void setStatus(int status) {
        this.status = status;
    }
}
