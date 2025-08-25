using BMK.Homework.AdoDotNet.ConsoleApp;

AdoDotnetServices ado =  new AdoDotnetServices();

Console.WriteLine("data is loading");
Console.WriteLine();
ado.Read();
Console.WriteLine("data is creating");
Console.WriteLine();
ado.Create();
Console.WriteLine("data is updating");
Console.WriteLine();
ado.Update();
Console.WriteLine("data is deleting");
Console.WriteLine();
ado.Delete();
