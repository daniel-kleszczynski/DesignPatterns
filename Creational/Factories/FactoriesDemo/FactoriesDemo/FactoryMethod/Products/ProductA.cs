using System;

namespace FactoriesDemo.FactoryMethod.Products
{
    public class ProductA : IProduct
    {
        public void DoWork()
        {
            Console.WriteLine($"In {nameof(ProductA)}.{nameof(DoWork)}()");
        }
    }
}
