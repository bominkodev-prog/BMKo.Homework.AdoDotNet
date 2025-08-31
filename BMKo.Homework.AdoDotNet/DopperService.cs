using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMKo.Homework.AdoDotNet
{
    public class DopperService
    {

        SqlConnectionStringBuilder sql = new SqlConnectionStringBuilder()
        {
            DataSource = ".",
            InitialCatalog = "BMKHomeworkDatabase",
            UserID = "sa",
            Password = "sasa@123",
            TrustServerCertificate = true
        };
        public void Read()
        {
           using IDbConnection db = new SqlConnection(sql.ConnectionString);
            db.Open();
            List<student> lst = db.Query<student>("select * from homeworktbl").ToList();
            for (int i = 0; i < lst.Count; i++)
            {

                student item = lst[i];
                Console.WriteLine($"{i+1} {item.Item_name} {item.Item_group}");
            }



        }

        public void Create()
        {
            using IDbConnection db = new SqlConnection(sql.ConnectionString);
            db.Open();
            int result = db.Execute(@"
INSERT INTO [dbo].[homeworktbl]
           ([Item_name]
           ,[Item_subcategories]
           ,[Item_categories]
           ,[Item_group]
           ,[Barcode]
           ,[deleteflage])
     VALUES
           ('i phone', 'mobile', 'electronic','e phone', '325343',0)");

            Console.WriteLine(result > 0 ?  "saving successful" : "saving failed");
        }
        public void Update()
        {
            using IDbConnection db = new SqlConnection(sql.ConnectionString);
            db.Open();
            int result = db.Execute(@"update [dbo].[homeworktbl]
set [Item_name] = 'Nat tha Mee'
where Item_code = 2");
        }

        public void Delete()
        {
            using IDbConnection db = new SqlConnection(sql.ConnectionString);
            db.Open();
            int result = db.Execute(@"update [dbo].[homeworktbl]
set deleteflage = 1
where Item_code = 2");
        }
    }
}
