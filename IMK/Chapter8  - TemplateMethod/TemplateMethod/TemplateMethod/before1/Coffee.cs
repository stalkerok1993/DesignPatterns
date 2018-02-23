using System;

namespace TemplateMethod.before1{
    public class Coffee {

        public void PrepareRecipe() {
            BoilWater();
            BrewCoffeeGrinds();
            PourInCup();
            AddSugarAndMilk();
        }
        private void BoilWater() {
            Console.WriteLine("Boiling water");
        }

        private void BrewCoffeeGrinds() {
            Console.WriteLine("Brew coffee grinds");
        }

        private void PourInCup() {
            Console.WriteLine("Pouring into cup");
        }

        private void AddSugarAndMilk() {
            Console.WriteLine("Adding sugar and milk");
        }
    }
}
