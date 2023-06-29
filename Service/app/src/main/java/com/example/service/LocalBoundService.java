package com.example.service;

import android.app.Service;
import android.content.Intent;
import android.os.Binder;
import android.os.IBinder;

import java.util.Date;

public class LocalBoundService extends Service {
    public MyBinder myBinder = new MyBinder();

    public LocalBoundService() {
    }

    @Override
    public IBinder onBind(Intent intent) {
       return myBinder;
    }

    public String getCurrentTime(){
        return new Date().toString();
    }

    class MyBinder extends Binder {
        public LocalBoundService getService(){
            return LocalBoundService.this;
        }
    }
}