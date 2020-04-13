using System;

namespace PrototypeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            double userNumber;

            Console.Write("Type a number: ");

            if (!double.TryParse(Console.ReadLine(), out userNumber))
            {
                Console.WriteLine("You need to supply a number.");
                return;
            }

            var bootstrapper = new Bootstrapper();
            var client = bootstrapper.GetClient();
            client?.PrototypeDemo(userNumber);

            Console.ReadKey();
        }
    }
}
