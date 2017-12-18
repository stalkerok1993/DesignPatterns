
using System;

namespace TemplateMethodDucks {
    public class Duck : IComparable {

        public string Name { get; }
        public int Weight { get; }

        public Duck(string name, int weight) {
            Name = name;
            Weight = weight;
        }

        public int CompareTo(object obj) {
            var otherDuck = (Duck)obj;
            if (Weight < otherDuck.Weight) {
                return -1;
            }
            if (Weight == otherDuck.Weight) {
                return 0;
            }
            return 1;
        }
    }
}
