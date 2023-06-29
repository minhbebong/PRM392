package com.example.contentproviders;

import androidx.appcompat.app.AppCompatActivity;

import android.Manifest;
import android.content.ContentResolver;
import android.content.pm.PackageManager;
import android.database.Cursor;
import android.os.Bundle;
import android.provider.ContactsContract;
import android.view.View;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    ContentResolver resolver;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        requestPhonePermision(android.Manifest.permission.READ_CONTACTS, 100);
        requestPhonePermision(Manifest.permission.READ_PHONE_NUMBERS, 101);
        resolver = getContentResolver();
    }

    public void readContact(View view) {
        Cursor c = resolver.query(ContactsContract.Contacts.CONTENT_URI,
                new String[]{ContactsContract.Contacts._ID, ContactsContract.Contacts.DISPLAY_NAME},
                null, null, null);
        String contacts = "";
        while (c.moveToNext()){
            int index_id = c.getColumnIndex(ContactsContract.Contacts._ID);
            int id = c.getInt(index_id);
            int index_name = c.getColumnIndex(ContactsContract.Contacts.DISPLAY_NAME);
            String name = c.getString(index_name);
            Cursor c_phone = resolver.query(ContactsContract.CommonDataKinds.Phone.CONTENT_URI,
                    new String[]{ContactsContract.CommonDataKinds.Phone.NUMBER},ContactsContract.CommonDataKinds.Phone.CONTACT_ID + "=?",
                    new String[]{String.valueOf(id)}, null);
            String phones = "";
            while (c_phone.moveToNext()){
                int idx_phone = c_phone.getColumnIndex(ContactsContract.CommonDataKinds.Phone.NUMBER);
                String phone = c_phone.getString(idx_phone);
                phones += phone +"|";
            }
            contacts += id + ": " + name + ", " + phones;
        }
        ((TextView)findViewById(R.id.textView)).setText(contacts);
    }

    public void requestPhonePermision(String permission, int requestCode) {
        if (checkSelfPermission(permission) != PackageManager.PERMISSION_GRANTED){
            requestPermissions(new String[] {permission}, requestCode);
        }
    }
}