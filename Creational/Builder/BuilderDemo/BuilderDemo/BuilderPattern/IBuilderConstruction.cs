
namespace BuilderDemo.BuilderPattern
{
    public interface IBuilderConstruction : IBuilder
    {
        void ConstructModuleX();
        void ConstructModuleY(string accessToken);
        void ConstructComplexModule();
    }
}
