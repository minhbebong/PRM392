package com.example.broadcastreciever;

import android.app.AlertDialog;
import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.DialogInterface;
import android.content.Intent;

public class MyReceiver extends BroadcastReceiver {

    @Override
    public void onReceive(Context context, Intent intent) {
        String message = "";
        if(intent.getAction().contains(Intent.ACTION_BATTERY_LOW)){
            message = "Pin yeu, can cam sac de tiep tuc";
        } else if (intent.getAction().contains(MainActivity.MY_CUSTOM_BROADCAST)) {
            message = intent.getStringExtra("data");
        }
        AlertDialog.Builder builder = new AlertDialog.Builder(context);
        builder.setTitle("Thong bao")
                .setMessage(message)
                .setIcon(android.R.drawable.ic_dialog_alert)
                .setPositiveButton("OK", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int which) {

                    }
                }).setNegativeButton("Cancel", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int which) {

                    }
                });
        AlertDialog dialog = builder.create();
        dialog.show();
    }
}