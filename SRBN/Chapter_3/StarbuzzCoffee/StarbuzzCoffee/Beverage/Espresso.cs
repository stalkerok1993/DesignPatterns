namespace StarbuzzCoffee.Beverage
{
    class Espresso : AbstractBeverage
    {
        public override int Cost { get; } = 199;

        public override string Description { get; } = "Espresso Coffee";
    }
}
