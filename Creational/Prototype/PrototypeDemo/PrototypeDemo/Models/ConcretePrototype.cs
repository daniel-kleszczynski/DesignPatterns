using PrototypeDemo.Services;
using System;

namespace PrototypeDemo.Models
{
    public class ConcretePrototype : ICloneable<ConcretePrototype>
    {
        private readonly IDataService dataService;
        private readonly double userNumber;
        private ProcessingModule module;
        private DataPackage package;

        public ConcretePrototype(IDataService dataService, double userNumber)
        {
            this.dataService = dataService;
            this.userNumber = userNumber;
        }

        public ConcretePrototype(IDataService dataService, double userNumber, ProcessingModule module, DataPackage package)
        {
            this.dataService = dataService;
            this.module = module;
            this.userNumber = userNumber;
            this.package = package;
        }

        public double CurrentValue => module.CurrentValue;

        //Return a deep copy
        public ConcretePrototype Clone()
        {
            var processModule = (ProcessingModule)module.Clone();
            return new ConcretePrototype(dataService, userNumber, processModule, package);
        }

        /// <summary>
        /// Slow initialization using external source
        /// </summary>
        public void InitializeFromExternalService()
        {
            Console.WriteLine("External service is loading ...");
            module = dataService.LoadModule();
            package = dataService.LoadPackage();
        }

        public void OperationA()
        {
            module.OperationA(userNumber, package);
        }

        public void OperationB()
        {
            module.OparationB(userNumber, package);
        }
    }
}
