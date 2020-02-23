using SingletonDemo.Implementations;
using System;

namespace SingletonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonA.Instance.DoWork();
            SingletonB.Instance.DoWork();
            SingletonC.Instance.DoWork();
            SingletonD.Instance.DoWork();

            Console.ReadKey();
        }
    }
}
