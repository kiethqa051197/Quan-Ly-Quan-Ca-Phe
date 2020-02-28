package com.example.coffemangement.View;

import androidx.appcompat.app.AppCompatActivity;

import android.annotation.SuppressLint;
import android.content.Intent;
import android.os.AsyncTask;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import com.example.coffemangement.Connection.Connect;
import com.example.coffemangement.R;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;

public class LoginActivity extends AppCompatActivity {

    Connect connectionClass;
    EditText edtuserid, edtpass;
    Button btnlogin;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.login_layout);

        connectionClass = new Connect();
        edtuserid = findViewById(R.id.edEmail);
        edtpass = findViewById(R.id.edPassword);
        btnlogin = findViewById(R.id.btnSignIn);

        btnlogin.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Login(edtpass.getText().toString().trim(), edtpass.getText().toString().trim());
            }
        });
    }

    private void Login(String username, String pass){
        if (username.equals("") || pass.equals(""))
            Toast.makeText(this, "Nhập đầy đủ tên và mật khấu", Toast.LENGTH_SHORT).show();
        else {
            try {
                Connection con = connectionClass.CONN();
                if (con == null) {
                    Toast.makeText(this, "Lỗi kết nối", Toast.LENGTH_SHORT).show();
                } else {
                    String query = "EXEC PC_Login " + username + " , " + pass;
                    Statement stmt = con.createStatement();
                    ResultSet rs = stmt.executeQuery(query);

                    if (rs != null) {
                        Intent iManage = new Intent(this, ManagementActivity.class);
                        startActivity(iManage);
                    } else {
                        Toast.makeText(this, "Lỗi query", Toast.LENGTH_SHORT).show();
                    }
                }
            } catch (Exception ex) {
                Toast.makeText(this, "Lỗi kết nối tới SQL Server", Toast.LENGTH_SHORT).show();
            }
        }
    }
}
