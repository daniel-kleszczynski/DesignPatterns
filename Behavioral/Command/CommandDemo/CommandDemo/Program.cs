using CommandDemo.Invokers;
using CommandDemo.Receivers;
using System;

namespace CommandDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IReceiver receiver = new Receiver();
            var invoker = new Invoker(receiver);

            invoker.SetupCommands();

            Console.WriteLine("\nBefore execute: {0}", receiver.CurrentValue);
            invoker.ExecuteAll();
            Console.WriteLine("\nAfter execute: {0}", receiver.CurrentValue);
            invoker.UndoAll();
            Console.WriteLine("\nAfter undo: {0}", receiver.CurrentValue);

            Console.ReadKey();
        }
    }
}