using AdapterDemo.Adapters;
using System;

namespace AdapterDemo
{
    public class Client
    {
        private IWeightServiceAdapter adapter;

        public Client(IWeightServiceAdapter adapter)
        {
            this.adapter = adapter;
        }

        public void BusinessLogic()
        {
            //This line will not change despite of switching the adapters.
            var weight = adapter.GetWeight();
            Console.WriteLine(weight);
        }

        public void AnotherBusinessLogic()
        {
            //This line will not change despite of switching the adapters.
            var weight = adapter.GetWeight();
            Console.WriteLine(weight);
        }
    }
}
