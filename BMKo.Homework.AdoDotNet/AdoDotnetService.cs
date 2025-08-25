using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMK.Homework.AdoDotNet.ConsoleApp
{
    public class AdoDotnetServices
    {
        SqlConnectionStringBuilder sql1 = new SqlConnectionStringBuilder()
        {
            DataSource = ".",
            InitialCatalog = "BMKHomeworkDatabase",
            UserID = "sa",
            Password = "sasa@123",
            TrustServerCertificate = true
        };

        public void Create()
        {
            SqlConnection con = new SqlConnection(sql1.ConnectionString);
            con.Open();
            string queryInsert = @"  
            
                    
INSERT INTO [dbo].[homeworktbl]
           ([Item_name]
           ,[Item_subcategories]
           ,[Item_categories]
           ,[Item_group]
           ,[Barcode]
           ,[deleteflage])
     VALUES
                ('EchoBeat ', 'Headphones', 'Electronics', 'Audio','740356',  0),
                ('SoundWave', 'Speakers', 'Electronics', 'Audio','325346',  0),
                ('ClearVoice', 'Microphones', 'Electronics', 'Audio','756645', 0),
                ('UltraBook', 'Laptops', 'Electronics', 'Computers', '756455',0),
                ('MegaDesk PC', 'Desktops', 'Electronics', 'Computers','534465', 0),
                ('KeyMaster', 'Accessories', 'Electronics', 'Computers', '756446', 0)
                ";

            SqlCommand cmd = new SqlCommand(queryInsert, con);
            int result = cmd.ExecuteNonQuery();

            string message = result > 0 ? "Saving Successful" : "Saving Failed";
            Console.WriteLine(message);

        }
        public void Read()
        {
            SqlConnection con = new SqlConnection(sql1.ConnectionString);
            con.Open();
            string query = @"
               SELECT [Item_code]
      ,[Item_name]
      ,[Item_subcategories]
      ,[Item_categories]
      ,[Item_group]
      ,[Barcode]
      ,[deleteflage]
  FROM [dbo].[homeworktbl]
";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            Adapter.Fill(dt1);
            foreach (DataRow dr in dt1.Rows)
            {

                Console.WriteLine($"{dr["Item_code"]}\t" +
                    $" {dr["Item_name"]}\t" +
                    $" {dr["Item_subcategories"]}\t" +
                    $" {dr["Item_categories"]}\t" +
                    $"{dr["Item_group"]}\t");

            }
        }
        public void Update()
        {
            SqlConnection con = new SqlConnection(sql1.ConnectionString);
            con.Open();
            string queryUpdate = @"
            update homeworktbl
            set Item_name = 'AirpodMax'
            where Item_code = 5";
            SqlCommand cmd = new SqlCommand(queryUpdate, con);
            int result = cmd.ExecuteNonQuery();

            string message = result > 0 ? "Update Successful" : "Update Failed";
            Console.WriteLine(message);
        }
        public void Delete()
        {
            SqlConnection con = new SqlConnection(sql1.ConnectionString);
            con.Open();
            string queryDelete = @"
                update homeworktbl
                set deleteflage = 1
                where Item_code = 4";
            SqlCommand cmd = new SqlCommand(queryDelete, con);
            int result = cmd.ExecuteNonQuery();

            string message = result > 0 ? "Delete Successful" : "Delete Failed";
            Console.WriteLine(message);
        }


    }
}
