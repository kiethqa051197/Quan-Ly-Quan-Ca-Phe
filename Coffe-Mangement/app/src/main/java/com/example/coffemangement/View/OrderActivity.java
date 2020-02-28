package com.example.coffemangement.View;

import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.annotation.SuppressLint;
import android.content.Intent;
import android.os.AsyncTask;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
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

public class OrderActivity extends AppCompatActivity implements  AdapterView.OnItemSelectedListener, View.OnClickListener {
    Connect connectionClass;
    private TextView txtbanan;

    private List<Table> tableList;
    private List<Menu> menuList;

    private Button btnSwitchTable, btnOrder, btnPayment, btnCancel;

    private Spinner spinTable;
    private ArrayAdapter<Table> arrayAdapterTable;

    public RecyclerView listBill;
    private ListBillAdapter adapterBill;
    private RecyclerView.LayoutManager layoutManager;

    private TextView txtTotalPrice;

    private int idTable2 = 0;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_order);

        tableList = new ArrayList<>();
        menuList = new ArrayList<>();

        connectionClass = new Connect();

        txtbanan = findViewById(R.id.txtbanan);
        spinTable = findViewById(R.id.spinTable);

        btnSwitchTable = findViewById(R.id.btnSwitchTable);
        btnOrder = findViewById(R.id.btnOrder);
        btnPayment = findViewById(R.id.btnPayment);
        btnCancel = findViewById(R.id.btnCancel);

        txtbanan.setText(getIntent().getStringExtra("tableName"));

        listBill = findViewById(R.id.recyclerOrder);
        layoutManager = new LinearLayoutManager(getApplicationContext());
        listBill.setLayoutManager(layoutManager);

        txtTotalPrice = findViewById(R.id.txtTotalPriceOrder);

        spinTable.setOnItemSelectedListener(this);
        btnSwitchTable.setOnClickListener(this);
        btnCancel.setOnClickListener(this);

        LoadTable();
        ShowBill();
    }

    @Override
    public void onClick(View v) {
        int id = v.getId();

        switch (id){
            case R.id.btnCancel:
                finish();
                break;
            case R.id.btnSwitchTable:
                SwitchTable();
                break;
            case R.id.btnPayment:
                break;
        }
    }

    @Override
    public void onItemSelected(AdapterView<?> parent, View view, int position, long id) {
        switch (parent.getId()) {
            case R.id.spinTable:
                idTable2 = tableList.get(position).getId();
                break;
        }
    }

    @Override
    public void onNothingSelected(AdapterView<?> parent) {

    }

    @SuppressLint("SetTextI18n")
    private void ShowBill(){
        try {
            Connection con = connectionClass.CONN();
            if (con == null) {
                Toast.makeText(this, "Lỗi kết nối", Toast.LENGTH_SHORT).show();
            } else {
                String query = "SELECT i.name, bi.count, i.price, i.price*bi.count AS totalPrice FROM BILLINFOS AS bi, BILLS AS b, ITEMS AS i WHERE bi.idBill = b.id AND bi.idItems = i.id AND b.status = 0 AND b.idTable = " + getIntent().getIntExtra("tableID", 0) + "";
                Statement stmt = con.createStatement();
                ResultSet rs = stmt.executeQuery(query);

                int totalPrice = 0;

                if (rs != null){
                    while (rs.next()) {
                        try {
                            menuList.add(new Menu(rs.getString("name"), rs.getInt("count"), rs.getFloat("price"), rs.getFloat("totalPrice")));

                            adapterBill = new ListBillAdapter(menuList);
                            adapterBill.notifyDataSetChanged();
                            listBill.setAdapter(adapterBill);

                            for(int i = 0; i < menuList.size(); i++){
                                totalPrice += (int) menuList.get(i).getTotalPrice();
                            }

                            txtTotalPrice.setText(Integer.toString(totalPrice));
                        } catch (Exception ex) {
                            ex.printStackTrace();
                        }
                    }
                } else {
                    Toast.makeText(this, "Lỗi query", Toast.LENGTH_SHORT).show();
                }
            }
        } catch (Exception ex) {
            Toast.makeText(this, "Lỗi kết nối tới SQL Server", Toast.LENGTH_SHORT).show();
        }
    }

    private void SwitchTable(){
        try {
            Connection con = connectionClass.CONN();
            if (con == null) {
                Toast.makeText(this, "Lỗi kết nối", Toast.LENGTH_SHORT).show();
            } else {
                String query = "EXEC PC_SwitchTable " + getIntent().getIntExtra("tableID", 0) + " , " + idTable2 + " , " + 4 + " ";
                Statement stmt = con.createStatement();
                ResultSet rs = stmt.executeQuery(query);

                if (rs != null) {
                    Toast.makeText(this, "Thành công", Toast.LENGTH_SHORT).show();
                } else {
                    Toast.makeText(this, "Lỗi query", Toast.LENGTH_SHORT).show();
                }
            }
        } catch (Exception ex) {
            Toast.makeText(this, "Lỗi kết nối tới SQL Server", Toast.LENGTH_SHORT).show();
        }
    }

//    @SuppressLint("StaticFieldLeak")
//    public class Checkout extends AsyncTask<String, String, String> {
//        String z = "";
//        Boolean isSuccess = false;
//
//        @Override
//        protected void onPreExecute() {
//            Toast.makeText(OrderActivity.this, "Please  wait....", Toast.LENGTH_SHORT).show();
//        }
//
//        @Override
//        protected void onPostExecute(String r) {
//            Toast.makeText(OrderActivity.this, z + "", Toast.LENGTH_LONG).show();
//            if (!isSuccess) {
//                Toast.makeText(OrderActivity.this, "Error", Toast.LENGTH_SHORT).show();
//            }
//            else {
//                Toast.makeText(OrderActivity.this, "Thành công", Toast.LENGTH_SHORT).show();
//            }
//        }
//
//        @Override
//        protected String doInBackground(String... params) {
//            try {
//                Connection con = connectionClass.CONN();
//                if (con == null) {
//                    z = "Error in connection with SQL server";
//                } else {
//                    String query = "UPDATE BILLS SET idCustomer = " + 1 + ", dateCheckout = GETDATE(), status = 1, discount = 0, idStaff = 3 WHERE id = 4002";
//                    Statement stmt = con.createStatement();
//                    ResultSet rs = stmt.executeQuery(query);
//
//                    isSuccess = rs.next();
//                }
//            } catch (Exception ex) {
//                z = "Exceptions";
//                isSuccess = false;
//            }
//            return z;
//        }
//    }

    private void LoadTable(){
        try {
            Connection con = connectionClass.CONN();
            if (con == null) {
                Toast.makeText(this, "Lỗi kết nối", Toast.LENGTH_SHORT).show();
            } else {
                String query = "SELECT * FROM TABLES WHERE statusDel = 0 and status = N'Trống'";
                Statement stmt = con.createStatement();
                ResultSet rs = stmt.executeQuery(query);

                if (rs != null){
                    while (rs.next()) {
                        try {
                            tableList.add(new Table(rs.getInt("id"), rs.getString("name"), rs.getString("status")));

                            arrayAdapterTable = new ArrayAdapter<>(OrderActivity.this, simple_list_item_1, tableList);
                            spinTable.setAdapter(arrayAdapterTable);
                            arrayAdapterTable.notifyDataSetChanged();
                        } catch (Exception ex) {
                            ex.printStackTrace();
                        }
                    }
                } else {
                    Toast.makeText(this, "Lỗi query", Toast.LENGTH_SHORT).show();
                }
            }
        } catch (Exception ex) {
            Toast.makeText(this, "Lỗi kết nối tới SQL Server", Toast.LENGTH_SHORT).show();
        }
    }

    @Override
    protected void onResume() {
        super.onResume();

        menuList.clear();

        ShowBill();
    }
}
