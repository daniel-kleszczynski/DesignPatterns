using System;

namespace SingletonDemo.Implementations
{
    public sealed class SingletonB
    {
        private static SingletonB instance;
        private static object padlock = new object();

        private SingletonB() { }

        public static SingletonB Instance
        {
            get
            {
                // thread-safe, performance issue - on every call padlock is acquired
                lock (padlock)
                {
                    if (instance == null)
                        instance = new SingletonB();
                }

                return instance;
            }
        }

        public void DoWork()
        {
            Console.WriteLine($"In {nameof(SingletonB)} {nameof(DoWork)}()");
        }
    }
}
