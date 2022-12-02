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

            var connectionString = "Host=localhost;Username=postgres;Password=12345678;Database=taxi";
            using var connection = new NpgsqlConnection(connectionString);
            
            connection.Open();
            
            using var cmd = new NpgsqlCommand();
            cmd.Connection = connection;
            try
            {
                cmd.Transaction = connection.BeginTransaction(System.Data.IsolationLevel.Serializable);
                cmd.CommandText = "update car set pasport = '111' where brand ='lada' ";
                cmd.ExecuteNonQuery();

                cmd.Transaction = connection.BeginTransaction(System.Data.IsolationLevel.Serializable);
                cmd.CommandText = "update car set pasport = '222' where brand ='lada'";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine(ex.Message);
            }
            
            
        }

    }
}