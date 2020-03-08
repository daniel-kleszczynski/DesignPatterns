using FactoriesDemo.AbstractFactory.Products;

namespace FactoriesDemo.AbstractFactory.Factories
{
    public class FactoryB : IFactory
    {
        public IProductCore CreateCore()
        {
            return new ProductCoreB();
        }

        public IProductSpecial CreateSpecial()
        {
            return new ProductSpecialB();
        }
    }
}
