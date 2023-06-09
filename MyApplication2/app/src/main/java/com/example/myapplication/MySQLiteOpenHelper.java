package com.example.myapplication;

import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

import androidx.annotation.Nullable;

public class MySQLiteOpenHelper extends SQLiteOpenHelper {

    public MySQLiteOpenHelper(@Nullable Context context, @Nullable String name, @Nullable SQLiteDatabase.CursorFactory factory, int version) {
        super(context, name, factory, version);//tao ra db
    }

    @Override
    public void onCreate(SQLiteDatabase db) {//tao ra table
        String sql = "CREATE TABLE users(uid INTEGER PRIMARY KEY, firstname TEXT, lastname TEXT)";
        db.execSQL(sql);
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {//nang cap db
        if(newVersion > oldVersion){
            //drop old table and re-create new table
        }
    }
}
