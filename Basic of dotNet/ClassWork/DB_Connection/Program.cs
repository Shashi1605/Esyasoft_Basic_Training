using System;
using System.Data.SqlClient;
namespace DB_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Getting Connection ...");

            var datasource = @"LAPTOP-S740B7J3\SQLEXPRESS"; // your server
            var database = "v2_DB_Demo"; 

            // Create your connection string
            string connString = @"Data Source=" + datasource +
                ";Initial Catalog=" + database + "; Trusted_Connection=True;";


            Console.WriteLine(connString);

            SqlConnection conn = new SqlConnection(connString);

            try
            {
                Console.WriteLine("Opening Connection ...");
                // Open the connection
                conn.Open();
                Console.WriteLine("Connection successful!");
                InsertStaff(conn);
                displayStaff(conn);

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                // Close the connection
                conn.Close();
            }


        }
        static void InsertStaff(SqlConnection conn)
        {
            Console.Write("Enter the Staff Name...");

            int Std_id = 102;
            string Std_name = "Jyotsana Priya";
            string Std_contact = "7633827049";

            string querry = "insert into Student values(@Std_id, @Std_name, @Std_contact)";
            SqlCommand cm = new SqlCommand(querry, conn);
            cm.Parameters.AddWithValue("@Std_id", Std_id);
            cm.Parameters.AddWithValue("@Std_name", Std_name);
            cm.Parameters.AddWithValue("@Std_contact", Std_contact);
            int rows = cm.ExecuteNonQuery();
            if (rows > 0)
            {
                Console.WriteLine("Inseted recordsuccessfully");
            }


        }
        static void displayStaff(SqlConnection conn)
        {
            string query = "select * from Student";
            SqlCommand cm = new SqlCommand(query, conn);
            SqlDataReader reader = cm.ExecuteReader();
            Console.WriteLine("---------------------------Student-------------------------------");
            while (reader.Read())
            {
                {
                    Console.WriteLine($"Student ID :{reader["Std_id"]}");
                    Console.WriteLine($"Student Name :{reader["Std_name"]}");
                    Console.WriteLine($"Student Contact N0. :{reader["Std_contact"]}");
                    Console.WriteLine("----------------------------------------------------");

                }
            }
        }
    }
}



