using System;

namespace SingletonDemo.Implementations
{
    public sealed class SingletonD
    {
        private static readonly Lazy<SingletonD> instance = 
            new Lazy<SingletonD>(() => {return  new SingletonD(); });

        private SingletonD() { }

        public static SingletonD Instance => instance.Value;

        public void DoWork()
        {
            Console.WriteLine($"In {nameof(SingletonD)} {nameof(DoWork)}()");
        }
    }
}
