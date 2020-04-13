using PrototypeDemo.Services;

namespace PrototypeDemo
{
    public class Bootstrapper
    {
        public Client GetClient()
        {
            var dataService = new DataService();
            return new Client(dataService);
        }
    }
}
