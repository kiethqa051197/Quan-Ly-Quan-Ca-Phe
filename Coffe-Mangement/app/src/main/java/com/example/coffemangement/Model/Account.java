package com.example.coffemangement.Model;

public class Account {
    private int id;
    private String username;
    private String passWord;
    private Staff staff;
    private int type;

    public Account(int id, String username, String passWord, Staff staff, int type) {
        this.id = id;
        this.username = username;
        this.passWord = passWord;
        this.staff = staff;
        this.type = type;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getUsername() {
        return username;
    }

    public void setUsername(String username) {
        this.username = username;
    }

    public String getPassWord() {
        return passWord;
    }

    public void setPassWord(String passWord) {
        this.passWord = passWord;
    }

    public Staff getStaff() {
        return staff;
    }

    public void setStaff(Staff staff) {
        this.staff = staff;
    }

    public int getType() {
        return type;
    }

    public void setType(int type) {
        this.type = type;
    }
}
