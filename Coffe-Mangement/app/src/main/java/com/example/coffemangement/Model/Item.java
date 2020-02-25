package com.example.coffemangement.Model;

public class Item {
    private int id;
    private String name;
    private float price;
    private Category category;
    private int status;

    public Item(int id, String name, float price, Category category, int status) {
        this.id = id;
        this.name = name;
        this.price = price;
        this.category = category;
        this.status = status;
    }

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

    public float getPrice() {
        return price;
    }

    public void setPrice(float price) {
        this.price = price;
    }

    public Category getCategory() {
        return category;
    }

    public void setCategory(Category category) {
        this.category = category;
    }

    public int getStatus() {
        return status;
    }

    public void setStatus(int status) {
        this.status = status;
    }
}
