using System;
using FactoriesDemo.FactoryMethod.Factories;
using FactoryAbstract = FactoriesDemo.AbstractFactory.Factories;

namespace FactoriesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var bootstrapper = new Bootstrapper();
            FactoryMethodDemo(bootstrapper);
            AbstractFactoryDemo(bootstrapper);
            Console.ReadKey();
        }

        private static void FactoryMethodDemo(Bootstrapper bootstrapper)
        {
            IFactory factory = bootstrapper?.GetFactory();
            var product = factory?.Create();
            product?.DoWork();
        }

        private static void AbstractFactoryDemo(Bootstrapper bootstrapper)
        {
            FactoryAbstract.IFactory factory = bootstrapper?.GetAbstractFactory();
            var productCore = factory?.CreateCore();
            var productSpecial = factory?.CreateSpecial();
            productCore?.Run();

            const string TEXT = "Test";
            productSpecial?.Launch(TEXT);
        }
    }
}
