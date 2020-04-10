using ObserverDemo.Traditional.Observers;
using System;
using System.Collections.Generic;

namespace ObserverDemo.Traditional.Observables
{
    public abstract class AbstractSubject : IDisposable
    {
        private int state;
        private readonly List<IObserver> observers = new List<IObserver>();

        public int State
        {
            get => state;
            protected set
            {
                state = value;
                Notify();
            }
        }

        public abstract void ChangeState();

        public void Dispose()
        {
            observers.Clear();
        }

        public void Register(IObserver observer)
        {
            observers.Add(observer);
        }
        public void Unregister(IObserver observer)
        {
            observers.Remove(observer);
        }

        protected void Notify()
        {
            foreach (var observer in observers)
                observer.Update();
        }
    }
}
