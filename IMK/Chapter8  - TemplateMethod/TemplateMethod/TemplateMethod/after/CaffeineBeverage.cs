using System;

namespace TemplateMethod.after {
    public abstract class CaffeineBeverage {
        public void PrepareRecipe() {
            BoilWater();
            Brew();
            PourInCup();
            if (HookDoYouWantCondiments()) {
                AddCondimends();
            }
        }

        protected abstract void Brew();
        protected abstract void AddCondimends();
        protected void BoilWater() {
            Console.WriteLine("Boiling water");
        }
        protected void PourInCup() {
            Console.WriteLine("Pouring into cup");
        }

        protected virtual bool HookDoYouWantCondiments() {
            return true;
        }
    }
}
