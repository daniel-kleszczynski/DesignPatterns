using System;

namespace ObserverDemo.EventBased.Observables
{
    public class Subject : ISubject
    {
        private Random random = new Random(DateTime.Now.Millisecond);
        private int first;
        private string name;

        public int Number
        {
            get => first;
            private set
            {
                first = value;
                NumberChanged?.Invoke(this, new CustomEventArgs { EventTime = DateTime.Now, Author = nameof(Subject) });
            }
        }
        public string Name
        {
            get => name;
            set
            {
                name = value;
                NameChanged?.Invoke(this, new CustomEventArgs { EventTime = DateTime.Now, Author = Name });
            }
        }

        public event EventHandler<CustomEventArgs> NumberChanged;
        public event EventHandler<CustomEventArgs> NameChanged;

        public void ChangeFirst()
        {
            const int MIN = 1;
            const int MAX = 99;

            Number = random.Next(MIN, MAX + 1);
        }

        public void Dispose()
        {
            NumberChanged = null;
            NameChanged = null;
        }
    }
}
