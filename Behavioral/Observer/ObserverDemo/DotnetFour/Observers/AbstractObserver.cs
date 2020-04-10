using ObserverDemo.DotnetFour.Models;
using System;

namespace ObserverDemo.DotnetFour.Observers
{
    public abstract class AbstractObserver : IObserver<Package>
    {
        public Category Category { get; }

        public AbstractObserver(Category category)
        {
            Category = category;
        }

        public abstract void OnCompleted();
        public abstract void OnError(Exception error);
        public abstract void OnNext(Package value);
    }
}
