using System;
using System.Configuration;
using System.Linq;
using System.Reflection;
using FactoriesDemo.FactoryMethod.Factories;
using FactoryAbstract = FactoriesDemo.AbstractFactory.Factories;

namespace FactoriesDemo
{
    public class Bootstrapper
    {
        private readonly Type[] allTypes;

        public Bootstrapper()
        {
            var assembly = Assembly.GetExecutingAssembly();
            allTypes = assembly.GetTypes();
        }

        public IFactory GetFactory()
        {
            const string TYPE_KEY = "factoryMethod";
            var factory = (IFactory)CreateFactory(TYPE_KEY);

            if (factory == null)
                Console.WriteLine($"No key \"{TYPE_KEY}\" in configuration file.");

            return factory;
        }

        public FactoryAbstract.IFactory GetAbstractFactory()
        {
            const string TYPE_KEY = "abstractFactory";
            var factory = (FactoryAbstract.IFactory)CreateFactory(TYPE_KEY);

            if (factory == null)
                Console.WriteLine($"No key \"{TYPE_KEY}\" in configuration file.");

            return factory;
        }

        private object CreateFactory(string typeKey)
        {
            var factoryType = ConfigurationManager.AppSettings[typeKey];
            var type = allTypes.FirstOrDefault(t => t.FullName.Equals(factoryType));
            return type != null ? Activator.CreateInstance(type) : null;
        }
    }
}
