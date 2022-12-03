using System.Text.Json;
using DB.Lesson2;
using Npgsql;
using DB.HW2;
namespace DB
{
    public class Program
    {
        public static void Main()
        {
            //Json - class work
            //Lesson2Runner.Run();

            //Json/XML - HW2    
            //HW2Runner.Run();

            var connectionString = "Host=localhost;Username=postgres;Password=12345678;Database=taxi_table";
            using var connection = new NpgsqlConnection(connectionString);
            
            connection.Open();
            
            using var cmd = new NpgsqlCommand();
            cmd.Connection = connection;
            try
            {
                cmd.Transaction = connection.BeginTransaction(System.Data.IsolationLevel.Serializable);
                cmd.CommandText = "update car set passport = '111' where brand ='lada' ";
                cmd.ExecuteNonQuery();

                cmd.Transaction = connection.BeginTransaction(System.Data.IsolationLevel.Serializable);
                cmd.CommandText = "update car set passport = '222' where brand ='lada'";
                cmd.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }   
        }
    }
}