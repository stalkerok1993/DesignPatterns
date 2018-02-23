using System;

namespace BuilderImplementation {
    class Reservation : AEvent {
        public string FirstName { get; }

        public Reservation(DateTime startTime, TimeSpan duration, string name, string place, string firstName) : base(startTime, duration, name, place) {
            FirstName = firstName;
        }
    }
}
