using System;

namespace BuilderImplementation {
    abstract class AEvent {
        public DateTime StartTime { get; }
        public TimeSpan Duration { get; }
        public string Name { get; }
        public string Place { get; }

        public AEvent(DateTime startTime, TimeSpan duration, string name, string place) {
            StartTime = startTime;
            Duration = duration;
            Name = name;
            Place = place;
        }
    }
}
