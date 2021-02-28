using System;
using BuilderDemo.BuilderPattern;
using BuilderDemo.Models;

namespace BuilderDemo
{
    static class Program
    {
        static void Main(string[] args)
        {
            var bootstrapper = new Bootstrapper();
            IBuilder builder = bootstrapper.GetBuilder();
            IDirector director = bootstrapper.GetDirector();

            ConfigureBuilder(builder);
            director.Construct(builder);

            ComplexModule complexModule = builder.Result;
            complexModule.LogSettings();

            Console.ReadKey();
        }

        private static void ConfigureBuilder(IBuilder builder)
        {
            builder.Factor = 17;
            builder.InitialPrice = 100;
            builder.IsInLimitedMode = false;
            builder.ModuleX_x = 13;
            builder.ModuleX_y = 7;
            builder.ModuleY_name = "rose";
            builder.ModuleY_issueDate = new DateTime(2021, 2, 28);
        }
    }
}
