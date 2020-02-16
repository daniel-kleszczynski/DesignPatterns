using System;
using ThirdPartyLibrary;

namespace DecoratorDemo.Decorators
{
    public class DecoratorA : IDecorator
    {
        private IComponent component;

        public DecoratorA(IComponent component)
        {
            this.component = component;
        }

        public int GetValue()
        {
            const int EXTRA_VALUE = 4;
            int computedValue = -1;
            string log = $"In {nameof(DecoratorA)} ";

            if (component != null)
            {
                computedValue = component.GetValue() + EXTRA_VALUE;
                log += $"+ {EXTRA_VALUE}";
            }
            else
                log += "Component is NULL";

            Console.WriteLine(log);
            return computedValue;
        }
    }
}
