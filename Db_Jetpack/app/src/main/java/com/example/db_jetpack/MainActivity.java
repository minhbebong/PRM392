package com.example.db_jetpack;

import android.os.AsyncTask;
import androidx.appcompat.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import java.util.List;
import androidx.room.Room;

public class MainActivity extends AppCompatActivity {
    private EditText edtFirstName, edtLastName, edtUid;
    private TextView tvShow;
    private Button btnAdd, btnRead, btnRemove;
    private AppDatabase appDatabase;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        // Khởi tạo Room Database
        appDatabase = Room.databaseBuilder(getApplicationContext(),
                        AppDatabase.class, "my-database")
                .build();

        // Ánh xạ các view từ layout
        edtFirstName = findViewById(R.id.edt_firstname);
        edtLastName = findViewById(R.id.edt_lastname);
        edtUid = findViewById(R.id.edt_uid);
        tvShow = findViewById(R.id.tv_show);
        btnAdd = findViewById(R.id.btn_add);
        btnRead = findViewById(R.id.btn_read);
        btnRemove = findViewById(R.id.btn_remove);

        // Đăng ký sự kiện click cho nút "Add"
        btnAdd.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                addUser();
            }
        });

        // Đăng ký sự kiện click cho nút "Read"
        btnRead.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                readUsers();
            }
        });

        // Đăng ký sự kiện click cho nút "Remove"
        btnRemove.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                removeUser();
            }
        });
    }

    private void addUser() {
        String firstName = edtFirstName.getText().toString();
        String lastName = edtLastName.getText().toString();

        // Thêm người dùng vào cơ sở dữ liệu
        User user = new User();
        user.setFirstName(firstName);
        user.setLastName(lastName);
        Thread t = new Thread(new Runnable() {
            @Override
            public void run() {

                new AddUserTask().execute(user);
            }
        });
        t.start();
    }

    private void readUsers() {
        Thread t = new Thread(new Runnable() {
            @Override
            public void run() {
                new ReadUsersTask().execute();
            }
        });
        t.start();
    }

    private void removeUser() {
        int uid = Integer.parseInt(edtUid.getText().toString());

        // Xóa người dùng khỏi cơ sở dữ liệu
        User user = new User();
        user.setUid(uid);
        Thread t = new Thread(new Runnable() {
            @Override
            public void run() {
                new RemoveUserTask().execute(user);
            }
        });
        t.start();
    }

    private class AddUserTask extends AsyncTask<User, Void, Void> {
        @Override
        protected Void doInBackground(User... users) {
            UserDao userDao = appDatabase.userDao();
            userDao.insertAll(users[0]);
            return null;
        }

        @Override
        protected void onPostExecute(Void aVoid) {
            edtFirstName.setText("");
            edtLastName.setText("");
            readUsers();
        }
    }

    private class ReadUsersTask extends AsyncTask<Void, Void, List<User>> {
        @Override
        protected List<User> doInBackground(Void... voids) {
            UserDao userDao = appDatabase.userDao();
            return userDao.getAll();
        }

        @Override
        protected void onPostExecute(List<User> users) {
            StringBuilder stringBuilder = new StringBuilder();
            for (User user : users) {
                stringBuilder.append("ID: ").append(user.getUid())
                        .append(", First Name: ").append(user.getFirstName())
                        .append(", Last Name: ").append(user.getLastName())
                        .append("\n");
            }
            tvShow.setText(stringBuilder.toString());
        }
    }

    private class RemoveUserTask extends AsyncTask<User, Void, Void> {
        @Override
        protected Void doInBackground(User... users) {
            UserDao userDao = appDatabase.userDao();
            userDao.removeUser(users[0]);
            return null;
        }

        @Override
        protected void onPostExecute(Void aVoid) {
            edtUid.setText("");
            readUsers();
        }
    }
}
