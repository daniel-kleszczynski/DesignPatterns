using ChainOfResponsibilityDemo.Models;
using System;

namespace ChainOfResponsibilityDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var businessData = new BusinessData(isA: false, isB: true, isC: true);
            var builder = new ChainBuilder();
            var chain = builder.Build();

            if (chain != null)
            {
                var response = chain.Process(businessData);
                DisplayResult(response);
            }
            else
                Console.WriteLine("Chain has not been created.");

            Console.ReadKey();
        }

        private static void DisplayResult(ResponseStatus status)
        {
            switch (status)
            {
                case ResponseStatus.Processed:
                    Console.WriteLine("The request has been handled correctly.");
                    break;
                case ResponseStatus.Unhandled:
                    Console.WriteLine($"Unhandled request - End of chain has been reached.");
                    break;
                case ResponseStatus.NullData:
                    Console.WriteLine("Input data was null");
                    break;
            }
        }
    }
}
