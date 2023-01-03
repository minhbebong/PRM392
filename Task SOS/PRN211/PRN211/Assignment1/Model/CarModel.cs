using Assignment1.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Model
{
    public class CarModel : ModelBase
    {
        public static List<Car> GetAllCars()
        {
            List<Car> cars = new List<Car>();

            using (var command = Connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM [Cars]";
                using (var reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        cars.Add(new Car()
                        {
                            CarID = reader.GetInt32(0),
                            Make = reader.GetString(1),
                            Color = reader.GetString(2),
                            PetName = reader.GetString(3)
                        });
                    }
                }
            }
            return cars;
        }

        public static bool IsCarExist(Car car)
        {
            using (var command = Connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM [Cars] WHERE [CarID] = @CarID";
                command.Parameters.AddWithValue("@CarID", car.CarID);

                using var reader = command.ExecuteReader();
                return reader.Read();
            }
        }
        
        public static int DeleteCar(Car car)
        {
            using (var command = Connection.CreateCommand())
            {
                command.CommandText = "DELETE FROM [Cars] WHERE CarID = @CarID";
                command.Parameters.AddWithValue("@CarID", car.CarID);

                return command.ExecuteNonQuery();
            }
        }

        public static int UpdateCar(Car car)
        {
            using (var command = Connection.CreateCommand())
            {
                command.CommandText = "UPDATE [Cars] SET Make = @Make, Color = @Color, PetName = @PetName WHERE CarID = @CarID";
                command.Parameters.AddWithValue("@CarID", car.CarID);
                command.Parameters.AddWithValue("@Make", car.Make ?? string.Empty);
                command.Parameters.AddWithValue("@Color", car.Color ?? string.Empty);
                command.Parameters.AddWithValue("@PetName", car.PetName ?? string.Empty);

                return command.ExecuteNonQuery();
            }
        }

        public static int AddCar(Car car)
        {
            using (var command = Connection.CreateCommand())
            {
                command.CommandText = "SET IDENTITY_INSERT Cars ON";
                command.ExecuteNonQuery();

                command.Parameters.Clear();
                command.CommandText = "INSERT INTO [Cars]([CarID], [Color], [Make], [PetName]) VALUES (@CarID, @Make, @Color, @PetName)";
                command.Parameters.AddWithValue("@CarID", car.CarID);
                command.Parameters.AddWithValue("@Make", car.Make ?? string.Empty);
                command.Parameters.AddWithValue("@Color", car.Color ?? string.Empty);
                command.Parameters.AddWithValue("@PetName", car.PetName ?? string.Empty);

                return command.ExecuteNonQuery();
            }
        }
    }
}
