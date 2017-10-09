namespace StarbuzzCoffee.Beverage.Condiment
{
    class Mocha : CondimentDecorator
    {
        public Mocha(AbstractBeverage decorated) : base(decorated) { }

        public override int Cost
        {
            get
            {
                return 20 + decorated.Cost;
            }
        }

        public override string Description
        {
            get
            {
                return decorated.Description + ", Mocha";
            }
        }
    }
}
