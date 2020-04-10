using ObserverDemo.EventBased.Observables;
using System;

namespace ObserverDemo.EventBased.Observers
{
    public class ObserverA : IObserver
    {
        private Subject subject;

        public ObserverA(Subject subject)
        {
            this.subject = subject;
            SubscribeEvents();
        }

        private void SubscribeEvents()
        {
            if (subject == null)
                return;

            subject.NumberChanged += NumberChangedHandler;
            subject.NameChanged += NameChangedHandler;
        }

        private void NameChangedHandler(object sender, CustomEventArgs e)
        {
            var observer = nameof(ObserverA);
            var eventName = nameof(subject.NameChanged);
            Console.WriteLine($"{observer} , {eventName}, run by {e.Author} on {e.EventTime}\n");
        }

        private void NumberChangedHandler(object sender, CustomEventArgs e)
        {
            const int DIVISOR = 3;
            Subject subject = (Subject)sender;

            if (subject.Number % DIVISOR == 0)
            {
                Console.WriteLine($"{nameof(ObserverA)}: {subject.Number} is divisable by {DIVISOR}, run by {e.Author} on {e.EventTime}\n");
                subject.Name = nameof(ObserverA);
            }
        }

        public void Dispose()
        {
            subject.NumberChanged -= NumberChangedHandler;
            subject.NameChanged -= NameChangedHandler;
        }
    }
}
