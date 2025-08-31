using BMKo.Homework.AdoDotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace BMKo.Homework.AdoDotNet
{
    public class student
    {
        public int Item_code { get; set; }            // Identity, Primary Key
        public string Item_name { get; set; }         // varchar(50), NOT NULL
        public string Item_subcategories { get; set; } // varchar(50), NOT NULL
        public string Item_categories { get; set; }   // varchar(50), NOT NULL
        public string Item_group { get; set; }        // varchar(50), NOT NULL
        public string Barcode { get; set; }           // varchar(50), NOT NULL
        public bool? deleteflage { get; set; }
    }
}

