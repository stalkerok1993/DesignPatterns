namespace StarbuzzCoffee.Beverage.Condiment
{
    abstract class CondimentDecorator : AbstractBeverage
    {
        protected AbstractBeverage decorated;

        protected CondimentDecorator(AbstractBeverage decorated)
        {
            this.decorated = decorated;
        }

        public override BeverageSize Size
        {
            get
            {
                return decorated.Size;
            }
        }
    }
}
