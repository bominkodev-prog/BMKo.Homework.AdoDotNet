////using BMK.Homework.AdoDotNet.ConsoleApp;

////AdoDotnetServices ado =  new AdoDotnetServices();

////Console.WriteLine("data is loading");
////Console.WriteLine();
////ado.Read();
////Console.WriteLine("data is creating");
////Console.WriteLine();
////ado.Create();
////Console.WriteLine("data is updating");
////Console.WriteLine();
////ado.Update();
////Console.WriteLine("data is deleting");
////Console.WriteLine();
////ado.Delete();


//using BMKo.Homework.AdoDotNet;

//class program
//{
//    static void Main(string[] args)
//    {

//        DopperService dd = new DopperService();
//        //Console.WriteLine("data is reading");
//        //dd.Read();

//        Console.WriteLine("data is creating");
//        dd.Create();
//    }


//}


//using BMKo.Homework.AdoDotNet;

//Appdbcontent app   = new Appdbcontent();

//Console.WriteLine("data is reding");
//app.Read();


using BMKo.Homework.AdoDotNet;

appservices app = new appservices();


Console.WriteLine("data is reading");
app.Read();

Console.WriteLine("data is creating");
app.Write();


Console.WriteLine("data is updating");
app.Update();

Console.WriteLine("data is deleting");
app.Delete();