namespace CommandDemo.Receivers
{
    public class Receiver : IReceiver
    {
        public Receiver()
        {
        }

        public int CurrentValue { get; private set; }
        public bool IsEnabled { get; private set; } = true;

        public void Add(int value)
        {
            CurrentValue += value;
        }

        public string GetName()
        {
            return nameof(Receiver);
        }

        public void Subtract(int value)
        {
            CurrentValue -= value;
        }
    }
}
