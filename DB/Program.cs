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
            
            using var cmd2 = new NpgsqlCommand();
            cmd2.Connection = connection;
            cmd2.CommandText = "update car set passport = '999' where brand ='Priora' ";
            cmd2.ExecuteNonQuery();
            
            
            using var cmd = new NpgsqlCommand();
            cmd.Connection = connection;
            try
            {
                cmd.Transaction = connection.BeginTransaction(System.Data.IsolationLevel.Serializable);
                cmd.CommandText = "update car set passport = '666' where brand ='Priora' ";
                cmd.ExecuteNonQuery();

                cmd.Transaction = connection.BeginTransaction(System.Data.IsolationLevel.Serializable);
                cmd.CommandText = "update car set passport = '000' where brand ='Priora'";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                cmd.Cancel();
                cmd.Dispose();
                
                cmd.Transaction = connection.BeginTransaction(System.Data.IsolationLevel.Serializable);
                cmd.CommandText = "update car set passport = '666' where brand ='Priora' ";
                cmd.ExecuteNonQuery();

            }
            
            
        }

    }
}