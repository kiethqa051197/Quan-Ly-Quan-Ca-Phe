package com.example.coffemangement.View;

import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.annotation.SuppressLint;
import android.os.AsyncTask;
import android.os.Bundle;
import android.util.Log;
import android.widget.ArrayAdapter;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.Toast;

import com.example.coffemangement.Adapter.ListBillAdapter;
import com.example.coffemangement.Connection.Connect;
import com.example.coffemangement.Model.Menu;
import com.example.coffemangement.Model.Table;
import com.example.coffemangement.R;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;

import static android.R.layout.simple_list_item_1;

public class OrderActivity extends AppCompatActivity {
    Connect connectionClass;
    private TextView txtbanan;

    private List<Table> tableList;
    private List<Menu> menuList;

    private Spinner spinTable;
    private ArrayAdapter<Table> arrayAdapterTable;

    public RecyclerView listBill;
    private ListBillAdapter adapterBill;
    private RecyclerView.LayoutManager layoutManager;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_order);

        tableList = new ArrayList<>();
        menuList = new ArrayList<>();

        connectionClass = new Connect();

        txtbanan = findViewById(R.id.txtbanan);
        spinTable = findViewById(R.id.spinTable);

        txtbanan.setText(getIntent().getStringExtra("tableName"));

        listBill = findViewById(R.id.recyclerTable);
        listBill.setHasFixedSize(true);
        layoutManager = new LinearLayoutManager(getApplicationContext());
        listBill.setLayoutManager(layoutManager);

        LoadTable loadTable = new LoadTable();
        loadTable.execute("");

        ShowBill showBill = new ShowBill();
        showBill.execute("");
    }

    @SuppressLint("StaticFieldLeak")
    public class LoadTable extends AsyncTask<String, String, String> {
        String z = "";
        Boolean isSuccess = false;

        @Override
        protected void onPreExecute() {
            Toast.makeText(OrderActivity.this, "Please  wait....", Toast.LENGTH_SHORT).show();
        }

        @Override
        protected void onPostExecute(String r) {
            Toast.makeText(OrderActivity.this, z + "", Toast.LENGTH_LONG).show();
            if (!isSuccess) {
                Toast.makeText(OrderActivity.this, "Error", Toast.LENGTH_SHORT).show();
            }
            else {
                try {
                    arrayAdapterTable = new ArrayAdapter<>(OrderActivity.this, simple_list_item_1, tableList);
                    spinTable.setAdapter(arrayAdapterTable);
                    arrayAdapterTable.notifyDataSetChanged();
                } catch (Exception ignored) {

                }
            }
        }

        @Override
        protected String doInBackground(String... params) {
            try {
                Connection con = connectionClass.CONN();
                if (con == null) {
                    z = "Error in connection with SQL server";
                } else {
                    String query = "SELECT * FROM TABLES WHERE statusDel = 0";
                    Statement stmt = con.createStatement();
                    ResultSet rs = stmt.executeQuery(query);

                    if (rs != null){
                        while (rs.next())
                        {
                            try {
                                tableList.add(new Table(rs.getInt("id"), rs.getString("name"), rs.getString("status")));
                            } catch (Exception ex) {
                                ex.printStackTrace();
                            }
                        }
                        z = "Found";
                        isSuccess = true;
                    } else {
                        z = "No Data found!";
                        isSuccess = false;
                    }
                }
            } catch (Exception ex) {
                z = "Exceptions";
                isSuccess = false;
            }
            return z;
        }
    }

    @SuppressLint("StaticFieldLeak")
    public class ShowBill extends AsyncTask<String, String, String>{
        String z = "";
        Boolean isSuccess = false;

        @Override
        protected void onPreExecute() {
            Toast.makeText(OrderActivity.this, "Please  wait....", Toast.LENGTH_SHORT).show();
        }

        @Override
        protected void onPostExecute(String r) {
            Toast.makeText(OrderActivity.this, z + "", Toast.LENGTH_LONG).show();
            if (!isSuccess) {
                Toast.makeText(OrderActivity.this, "Error", Toast.LENGTH_SHORT).show();
            }
            else {
                try {
                    adapterBill = new ListBillAdapter(menuList);
                    adapterBill.notifyDataSetChanged();
                    listBill.setAdapter(adapterBill);
                } catch (Exception ignored) {

                }
            }
        }

        @Override
        protected String doInBackground(String... strings) {
            try {
                Connection con = connectionClass.CONN();
                if (con == null) {
                    z = "Error in connection with SQL server";
                } else {
                    String query = "SELECT i.name, bi.count, i.price, i.price*bi.count AS totalPrice FROM BILLINFOS AS bi, BILLS AS b, ITEMS AS i WHERE bi.idBill = b.id AND bi.idItems = i.id AND b.status = 0 AND b.idTable = " + getIntent().getStringExtra("tableID") + "";
                    Statement stmt = con.createStatement();
                    ResultSet rs = stmt.executeQuery(query);

                    if (rs != null){
                        while (rs.next())
                        {
                            try {
                                menuList.add(new Menu(rs.getString("name"), rs.getInt("count"), rs.getFloat("price"), rs.getFloat("totalPrice")));
                            } catch (Exception ex) {
                                ex.printStackTrace();
                            }
                        }
                        z = "Found";
                        isSuccess = true;
                    } else {
                        z = "No Data found!";
                        isSuccess = false;
                    }
                }
            } catch (Exception ex) {
                z = "Exceptions";
                isSuccess = false;
            }
            return z;
        }
    }
}
