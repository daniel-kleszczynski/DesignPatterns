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
            chain?.Handle(businessData);
            Console.ReadKey();
        }
    }
}
