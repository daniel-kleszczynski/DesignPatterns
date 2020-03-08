using FactoriesDemo.AbstractFactory.Products;

namespace FactoriesDemo.AbstractFactory.Factories
{
    public class FactoryA : IFactory
    {
        public IProductCore CreateCore()
        {
            return new ProductCoreA();
        }

        public IProductSpecial CreateSpecial()
        {
            return new ProductSpecialA();
        }
    }
}
