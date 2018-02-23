using System.Collections.Generic;

namespace BuilderImplementation {
    class APlanner {
        public string Name { get; }
        public IList<AEvent> Events { get; } = new List<AEvent>();

        public APlanner(string name) {
            Name = name;
        }
    }
}
