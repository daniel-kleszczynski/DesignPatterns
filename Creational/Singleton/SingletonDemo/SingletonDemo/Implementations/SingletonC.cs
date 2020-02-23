using System;

namespace SingletonDemo
{
    public sealed class SingletonC
    {
        private SingletonC() { }

        //Static initialization ensures only one instance will be created (despite multi=threading)
        public static SingletonC Instance { get; } = new SingletonC();

        public void DoWork()
        {
            Console.WriteLine($"In {nameof(SingletonC)} {nameof(DoWork)}()");
        }
    }
}
