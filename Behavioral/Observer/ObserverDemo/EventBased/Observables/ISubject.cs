using System;

namespace ObserverDemo.EventBased.Observables
{
    public interface ISubject : IDisposable
    {
        int Number { get; }
        string Name { get; set; }

        event EventHandler<CustomEventArgs> NumberChanged;
        event EventHandler<CustomEventArgs> NameChanged;

        void ChangeFirst();
    }
}
