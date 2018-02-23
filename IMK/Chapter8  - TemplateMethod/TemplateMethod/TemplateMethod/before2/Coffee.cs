using System;

namespace TemplateMethod.before2 {
    public class Coffee : CaffeineBeverage {
        public override void PrepareRecipe() {
            BoilWater();
            BrewCoffeeGrinds();
            PourInCup();
            AddSugarAndMilk();
        }

        private void BrewCoffeeGrinds() {
            Console.WriteLine("Brew coffee grinds");
        }

        private void AddSugarAndMilk() {
            Console.WriteLine("Adding sugar and milk");
        }
    }
}
