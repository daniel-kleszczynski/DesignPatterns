using System;

namespace FactoriesDemo.AbstractFactory.Products
{
    public class ProductSpecialB : IProductSpecial
    {
        public void Launch(string text)
        {
            Console.WriteLine($"In {nameof(ProductSpecialB)}.{nameof(Launch)}({text})");

        }
    }
}
