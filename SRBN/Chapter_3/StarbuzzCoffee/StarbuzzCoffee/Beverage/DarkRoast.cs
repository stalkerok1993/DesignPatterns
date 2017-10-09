namespace StarbuzzCoffee.Beverage
{
    class DarkRoast : AbstractBeverage
    {
        public override int Cost { get; } = 99;

        public override string Description { get; } = "Dark Roast Coffee";
    }
}
