using System;
using ThirdPartyLibrary;

namespace DecoratorDemo.Decorators
{
    public class DecoratorB : IDecorator
    {
        private IComponent component;

        public DecoratorB(IComponent component)
        {
            this.component = component;
        }

        public int GetValue()
        {
            const int EXTRA_VALUE = 7;
            int computedValue = -1;
            string log = $"In {nameof(DecoratorB)} ";

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
