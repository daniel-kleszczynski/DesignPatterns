﻿using System;

namespace SingletonDemo.Implementations
{
    public sealed class SingletonA
    {     
        private static SingletonA instance;

        private SingletonA() { }

        public static SingletonA Instance
        {
            get
            {
                //Not thread-safe
                if (instance == null)
                    instance = new SingletonA();

                return instance;
            }
        }
        
        public void DoWork()
        {
            Console.WriteLine($"In {nameof(SingletonA)} {nameof(DoWork)}()");
        }
    }
}
