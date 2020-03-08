using System;

namespace FactoriesDemo.AbstractFactory.Products
{
    public class ProductSpecialA : IProductSpecial
    {
        public void Launch(string text)
        {
            Console.WriteLine($"In {nameof(ProductSpecialA)}.{nameof(Launch)}({text})");

        }
    }
}
