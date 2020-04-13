using System;

namespace PrototypeDemo.Models
{
    public class ProcessingModule : ICloneable
    {
        public double A { get; set; }
        public int B { get; set; }
        public double CurrentValue { get; set; }

        public void OperationA(double userNumber, DataPackage dataPackage)
        {
            CurrentValue = ((dataPackage.C * A) - (B + userNumber)) / dataPackage.D;
        }

        public void OparationB(double userNumber, DataPackage package)
        {
            CurrentValue = ((package.D * B) - (package.C - A)) / userNumber;
        }


        public object Clone()
        {
            //Return a shallow copy
            return MemberwiseClone();
        }
    }
}
