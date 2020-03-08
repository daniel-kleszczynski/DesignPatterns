using System;

namespace FactoriesDemo.AbstractFactory.Products
{
    public class ProductCoreB : IProductCore
    {
        public void Run()
        {
            Console.WriteLine($"In {nameof(ProductCoreB)}.{nameof(Run)}()");
        }
    }
}
