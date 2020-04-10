using ObserverDemo.Traditional.Observables;
using System;

namespace ObserverDemo.Traditional.Observers
{
    public class ObserverA : IObserver
    {
        private AbstractSubject subject;

        public ObserverA(AbstractSubject subject)
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
            const int DIVISOR = 3;

            if (subject?.State % DIVISOR == 0)
                Console.WriteLine($"{nameof(ObserverA)}: {subject.State} is divisable by {DIVISOR}");
        }
    }
}
