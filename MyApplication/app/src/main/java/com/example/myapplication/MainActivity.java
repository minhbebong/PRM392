package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;
import androidx.fragment.app.FragmentManager;
import androidx.fragment.app.FragmentTransaction;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class MainActivity extends AppCompatActivity implements View.OnClickListener {
    FragmentManager fragManager;
    FragmentTransaction transaction;
    FragmentA fragA;
    FragmentB fragB;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        fragManager = getSupportFragmentManager();
        ((Button)findViewById(R.id.btn_add)).setOnClickListener(this);
        ((Button)findViewById(R.id.btn_replace)).setOnClickListener(this);
        ((Button)findViewById(R.id.btn_remove)).setOnClickListener(this);
        fragA = FragmentA.newInstance(null,null);
        fragB = FragmentB.newInstance(null,null);
    }

    @Override
    public void onClick(View v) {
        if(v.getId() == R.id.btn_add){
            transaction = fragManager.beginTransaction();
            transaction.add(R.id.fr_container,fragA,"Hello Beo");
            transaction.commit();
        } else if (v.getId() == R.id.btn_replace) {
            transaction = fragManager.beginTransaction();
            transaction.replace(R.id.fr_container,fragB,"Hello Beo");
            transaction.addToBackStack("");
            transaction.commit();
        } else if (v.getId() == R.id.btn_remove) {
            transaction = fragManager.beginTransaction();
            transaction.remove(fragB);
            transaction.commit();
        }
    }

    public void goToFragB (String text) {
        fragB = FragmentB.newInstance(text,null);
        transaction = fragManager.beginTransaction();
        transaction.replace(R.id.fr_container,fragB,"Hello Beo");
        transaction.addToBackStack("");
        transaction.commit();
    }

    @Override
    public void onBackPressed() {
        super.onBackPressed();
        //Control flow back
    }
}