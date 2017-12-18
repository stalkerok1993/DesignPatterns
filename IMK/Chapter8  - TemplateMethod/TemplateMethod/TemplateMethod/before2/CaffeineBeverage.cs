using System;

namespace TemplateMethod.before2 {
    public abstract class CaffeineBeverage {
        public abstract void PrepareRecipe();

        protected void BoilWater() {
            Console.WriteLine("Boiling water");
        }
        protected void PourInCup() {
            Console.WriteLine("Pouring into cup");
        }
    }
}
