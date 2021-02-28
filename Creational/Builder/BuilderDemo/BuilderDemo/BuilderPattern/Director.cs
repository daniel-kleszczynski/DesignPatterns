using System;
using System.Configuration;

namespace BuilderDemo.BuilderPattern
{
    public interface IDirector
    {
        void Construct(IBuilder builder);
    }
    public class Director : IDirector
    {
        public void Construct(IBuilder builder)
        {
            IBuilderConstruction builderConstruction = (IBuilderConstruction)builder;

            builderConstruction.ConstructModuleX();

            if (!builderConstruction.IsInLimitedMode)
            {
                string clientId = ConfigurationManager.AppSettings["clientId"] ?? throw new ArgumentNullException("clientId is not defined in config file");
                string clientSecret = ConfigurationManager.AppSettings["clientSecret"] ?? throw new ArgumentNullException("clientSecret is not defined in config file");

                string accessToken = builderConstruction.ModuleX.GetAccessToken(clientId, clientSecret);
                builderConstruction.ConstructModuleY(accessToken);
            }

            builderConstruction.ConstructComplexModule();
        }
    }
}
