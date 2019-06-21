using System;

namespace _04_Outings
{
        public enum EventType
        {
            Golf,
            Bowling,
            AmusementPark,
            Concert
        }

        public class Outings
    {
        public EventType TypeOfEvent { get; set; }
        public int NumberOfPeople { get; set; }
        public DateTime Dates { get; set; }
        public decimal CostPerPerson { get; set; }
        public decimal CostOfEvent { get; set; }


        public Outings() { }
        public Outings(EventType typeOfEvent, int numberOfPeople, DateTime dates, decimal costPerPerson, decimal costOfEvent)
        {
            TypeOfEvent = typeOfEvent;
            NumberOfPeople = numberOfPeople;
            Dates = dates;
            CostPerPerson = costPerPerson;
            CostOfEvent = costOfEvent;
        }

    }
    
}
