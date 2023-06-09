package com.example.slot_new;

import androidx.appcompat.app.AppCompatActivity;

import android.content.SharedPreferences;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.EditText;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {
    EditText edt_usn;
    EditText edt_pass;
    CheckBox cb;
    SharedPreferences sharePref;
    SharedPreferences.Editor editor;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        edt_pass = findViewById(R.id.edt_pass);
        edt_usn = findViewById(R.id.edt_username);
        cb = findViewById(R.id.cb_remember);
        sharePref = getSharedPreferences("account", MODE_PRIVATE);
        ((Button)findViewById(R.id.btn_login)).setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                if (cb.isChecked()){
                    editor = sharePref.edit();
                    editor.putString("username", edt_usn.getText().toString());
                    editor.putString("password", edt_pass.getText().toString());
                    editor.putBoolean("is_saved", true);
                    editor.commit();
                }
            }
        });
        ((Button)findViewById(R.id.btn_read)).setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                String usn = sharePref.getString("username","");
                String pass = sharePref.getString("password","");
                ((TextView)findViewById(R.id.tv_show)).setText(usn + "/" + pass);
            }
        });

        ((Button)findViewById(R.id.btn_remove)).setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                editor = sharePref.edit();
//                editor.remove("username");
                editor.clear();
                editor.commit();
            }
        });
    }
}