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
                DoLogin doLogin = new DoLogin();
                doLogin.execute("");
            }
        });
    }

    @SuppressLint("StaticFieldLeak")
    public class DoLogin extends AsyncTask<String, String, String> {
        String z = "";
        Boolean isSuccess = false;

        String userid = edtuserid.getText().toString();
        String password = edtpass.getText().toString();

        @Override
        protected void onPreExecute() {
            Toast.makeText(LoginActivity.this, "Please  wait....", Toast.LENGTH_SHORT).show();
        }

        @Override
        protected void onPostExecute(String r) {
            Toast.makeText(LoginActivity.this, r, Toast.LENGTH_SHORT).show();

            if (isSuccess) {
                Intent i = new Intent(LoginActivity.this, ManagementActivity.class);
                startActivity(i);
            }
        }

        @Override
        protected String doInBackground(String... params) {
            if (userid.trim().equals("") || password.trim().equals(""))
                z = "Please enter User Id and Password";
            else {
                try {
                    Connection con = connectionClass.CONN();
                    if (con == null) {
                        z = "Error in connection with SQL server";
                    } else {
                        String query = "EXEC PC_Login " + userid + " , " + password;
                        Statement stmt = con.createStatement();
                        ResultSet rs = stmt.executeQuery(query);

                        if (rs.next()) {
                            isSuccess = true;
                        } else {
                            z = "Error to excute query";
                        }
                    }
                } catch (Exception ex) {
                    isSuccess = false;
                    z = "Exceptions";
                }
            }
            return z;
        }
    }
}
