using System;
using System.Collections.Generic;
using System.Linq;

namespace Builder {
    class Program {
        static void Main(string[] args) {
            var planner = new Planner("Serhii");

            var hotelReservation = new Reservation(new DateTime(2018, 02, 23, 14, 00, 00), new TimeSpan(46, 0, 0), "Hotel reservation", "RandomHotel");
            var tableReservation = new Reservation(new DateTime(2018, 02, 23, 19, 00, 00), new TimeSpan(2, 0, 0), "Evening dinner", "RandomRestaurant");
            var cinemaTickets = new Tickets(new DateTime(2018, 02, 24, 18, 00, 00), new TimeSpan(2, 0, 0), "Evening cinema", "RandomCinema", 2);

            planner.Events.Add(hotelReservation);
            planner.Events.Add(tableReservation);
            planner.Events.Add(cinemaTickets);

            PrintPlannerEvents(planner);

            Console.ReadKey();
        }

        static void PrintPlannerEvents(Planner planner) {
            Console.WriteLine($"{planner.Name}:");

            IEnumerable<AEvent> sortedEvents = planner.Events.OrderBy<AEvent, DateTime>((e) => e.StartTime);
            foreach (AEvent e in sortedEvents) {
                Console.WriteLine($"  {e.Name}: {e.StartTime} - {e.StartTime.Add(e.Duration)}");
            }
        }
    }
}
