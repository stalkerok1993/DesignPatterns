namespace StarbuzzCoffee.Beverage.Condiment
{
    class Whip : CondimentDecorator
    {
        public Whip(AbstractBeverage decorated) : base(decorated) { }

        public override int Cost
        {
            get
            {
                return 10 + decorated.Cost;
            }
        }

        public override string Description
        {
            get
            {
                return decorated.Description + ", Whip";
            }
        }
    }
}
