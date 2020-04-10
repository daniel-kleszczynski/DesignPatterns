using System;

namespace ObserverDemo.Traditional.Observables
{
    public class Subject : AbstractSubject
    {
        private readonly Random random = new Random(DateTime.Now.Millisecond);

        public override void ChangeState()
        {
            const int MIN = 1;
            const int MAX = 99;

            State = random.Next(MIN, MAX + 1);
        }
    }
}
