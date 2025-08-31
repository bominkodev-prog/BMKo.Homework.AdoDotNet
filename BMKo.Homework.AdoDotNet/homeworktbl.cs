using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMKo.Homework.AdoDotNet
{

    [Table("homeworktbl")]
    public class homeworktbl
    {
        [Key]
        public int Item_code { get; set; }            // Identity, Primary Key
        public string Item_name { get; set; }         // varchar(50), NOT NULL
        public string Item_subcategories { get; set; } // varchar(50), NOT NULL
        public string Item_categories { get; set; }   // varchar(50), NOT NULL
        public string Item_group { get; set; }        // varchar(50), NOT NULL
        public string Barcode { get; set; }           // varchar(50), NOT NULL
        public bool? deleteflage { get; set; }

        public static implicit operator homeworktbl(string v)
        {
            throw new NotImplementedException();
        }
    }
}
