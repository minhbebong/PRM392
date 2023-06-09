package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

import java.util.ArrayList;
import java.util.List;

public class MainActivity extends AppCompatActivity {

    EditText edt_uid;
    EditText edt_firstname;
    EditText edt_lastname;
    SQLiteDatabase db;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        edt_uid = findViewById(R.id.edt_uid);
        edt_firstname = findViewById(R.id.edt_firstname);
        edt_lastname = findViewById(R.id.edt_lastname);
        MySQLiteOpenHelper openHelper = new MySQLiteOpenHelper(this,"userdb", null, 1);
        ((Button)findViewById(R.id.btn_add)).setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                db = openHelper.getWritableDatabase();
                String sql = "INSERT INTO users(firstname , lastname) VALUES (?, ?)";
                db.execSQL(sql, new String[] {edt_firstname.getText().toString(),edt_lastname.getText().toString()});
                db.close();
            }
        });

        ((Button)findViewById(R.id.btn_read)).setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                db = openHelper.getReadableDatabase();
                String sql = "SELECT * FROM users";
                Cursor c = db.rawQuery(sql, null);
                List<User> users = new ArrayList<>();
                String result = "";
                while (c.moveToNext()){
                    int uid = c.getInt(0);
                    String first_n = c.getString(1);
                    String last_n = c.getString(2);
                    users.add(new User(uid, first_n, last_n));
                    result += uid + ":" + first_n + "," + last_n + "\n";
                }
                ((TextView)findViewById(R.id.tv_show)).setText(result);
                db.close();
            }
        });
        ((Button)findViewById(R.id.btn_remove)).setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                db = openHelper.getWritableDatabase();
                db.delete("users", "uid=?", new String[]{edt_uid.getText().toString()});
                db.close();

            }
        });
    }
}