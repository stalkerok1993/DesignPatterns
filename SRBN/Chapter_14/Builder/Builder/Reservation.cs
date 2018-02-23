using System;

namespace Builder {
    class Reservation : AEvent {
        public Reservation(DateTime startTime, TimeSpan duration, string name, string place) : base(startTime, duration, name, place) { }
    }
}
