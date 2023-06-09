package com.example.recyclerviewdemo;

public class Chapter {
    private int avatar;
    private String title;
    private String des;

    public Chapter(int avatar, String title, String des) {
        this.avatar = avatar;
        this.title = title;
        this.des = des;
    }

    public int getAvatar() {
        return avatar;
    }

    public void setAvatar(int avatar) {
        this.avatar = avatar;
    }

    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    public String getDes() {
        return des;
    }

    public void setDes(String des) {
        this.des = des;
    }
}
