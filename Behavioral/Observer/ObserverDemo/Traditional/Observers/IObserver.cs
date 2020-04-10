using System;

namespace ObserverDemo.Traditional.Observers
{
    public interface IObserver : IDisposable
    {
        void Update();
    }
}
