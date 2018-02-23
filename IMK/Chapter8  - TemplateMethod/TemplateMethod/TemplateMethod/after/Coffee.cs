using System;

namespace TemplateMethod.after {
    public class Coffee : CaffeineBeverage {
        protected override void Brew() {
            Console.WriteLine("Brew coffee grinds");
        }
        protected override void AddCondimends() {
            Console.WriteLine("Adding sugar and milk");
        }

        protected override bool HookDoYouWantCondiments() {
            return false;
        }
    }
}
