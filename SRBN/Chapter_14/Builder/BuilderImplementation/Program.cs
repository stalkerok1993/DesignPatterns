using System;
using System.Collections.Generic;
using System.Linq;

namespace BuilderImplementation {
    class Program {
        static void Main(string[] args) {
            APlanner planner = new Builder()
                    .SetName("Serhii")
                    .AddReservation(new DateTime(2018, 02, 23, 14, 00, 00), new TimeSpan(46, 0, 0), "Hotel reservation", "RandomHotel")
                    .AddReservation(new DateTime(2018, 02, 23, 19, 00, 00), new TimeSpan(2, 0, 0), "Evening dinner", "RandomRestaurant")
                    .AddTickets(new DateTime(2018, 02, 24, 18, 00, 00), new TimeSpan(2, 0, 0), "Evening cinema", "RandomCinema", 2)
                    .BuildPlanner();

            PrintPlannerEvents(planner);

            Console.ReadKey();
        }

        static void PrintPlannerEvents(APlanner planner) {
            Console.WriteLine($"{planner.Name}:");

            IEnumerable<AEvent> sortedEvents = planner.Events.OrderBy<AEvent, DateTime>((e) => e.StartTime);
            foreach (AEvent e in sortedEvents) {
                Console.WriteLine($"  {e.Name}: {e.StartTime} - {e.StartTime.Add(e.Duration)}");
            }
        }
    }
}
