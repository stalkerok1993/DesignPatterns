using System;
using System.Threading;

namespace SimpleSingletone
{
    public sealed class ChocolateBoiler
    {
        public bool IsEmpty { get; private set; }
        public bool IsBoiled { get; private set; }

        private static readonly Lazy<ChocolateBoiler> lazyCreatedInstance = new Lazy<ChocolateBoiler>(() => new ChocolateBoiler());

        private ChocolateBoiler()
        {
            IsEmpty = true;
            IsBoiled = false;
        }

        public static ChocolateBoiler Instance
        {
            get
            {
                return lazyCreatedInstance.Value;
            }
        }

        public void Fill()
        {
            if (IsEmpty)
            {
                IsEmpty = false;
            }
        }

        public void Boil()
        {
            if (!IsEmpty && !IsBoiled)
            {
                IsBoiled = true;
            }
        }

        public void Drain()
        {
            if (!IsEmpty && IsBoiled)
            {
                IsEmpty = true;
                IsBoiled = false;
            }
        }
    }
}
