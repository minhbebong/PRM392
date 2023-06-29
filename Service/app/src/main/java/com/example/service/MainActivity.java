package com.example.service;

import androidx.appcompat.app.AppCompatActivity;

import android.content.ComponentName;
import android.content.Intent;
import android.content.ServiceConnection;
import android.os.Bundle;
import android.os.IBinder;
import android.view.View;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {
    LocalBoundService service;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        Intent intent = new Intent(this, LocalBoundService.class);
        bindService(intent,connection,BIND_AUTO_CREATE);
    }

    ServiceConnection connection = new ServiceConnection() {
        @Override
        public void onServiceConnected(ComponentName name, IBinder iBinder) {
            service = ((LocalBoundService.MyBinder)iBinder).getService();

        }

        @Override
        public void onServiceDisconnected(ComponentName name) {
        }
    };
    public void onStartService(View view) { // onClick button
        String time = service.getCurrentTime();
        ((TextView)findViewById(R.id.textView)).setText(time);
//        Intent intent = new Intent(this, MyService.class);
////        startService(intent);//StartService
//        bindService(intent,connection,BIND_AUTO_CREATE);
    }
}