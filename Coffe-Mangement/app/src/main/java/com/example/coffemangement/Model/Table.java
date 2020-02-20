package com.example.coffemangement.Model;

public class Table {
    int id;
    String name;
    String status;

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

    public String getStatus() {
        return status;
    }

    public void setStatus(String status) {
        this.status = status;
    }

    public Table(int id, String name, String status) {
        this.id = id;
        this.name = name;
        this.status = status;
    }
}
