using ChainOfResponsibilityDemo.Handlers;
using System;
using System.Configuration;
using System.Linq;
using System.Reflection;

namespace ChainOfResponsibilityDemo
{
    public class ChainBuilder
    {
        private IHandler firstLink = null;
        private IHandler currentLink = null;

        public IHandler Build()
        {
            var linkTypes = GetLinkTypesFromConfig();
            var assembly = Assembly.GetExecutingAssembly();
            var types = assembly.GetTypes();

            foreach (var linkType in linkTypes)
            {
                var typeName = linkType.Trim();
                var type = types.FirstOrDefault(t => t.Name.Equals(typeName));

                if (type == null)
                    return null;

                if (TryAddFirstLink(type))
                    continue;

                AddNextLink(type);
            }

            currentLink.SetNext(EndOfChainHandler.Instance);
            return firstLink;
        }

        private string[] GetLinkTypesFromConfig()
        {
            var chainOrder = ConfigurationManager.AppSettings["chainOrder"];
            var parts = chainOrder?.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            if (parts == null)
                return new string[] { };

            return parts;
        }

        private bool TryAddFirstLink(Type type)
        {
            if (firstLink == null)
            {
                firstLink = (IHandler)Activator.CreateInstance(type);
                currentLink = firstLink;
                return true;
            }

            return false;
        }

        private void AddNextLink(Type type)
        {
            var nextLink = (IHandler)Activator.CreateInstance(type);
            currentLink.SetNext(nextLink);
            currentLink = nextLink;
        }
    }
}
