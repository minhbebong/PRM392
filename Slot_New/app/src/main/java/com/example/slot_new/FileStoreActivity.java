package vn.edu.fe.storagefiledemo;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import com.example.slot_new.R;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;
import java.nio.charset.StandardCharsets;

public class FileStoreActivity extends AppCompatActivity {
    EditText edt_id;
    EditText edt_name;
    EditText edt_quantity;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        edt_id = findViewById(R.id.edt_id);
        edt_name = findViewById(R.id.edt_name);
        edt_quantity =findViewById(R.id.edt_quantity);

    }

    public void storeData(View view) {
        String value = edt_id.getText().toString() + "," + edt_name.getText().toString()
                + "," + edt_quantity.getText().toString() + "\n";
        try {
            FileOutputStream fileOutputStream = openFileOutput("product.txt",
                    Context.MODE_APPEND);
            OutputStreamWriter os = new OutputStreamWriter(fileOutputStream);
            BufferedWriter bfw = new BufferedWriter(os);
            bfw.write(value);
            bfw.close();
            os.close();
            fileOutputStream.close();
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
    public void readData (View view) {
        try {
            FileInputStream fis = openFileInput("product.txt");
            InputStreamReader is = new InputStreamReader(fis, StandardCharsets.UTF_8);
            BufferedReader bfr = new BufferedReader(is);
            String line = "";
            String result = "";
            while ((line = bfr.readLine()) != null) {
                result += line + "\n";
            }
            ((TextView)findViewById(R.id.tv_result)).setText(result);
            bfr.close();
            is.close();
            fis.close();
//            Toast.makeText(this, result, Toast.LENGTH_LONG).show();
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}