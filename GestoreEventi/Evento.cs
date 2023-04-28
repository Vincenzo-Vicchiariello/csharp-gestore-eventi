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
        private int maxCapacity;
        private int reservedSpots = 0;
     
    public Event(string title, string date, int maxCapacity)
    {
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new Exception("Non c'è un titolo..");
            }
            else { this.title = title; }


            this.date = DateTime.Parse(date);
            if (this.date < DateTime.Today)
            {
                throw new Exception("Vuoi creare un evento nel passato?");

            }
            else { this.date = DateTime.Parse(date); }
            
            this.maxCapacity = maxCapacity;
            if (this.maxCapacity <= 0) 
            { throw new Exception("Vuoi creare un evento con 0 posti?");
            }
           else {this.maxCapacity = maxCapacity; }
            
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
            if (date < DateTime.Today)
            {
                throw new Exception("Vuoi creare un evento nel passato?");
                
            }
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
            if (x <= 0) { throw new Exception("Non puoi aggiungere 0 prenotazioni o inserire un numero negativo."); }
            
            else { 
            
                if (reservedSpots + x > maxCapacity) {
                        throw new Exception("Non puoi prenotare così tanti posti, superi la capacità massima.");
                    }

                    else
                        {
                            reservedSpots = x + reservedSpots;
                        }
            }
        }


        public void CancelReservation(int x)
        {
            if (reservedSpots - x < 0)
            {
                throw new Exception("Stai cancellando più prenotazioni di quante ce ne sono..");
            }
            else reservedSpots = reservedSpots - x;
        }



        
    }



}
