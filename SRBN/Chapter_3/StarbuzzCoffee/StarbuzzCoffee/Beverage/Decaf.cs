namespace StarbuzzCoffee.Beverage
{
    class Decaf : AbstractBeverage
    {
        public override int Cost { get; } = 105;

        public override string Description { get; } = "Decaf Coffee";
    }
}
