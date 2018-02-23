using System.Collections.Generic;

namespace Builder {
    class Planner {
        public string Name { get; }
        public IList<AEvent> Events { get; } = new List<AEvent>();

        public Planner(string name) {
            Name = name;
        }
    }
}
