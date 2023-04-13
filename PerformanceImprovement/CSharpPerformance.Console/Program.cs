// See https://aka.ms/new-console-template for more information

using CSharpPerformance.Code;

var database = new Database("Data Source=LAPTOP-3G4SAB89\\SQLEXPRESS;Initial Catalog=Samples;Integrated Security=True;TrustServerCertificate=true");
database.GetPersonByName("Bruno");

Console.ReadKey();