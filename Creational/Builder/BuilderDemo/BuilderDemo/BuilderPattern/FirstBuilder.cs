using System;
using BuilderDemo.Models;
using BuilderDemo.Services;

namespace BuilderDemo.BuilderPattern
{
    public class FirstBuilder : IBuilderConstruction
    {
        private readonly IAuthService _authService;
        private readonly IApiService _apiService;
        private readonly int _categoryId = 1;
        private ModuleY _moduleY;

        public FirstBuilder(IAuthService authService, IApiService apiService)
        {
            _authService = authService;
            _apiService = apiService;
        }

        public ComplexModule Result { get; private set; }

        public ModuleX ModuleX { get; private set; }

        public int ModuleX_x { get;  set; }
        public int ModuleX_y { get; set; }

        public string ModuleY_name { get; set; }
        public DateTime ModuleY_issueDate { get; set; }


        public double Factor { get; set; }
        public decimal InitialPrice { get; set; }
        public bool IsInLimitedMode { get; set; }


        public void ConstructModuleX()
        {
            ModuleX = new ModuleX(ModuleX_x, ModuleX_y, _authService);
        }

        public void ConstructModuleY(string accessToken)
        {
            _moduleY = new ModuleY(ModuleY_name, ModuleY_issueDate, _apiService);
        }

        public void ConstructComplexModule()
        {
            Result = new ComplexModule(_categoryId, IsInLimitedMode, Factor, InitialPrice, ModuleX, _moduleY);
        }
    }
}
