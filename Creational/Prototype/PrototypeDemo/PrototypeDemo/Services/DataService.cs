using PrototypeDemo.Models;
using System.Threading;

namespace PrototypeDemo.Services
{
    public interface IDataService
    {
        ProcessingModule LoadModule();
        DataPackage LoadPackage();
    }

    public class DataService : IDataService
    {
        public ProcessingModule LoadModule()
        {
            Thread.Sleep(1500);
            return new ProcessingModule { A = 14.24, B = 7 };
        }

        public DataPackage LoadPackage()
        {
            Thread.Sleep(1500);
            return new DataPackage { C = 5, D = 3.14 };
        }
    }
}
