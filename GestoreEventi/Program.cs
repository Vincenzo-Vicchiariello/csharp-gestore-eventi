// See https://aka.ms/new-console-template for more information
using GestoreEventi;
using System.Runtime.InteropServices;

Event Event1 = new Event("Salviamo le capesante","26/05/2024", 50);


//Visto che funziona tutto, procedo a far creare un metodo dall'utente finale tramite console.

Event Event2 = new Event("placeholder title", "28/04/2023", 1);


Console.WriteLine("Come si chiama l'evento?");
Event2.SetTitle(Console.ReadLine());

Console.WriteLine("Quando ci sarà l'evento? (GG/MM/AAAA)");
Event2.SetDate(Console.ReadLine());

Console.WriteLine("Quanti posti ci saranno?");
Event2.SetMaxCap(Console.ReadLine());

Console.WriteLine("Quante prenotazioni sono già state effettuate?");
Event2.ReserveSpotsFromConsole(Console.ReadLine());

Console.WriteLine(Event2);


bool yesorno  = true;

while (yesorno)
{
    Console.WriteLine("Si desidera disdire dei posti?");
    string questionAnswer = Console.ReadLine();
    if (questionAnswer =="si")
        {
        Console.Write("Quanti posti vuoi disdire?");
            Event2.CancelReservationFromConsole(Console.ReadLine());
            Console.WriteLine(Event2.EventSpotsToString());
        
     }
    if (questionAnswer == "no")
    {
        yesorno = false;
        Console.WriteLine(Event2.EventSpotsToString());

        break;
    }
}