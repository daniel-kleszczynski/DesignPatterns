using ObserverDemo.Traditional.Observers;
using System;
using System.Threading;

namespace ObserverDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            TraditionalDemo();
            EventBasedDemo();
            DotnetFourDemo();

            Console.ReadKey();
        }

        private static void TraditionalDemo()
        {
            using (var subject = new Traditional.Observables.Subject())
            using (var observerA = new ObserverA(subject))
            using (var observerB = new ObserverB(subject))
            {

                for (int i = 0; i < 10; i++)
                {
                    subject.ChangeState();
                    Thread.Sleep(i);
                }
            }
        }

        private static void EventBasedDemo()
        {
            using (var subject = new EventBased.Observables.Subject())
            using (var observerA = new EventBased.Observers.ObserverA(subject))
            using (var observerB = new EventBased.Observers.ObserverB(subject))
            {
                for (int i = 0; i < 10; i++)
                {
                    subject.ChangeFirst();
                    Thread.Sleep(i);
                }
            }
        }

        private static void DotnetFourDemo()
        {
            var subject = new DotnetFour.Observables.Subject();
            var observerA = new DotnetFour.Observers.ObserverA();
            var observerB = new DotnetFour.Observers.ObserverB();

            using (subject.Subscribe(observerA))
            using (subject.Subscribe(observerB))
            {
                for (int i = 0; i < 10; i++)
                {
                    subject.PushPackage();
                    Thread.Sleep(i);
                }
            }
        }
    }
}
