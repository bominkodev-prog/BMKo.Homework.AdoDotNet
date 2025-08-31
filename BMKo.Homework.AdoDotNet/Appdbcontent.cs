using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMKo.Homework.AdoDotNet
{
    public class Appdbcontent : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            SqlConnectionStringBuilder sql1 = new SqlConnectionStringBuilder()
            {
                DataSource = ".",
                InitialCatalog = "BMKHomeworkDatabase",
                UserID = "sa",
                Password = "sasa@123",
                TrustServerCertificate = true
            };
            optionsBuilder.UseSqlServer(sql1.ConnectionString);

        }


        public DbSet<homeworktbl> Items { get; set; }

        



    }

   
    
}
