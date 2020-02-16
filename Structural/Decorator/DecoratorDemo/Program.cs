using DecoratorDemo.Core;
using DecoratorDemo.Decorators;
using System;
using ThirdPartyLibrary;

namespace DecoratorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var component = GetComponent();
            var client = new Client(component);
            client.SomeBusinessLogic();

            Console.ReadKey();
        }

        private static IComponent GetComponent()
        {
            IComponent component = new Component();
            component = new DecoratorA(component);
            component = new DecoratorB(component);
            return component;
        }
    }
}
