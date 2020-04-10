using System;

namespace ObserverDemo.EventBased.Observables
{
    public class CustomEventArgs : EventArgs
    {
        public string Author { get; set; }
        public DateTime EventTime { get; set; }
    }
}
