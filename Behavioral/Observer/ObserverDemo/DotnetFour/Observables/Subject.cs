using ObserverDemo.DotnetFour.Models;
using ObserverDemo.DotnetFour.Observers;
using System;
using System.Collections.Generic;

namespace ObserverDemo.DotnetFour.Observables
{
    public class Subject : IObservable<Package>
    {
        private Random random = new Random(DateTime.Now.Millisecond);
        private List<AbstractObserver> observers = new List<AbstractObserver>();
        public IDisposable Subscribe(IObserver<Package> observer)
        {
            var newObserver = (AbstractObserver)observer;

            if (observer != null && !observers.Contains(newObserver))
                observers.Add(newObserver);

            return new Unsubscriber(observers, newObserver);
        }

        public void PushPackage()
        {
            const int MIN = 0;
            const int MAX = 20;

            var quantity = random.Next(MIN, MAX + 1);
            var package = new Package { Category = (Category)(quantity % 2), Quantity = quantity };

            foreach (var observer in observers)
            {
                if (observer.Category != package.Category)
                    continue;

                if (quantity > 0)
                    observer.OnNext(package);
                else
                    observer.OnError(new EmptyPackageException());
            }
        }

        private class Unsubscriber : IDisposable
        {
            private List<AbstractObserver> observers;
            private AbstractObserver observer;

            public Unsubscriber(List<AbstractObserver> observers, AbstractObserver observer)
            {
                this.observers = observers;
                this.observer = observer;
            }

            public void Dispose()
            {
                if (observer != null && observers.Contains(observer))
                {
                    observer.OnCompleted();
                    observers.Remove(observer);
                }
            }
        }
    }
}
