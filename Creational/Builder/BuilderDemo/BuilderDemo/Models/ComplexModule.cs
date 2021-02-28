using System;

namespace BuilderDemo.Models
{
    public interface IComplexModule
    {
        void LogSettings();
    }

    public class ComplexModule : IComplexModule
    {
        private readonly int _categoryId;
        private readonly bool _isInLimitedMode;
        private readonly double _factor;
        private readonly decimal _initialPrice;
        private readonly ModuleX _moduleX;
        private readonly ModuleY _moduleY;

        public ComplexModule(int categoryId, bool isInLimitedMode, double factor, decimal initialPrice, ModuleX moduleX, ModuleY moduleY)
        {
            _categoryId = categoryId;
            _isInLimitedMode = isInLimitedMode;
            _factor = factor;
            _initialPrice = initialPrice;
            _moduleX = moduleX;
            _moduleY = moduleY;
        }

        public void LogSettings()
        {
            Console.WriteLine($@"Configuration settings:
            categoryId : {_categoryId}
            limitedMode : {_isInLimitedMode}
            factor : {_factor}
            initial price : {_initialPrice}
            {_moduleX}
            {_moduleY}");
        }


    }
}
