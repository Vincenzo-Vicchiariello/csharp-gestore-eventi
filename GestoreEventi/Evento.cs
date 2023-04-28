using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    public class Event
    {
        private string title = string.Empty;
        private string date = DateTime.Today.ToString("yy-MM-yyyy");
        private int maxCapacity = 0;
        private int reservedSpots = 0;

    public Event(string title, string date, int maxCapacity, int reservedSpots)
    {
            this.title = title;
            this.date = date;
            this.maxCapacity = maxCapacity;
            this.reservedSpots = reservedSpots;
    }
        


        public string setTitle()
        {
            this.title = Console.ReadLine();
            this.title = title;


            return title;
        
          }

        public override string ToString()
        {
            string eventInfo = $"Nome dell'evento: {title} \n" +
                                $"Data: {date}\n"+
                                $"Capienza massima: {maxCapacity}\n"+
                                $"Prenotazioni effettuate: {reservedSpots}";
            return eventInfo;

        }

    }

}
