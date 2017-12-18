using System;

namespace TemplateMethod.before2 {
    public class Tea : CaffeineBeverage {
        public override void PrepareRecipe() {
            BoilWater();
            SteepTeaBag();
            PourInCup();
            AddLemon();
        }

        private void SteepTeaBag() {
            Console.WriteLine("Steeping the tea");
        }

        private void AddLemon() {
            Console.WriteLine("Adding lemon");
        }
    }
}
