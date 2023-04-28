// See https://aka.ms/new-console-template for more information
using GestoreEventi;

Event Event1 = new Event("Salviamo le capocchie","26/05/2024", 50, 0);

Console.WriteLine(Event1);

Event1.SetTitle("Salviamo le capesante");

Console.WriteLine(Event1);

Console.WriteLine(Event1.GetTitle());


Event Event2 = new Event("Incontro di boxe fra detenuti della casa circondariale di Secondigliano", "31/07/2023", 223, 0);
Console.WriteLine(Event2);

Event2.SetDate("26/05/2023");
Console.WriteLine(Event2);

Event2.ReserveSpots(10);
Console.WriteLine(Event2);



Event2.ReserveSpots(10000);
Console.WriteLine(Event2);