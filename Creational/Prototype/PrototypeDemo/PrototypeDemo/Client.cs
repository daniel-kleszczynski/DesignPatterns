using PrototypeDemo.Models;
using PrototypeDemo.Services;
using System;

namespace PrototypeDemo
{
    public class Client
    {
        private readonly IDataService dataService;

        public Client(IDataService dataService)
        {
            if (dataService == null)
                throw new ArgumentNullException(nameof(dataService));

            this.dataService = dataService;
        }

        public void PrototypeDemo(double userNumber)
        {
            var prototype = new ConcretePrototype(dataService, userNumber);
            prototype.InitializeFromExternalService();

            prototype.OperationA();
            Console.WriteLine("Prototype value before: {0}", string.Format("{0:0.00}", prototype.CurrentValue));

            var clone = prototype.Clone();
            clone.OperationB();

            Console.WriteLine("Prototype value after: {0}", string.Format("{0:0.00}", prototype.CurrentValue));
            Console.WriteLine("Clone value: {0}", string.Format("{0:0.00}", clone.CurrentValue));
        }
    }
}
