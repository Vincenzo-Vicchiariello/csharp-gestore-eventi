using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    public class Event
    {
        private string title;
        private DateTime date;
        private int maxCapacity = 0;
        private int reservedSpots = 0;

    public Event(string title, string date, int maxCapacity, int reservedSpots)
    {
            this.title = title;
            this.date = DateTime.Parse(date);
            this.maxCapacity = maxCapacity;
            this.reservedSpots = reservedSpots;
    }
        


        public void SetTitle(string newTitle)
        {
            title = newTitle;
        
          }

        public string GetTitle()
        {
            return title;
        }



        public override string ToString()
        {
            string eventInfo =  "----------------------------------\n"+
                                $"Nome dell'evento: {title} \n" +
                                $"Data: {date.ToString("dd/MM/yyyy")}\n"+
                                $"Capienza massima: {maxCapacity}\n"+
                                $"Prenotazioni effettuate: {reservedSpots}\n"+
                                "----------------------------------\n";
            return eventInfo;

        }


        public void SetDate(string newDate)
        {            
            
            date= DateTime.Parse(newDate);
        }

        public string GetDate()
        {
           
            return date.ToString("dd/MM/yyyy");
        }



        public int GetMaxCap()
        {
            return maxCapacity;
        }



        public int GetReservedSpots() { 
        
            return reservedSpots;
        }



        public void ReserveSpots(int x) 
        {
            if (reservedSpots + x > maxCapacity) {
                throw new Exception("Non puoi prenotare così tanti posti, superi la capacità massima.");
            }
            else
                {
                    reservedSpots = x + reservedSpots;
                }
        }
    }



}
