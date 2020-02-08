using AdapterDemo.Adapters;
using ThirdPartyLibrary;

namespace AdapterDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //var client = GetClientObsolete();
            var client = GetClient();

            client.BusinessLogic();
            client.AnotherBusinessLogic();
        }

        private static Client GetClientObsolete()
        {
           var serviceObsolete = new WeightServiceObsolete();
           var adapterObsolete = new WeightServiceAdapterObsolete(serviceObsolete);
           return new Client(adapterObsolete);

        }

        private static Client GetClient()
        {
            var service = new WeightService();
            var adapter = new WeightServiceAdapter(service);
            return  new Client(adapter);
        }
    }
}
