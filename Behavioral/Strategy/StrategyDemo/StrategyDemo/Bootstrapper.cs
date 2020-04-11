using StrategyDemo.Strategies;
using System;
using System.Configuration;
using System.Linq;
using System.Reflection;

namespace StrategyDemo
{
    public class Bootstrapper
    {
        private readonly Type[] types;

        public Bootstrapper()
        {
            var assembly = Assembly.GetExecutingAssembly();
            types = assembly.GetTypes()
                .Where(t => t.Name.EndsWith("Sorter") && !t.Name.Equals("ISorter"))
                .ToArray();
        }

        public AbstractSorter GetSorter()
        {
            var sorterName = ConfigurationManager.AppSettings["chosenSorter"];

            if (string.IsNullOrEmpty(sorterName))
                return null;

            var sorter = types.FirstOrDefault((t => t.FullName.Equals(sorterName)));

            if (sorter != null)
                return (AbstractSorter)Activator.CreateInstance(sorter);

            return null;
        }
    }
}
