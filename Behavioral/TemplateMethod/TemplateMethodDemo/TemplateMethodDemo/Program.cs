using System;
using TemplateMethodDemo.Modules;

namespace TemplateMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var modules = new AbstractModule[] { new ModuleA(), new ModuleB() };

            foreach (var module in modules)
                module.TemplateMethod();

            Console.ReadKey();
        }
    }
}
