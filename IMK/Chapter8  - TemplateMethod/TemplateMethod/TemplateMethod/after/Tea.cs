using System;

namespace TemplateMethod.after {
    public class Tea : CaffeineBeverage {
        protected override void Brew() {
            Console.WriteLine("Steeping the tea");
        }
        protected override void AddCondimends() {
            Console.WriteLine("Adding lemon");
        }
    }
}
