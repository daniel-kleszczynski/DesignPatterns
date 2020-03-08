using FactoriesDemo.FactoryMethod.Products;

namespace FactoriesDemo.FactoryMethod.Factories
{
    public class FactoryA : IFactory
    {
        public IProduct Create()
        {
            return new ProductA();
        }
    }
}
