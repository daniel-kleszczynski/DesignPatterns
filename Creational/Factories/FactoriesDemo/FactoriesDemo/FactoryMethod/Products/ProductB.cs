using System;

namespace FactoriesDemo.FactoryMethod.Products
{
    public class ProductB : IProduct
    {
        public void DoWork()
        {
            Console.WriteLine($"In {nameof(ProductB)}.{nameof(DoWork)}()");
        }
    }
}
