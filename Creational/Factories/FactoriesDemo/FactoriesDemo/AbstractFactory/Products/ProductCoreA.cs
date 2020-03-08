using System;

namespace FactoriesDemo.AbstractFactory.Products
{
    public class ProductCoreA : IProductCore
    {
        public void Run()
        {
            Console.WriteLine($"In {nameof(ProductCoreA)}.{nameof(Run)}()");
        }
    }
}
