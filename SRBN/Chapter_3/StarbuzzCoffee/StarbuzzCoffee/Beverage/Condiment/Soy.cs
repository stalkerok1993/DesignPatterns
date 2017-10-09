namespace StarbuzzCoffee.Beverage.Condiment
{
    class Soy : CondimentDecorator
    {
        public Soy(AbstractBeverage decorated) : base(decorated) { }

        public override int Cost
        {
            get
            {
                int cost;
                switch (decorated.Size)
                {
                    case BeverageSize.TALL:
                        cost = 10;
                        break;
                    case BeverageSize.GRANDE:
                        cost = 15;
                        break;
                    case BeverageSize.VENT:
                    default:
                        cost = 20;
                        break;
                }

                return cost + decorated.Cost;
            }
        }

        public override string Description
        {
            get
            {
                return decorated.Description + ", Soy";
            }
        }
    }
}
