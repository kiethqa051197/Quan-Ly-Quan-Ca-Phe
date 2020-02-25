package com.example.coffemangement.Model;

public class BillInfo {
    private int id;
    private Bill bill;
    private Item items;
    private float price;
    private int count;

    public BillInfo(int id, Bill bill, Item items, float price, int count) {
        this.id = id;
        this.bill = bill;
        this.items = items;
        this.price = price;
        this.count = count;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public Bill getBill() {
        return bill;
    }

    public void setBill(Bill bill) {
        this.bill = bill;
    }

    public Item getItems() {
        return items;
    }

    public void setItems(Item items) {
        this.items = items;
    }

    public float getPrice() {
        return price;
    }

    public void setPrice(float price) {
        this.price = price;
    }

    public int getCount() {
        return count;
    }

    public void setCount(int count) {
        this.count = count;
    }
}
