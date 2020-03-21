namespace CommandDemo.Receivers
{
    public interface IReceiver
    {
        void Add(int value);
        void Subtract(int value);

        int CurrentValue { get; }
        bool IsEnabled { get; }

        string GetName();
    }
}
