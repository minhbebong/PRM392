package com.example.broadcastreciever;

import androidx.appcompat.app.AppCompatActivity;

import android.app.DatePickerDialog;
import android.app.TimePickerDialog;
import android.content.Intent;
import android.content.IntentFilter;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.DatePicker;
import android.widget.TimePicker;

import java.time.Year;
import java.util.Calendar;

public class MainActivity extends AppCompatActivity {
    MyReceiver myReceiver ;
    public static final String MY_CUSTOM_BROADCAST = "ABC";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        myReceiver = new MyReceiver();
        IntentFilter intentFilter = new IntentFilter();
        intentFilter.addAction(Intent.ACTION_BATTERY_LOW);
        intentFilter.addAction(MY_CUSTOM_BROADCAST);
        registerReceiver(myReceiver, intentFilter);
    }

    @Override
    protected void onDestroy() {
        super.onDestroy();
        unregisterReceiver(myReceiver);
    }

//    public void onSendBroadCast(View view) {
//        Intent intent = new Intent();
//        intent.setAction(MY_CUSTOM_BROADCAST);
//        intent.putExtra("data", "this is my custom mess");
//        sendBroadcast(intent);
//
//    }

    public void onSendBroadCast(View view) {
        Calendar calendar = Calendar.getInstance();
        int day = calendar.get(Calendar.DAY_OF_MONTH);
        int month = calendar.get(Calendar.MONTH);
        int year = calendar.get(Calendar.YEAR);
        TimePickerDialog dialog = new TimePickerDialog(this, new TimePickerDialog.OnTimeSetListener() {
            @Override
            public void onTimeSet(TimePicker v, int hourOfDay, int minute) {
                ((Button)view).setText(hourOfDay + ":" + minute );
            }
        },calendar.get(Calendar.HOUR), calendar.get(Calendar.MINUTE), true);
//        DatePickerDialog dialog = new DatePickerDialog(this, new DatePickerDialog.OnDateSetListener() {
//            @Override
//            public void onDateSet(DatePicker v, int year, int month, int dayOfMonth) {
//                ((Button)view).setText(dayOfMonth + "/" + month + "/" + year);
//            }
//        },year, month,day);
        dialog.show();
    }
}