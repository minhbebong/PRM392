package com.example.my_app_13_6;

import androidx.appcompat.app.AppCompatActivity;
import androidx.core.app.NotificationCompat;
import androidx.core.app.RemoteInput;


import android.app.Notification;
import android.app.NotificationChannel;
import android.app.NotificationManager;
import android.app.PendingIntent;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {
    String chanel_id = "first_channel";
    int count = 0;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        Bundle b = RemoteInput.getResultsFromIntent(getIntent());
        if (b != null){
            String s = b.getString("result_key");
            ((TextView)findViewById(R.id.textView)).setText(s);
        }
    }

    public void onPushNotification(View view) {
        NotificationManager manager =(NotificationManager) getSystemService(NOTIFICATION_SERVICE);
        if (android.os.Build.VERSION.SDK_INT >= android.os.Build.VERSION_CODES.O) {
            NotificationChannel channel = new NotificationChannel(chanel_id,
                    "My first channel", NotificationManager.IMPORTANCE_HIGH);
            manager.createNotificationChannel(channel);

            Intent intent = new Intent(this, MainActivity.class);
            PendingIntent pendIntent = PendingIntent.getActivity(this,1000,intent,PendingIntent.FLAG_UPDATE_CURRENT);

            RemoteInput remoteInput = new RemoteInput.Builder("result_key")
                    .setLabel("Input your message").build();

            NotificationCompat.Action action = new NotificationCompat.Action.Builder(
                    android.R.drawable.ic_btn_speak_now, "Reply" , pendIntent).addRemoteInput(remoteInput).build();


            NotificationCompat.Builder builder = new NotificationCompat.Builder(this, chanel_id);
            builder.setContentTitle("Thong bao khuyen mai")
                    .setContentText("Khai truong")
                    .setSmallIcon(android.R.drawable.ic_dialog_info)
                    .addAction(action);

            manager.notify(count,builder.build());
            count ++;
        }

    }
}