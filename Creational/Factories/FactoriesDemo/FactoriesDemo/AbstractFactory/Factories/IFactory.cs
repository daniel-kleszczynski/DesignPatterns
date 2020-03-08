using FactoriesDemo.AbstractFactory.Products;

namespace FactoriesDemo.AbstractFactory.Factories
{
    public interface IFactory
    {
        IProductCore CreateCore();
        IProductSpecial CreateSpecial();
    }
}
