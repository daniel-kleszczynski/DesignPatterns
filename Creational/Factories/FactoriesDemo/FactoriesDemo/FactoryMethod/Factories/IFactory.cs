using FactoriesDemo.FactoryMethod.Products;

namespace FactoriesDemo.FactoryMethod.Factories
{
    public interface IFactory
    {
        IProduct Create();
    }
}
