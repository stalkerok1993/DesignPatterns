namespace StarbuzzCoffee.Beverage
{
    abstract class AbstractBeverage
    {
        /// <summary>
        /// Cost in cents.
        /// </summary>
        public abstract int Cost { get; }

        public virtual string Description { get; } = "Unknown";

        public virtual BeverageSize Size { get; } = BeverageSize.GRANDE;
    }
}
