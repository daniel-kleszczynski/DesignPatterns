using ObserverDemo.Traditional.Observables;
using System;

namespace ObserverDemo.Traditional.Observers
{
    public class ObserverB : IObserver
    {
        private AbstractSubject subject;

        public ObserverB(AbstractSubject subject)
        {
            this.subject = subject;
            this?.subject.Register(this);
        }

        public void Dispose()
        {
            subject = null;
        }

        public void Update()
        {
            const int DIVISOR = 5;

            if (subject?.State % DIVISOR == 0)
                Console.WriteLine($"{nameof(ObserverB)}: {subject.State} is divisable by {DIVISOR}");
        }
    }
}
