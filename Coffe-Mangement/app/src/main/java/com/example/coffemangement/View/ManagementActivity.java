package com.example.coffemangement.View;

import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.GridLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.annotation.SuppressLint;
import android.content.Intent;
import android.os.AsyncTask;
import android.os.Bundle;
import android.widget.Toast;

import com.example.coffemangement.Adapter.ListTableAdapter;
import com.example.coffemangement.Connection.Connect;
import com.example.coffemangement.Model.Table;
import com.example.coffemangement.R;

import java.io.PrintWriter;
import java.io.StringWriter;
import java.io.Writer;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;

public class ManagementActivity extends AppCompatActivity {
    Connect connectionClass;
    public RecyclerView listTable;
    private ListTableAdapter adapterTable;
    private RecyclerView.LayoutManager layoutManager;
    private List<Table> tableList;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_management);

        connectionClass = new Connect();

        tableList = new ArrayList<>();

        listTable = findViewById(R.id.recyclerTable);
        listTable.setHasFixedSize(true);
        layoutManager = new GridLayoutManager(getApplicationContext(), 3);
        listTable.setLayoutManager(layoutManager);

        LoadTable();
    }

    public void LoadTable(){
        try {
            Connection con = connectionClass.CONN();
            if (con == null) {
                Toast.makeText(this, "Lỗi kết nối", Toast.LENGTH_SHORT).show();
            } else {
                String query = "SELECT * FROM TABLES WHERE statusDel = 0";
                Statement stmt = con.createStatement();
                ResultSet rs = stmt.executeQuery(query);

                if (rs != null){
                    while (rs.next()) {
                        try {
                            tableList.add(new Table(rs.getInt("id"), rs.getString("name"), rs.getString("status")));

                            adapterTable = new ListTableAdapter(tableList);
                            adapterTable.notifyDataSetChanged();
                            listTable.setAdapter(adapterTable);
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

        tableList.clear();

        LoadTable();
    }
}
