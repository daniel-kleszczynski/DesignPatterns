using System;
using ThirdPartyLibrary;

namespace DecoratorDemo.Core
{
    public class Client
    {
        private IComponent component;

        public Client(IComponent component)
        {
            this.component = component;
        }

        public void SomeBusinessLogic()
        {
            var result = component.GetValue();
            Console.WriteLine($"Final result: {result}");
        }
    }
}
