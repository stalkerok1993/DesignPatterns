using System;

namespace BuilderImplementation {
    interface IBuilder {
        IBuilder SetName(string name);
        IBuilder SetEmail(string email);
        IBuilder AddReservation(DateTime startTime, TimeSpan duration, string place, string firstName);
        IBuilder AddTickets(DateTime startTime, TimeSpan duration, string name, string place, int count);

        APlanner BuildPlanner();
    }
}
