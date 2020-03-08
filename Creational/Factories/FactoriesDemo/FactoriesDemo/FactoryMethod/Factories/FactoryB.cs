using FactoriesDemo.FactoryMethod.Products;

namespace FactoriesDemo.FactoryMethod.Factories
{
    public class FactoryB : IFactory
    {
        public IProduct Create()
        {
            return new ProductB();
        }
    }
}
