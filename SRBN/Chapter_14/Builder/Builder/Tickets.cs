using System;

namespace Builder {
    class Tickets : AEvent {
        public int Count { get; }

        public Tickets(DateTime startTime, TimeSpan duration, string name, string place, int count) : base(startTime, duration, name, place) {
            Count = count;
        }
    }
}
