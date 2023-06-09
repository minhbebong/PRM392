package com.example.recyclerviewdemo;

import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.os.Bundle;

import java.util.ArrayList;
import java.util.List;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        List<Chapter> list = new ArrayList<>();
        Chapter c1 = new Chapter(R.drawable.android_image_1,"Chapter one","Hello world");
        Chapter c2 = new Chapter(R.drawable.android_image_2,"Chapter two","Layout");
        Chapter c3 = new Chapter(R.drawable.android_image_3,"Chapter three","Activity");
        Chapter c4 = new Chapter(R.drawable.android_image_4,"Chapter four","Intent");
        Chapter c5 = new Chapter(R.drawable.android_image_5,"Chapter five","Android recyclerview");
        Chapter c6 = new Chapter(R.drawable.android_image_6,"Chapter six","Fragment");
        list.add(c1);
        list.add(c2);
        list.add(c3);
        list.add(c4);
        list.add(c5);
        list.add(c6);
        ChapterAdapter adapter = new ChapterAdapter(list);
        RecyclerView rec = findViewById(R.id.rec_chapter);
        RecyclerView.LayoutManager layout_manager = new LinearLayoutManager(this);
        rec.setLayoutManager(layout_manager);
        rec.setAdapter(adapter);
    }
}