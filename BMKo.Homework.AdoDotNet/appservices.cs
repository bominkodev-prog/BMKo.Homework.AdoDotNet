using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMKo.Homework.AdoDotNet
{
    public class appservices
    {
        public void Read()
        {

            Appdbcontent db = new Appdbcontent();
            List<homeworktbl> lst = db.Items.ToList();
            foreach (var item in lst)
            {
                //string a = $"dsnfasid{item.StudentNo}fnsaidfasfnsanf";
                Console.WriteLine($"{item.Item_code} - {item.Item_name} - {item.Item_group}");
            }



        }

        public void Write()
        {
            Appdbcontent db = new Appdbcontent();

            homeworktbl student = new homeworktbl();
            student.Item_name = "Chair";
            student.Item_group = "wooden item";
            student.Item_subcategories = "homemade";
            student.Item_categories = "Homeused";
            student.Barcode = "225355";

            db.Items.Add(student);
            int result = db.SaveChanges();
            Console.WriteLine(result > 0 ? "saving successful " : "saving failed");
        }

        public void Update()
        {
            Appdbcontent db = new Appdbcontent();

            homeworktbl? edititem = db.Items.Where(x => x.Item_code == 10).FirstOrDefault();
            if (edititem is not null)
            {
                edititem = "Music box";
                db.SaveChanges();
                int result = db.SaveChanges();
                Console.WriteLine(result > 0 ? "saving successful " : "saving failed");
            }

        }

        public void Delete()
        {
            Appdbcontent db = new Appdbcontent();
            homeworktbl? removeitem = db.Items.Where(x => x.Item_code == 11).FirstOrDefault();
            if (removeitem is not null)
            {
                db.Items.Remove(removeitem);
                db.SaveChanges();
                int result = db.SaveChanges();
                Console.WriteLine(result > 0 ? "saving successful " : "saving failed");
            }

        }
    }
}
