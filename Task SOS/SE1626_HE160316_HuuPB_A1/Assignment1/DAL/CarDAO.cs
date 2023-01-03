using Assignment1.DTL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.DAL
{
    internal class CarDAO : DAO
    {
        private static CarDAO instance;
        private CarDAO() : base() { }

        static CarDAO()
        {
            instance = new CarDAO();
        }

        public static CarDAO GetInstance() => instance;

        public DataTable GetDataTable() => base.GetDataTable("SELECT * FROM cars");
        public Car getCarById(int id)
        {
            string sql = "SELECT * FROM Cars WHERE carID = @id";
            SqlCommand cmd = new SqlCommand(sql, DAO.sqlConnection);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            Car car = null;
            if (reader.Read())
            {
                car = new Car();
                car.CarId = reader.GetInt32(0);
                car.Make = reader.GetString(1);
                car.Color = reader.GetString(2);
                car.PetName = reader.GetString(3);
            }
            reader.Close();
            return car;
        }
    

        public bool Insert(Car car)
        {
            SqlCommand cmd = new SqlCommand("Insert into Cars(make, color, petName) Values(@make, @color, @petName)");
            cmd.Parameters.AddWithValue("@make", car.Make);
            cmd.Parameters.AddWithValue("@color", car.Color);
            cmd.Parameters.AddWithValue("@petName", car.PetName);

            return base.Update(cmd);
        }

        public bool Edit(Car car)
        {
            SqlCommand cmd = new SqlCommand("Update Cars SET make=@make, color=@color, petName=@petName WHERE carID = @carId");
            cmd.Parameters.AddWithValue("@make", car.Make);
            cmd.Parameters.AddWithValue("@color", car.Color);
            cmd.Parameters.AddWithValue("@petName", car.PetName);
            cmd.Parameters.AddWithValue("@carId", car.CarId);

            return base.Update(cmd);
        }
        public bool isCarExist(Car car)
        {
           
                SqlCommand cmd = new SqlCommand("SELECT * FROM Cars WHERE carID = @carId", DAO.sqlConnection);
                cmd.Parameters.AddWithValue("@carId", car.CarId);
                using var reader = cmd.ExecuteReader();
                return reader.Read();
            
        }
        public bool Delete(int carId)
        {

            SqlCommand cmd = new SqlCommand("DELETE from Cars WHERE carID = @carId");

            cmd.Parameters.AddWithValue("@carId", carId);

            return base.Update(cmd);

        }
    }
}
