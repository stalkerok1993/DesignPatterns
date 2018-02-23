using System;
using System.Collections.Generic;

namespace BuilderImplementation {
    class Builder : IBuilder {
        private string firstName;
        private string email;
        private IList<AEvent> events = new List<AEvent>();

        public IBuilder SetName(string firstName) {
            this.firstName = firstName;

            return this;
        }

        public IBuilder SetEmail(string email) {
            this.email = email;

            return this;
        }

        public IBuilder AddReservation(DateTime startTime, TimeSpan duration, string name, string place) {
            events.Add(new Reservation(startTime, duration, name, place, firstName));

            return this;
        }

        public IBuilder AddTickets(DateTime startTime, TimeSpan duration, string name, string place, int count) {
            events.Add(new Tickets(startTime, duration, name, place, count));

            return this;
        }

        public APlanner BuildPlanner() {
            if (firstName == null) {
                throw new InvalidProgramException("Incorrect initialization: empty first name");
            }

            var planner = new Planner(firstName, email);
            foreach (AEvent e in events) {
                planner.Events.Add(e);
            }

            return planner;
        }
    }
}
