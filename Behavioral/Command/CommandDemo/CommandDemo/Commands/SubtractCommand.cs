using CommandDemo.Receivers;
using System;
using System.Runtime.CompilerServices;

namespace CommandDemo.Commands
{
    public class SubtractCommand : ICommand
    {
        private readonly IReceiver receiver;
        private readonly int value;

        public SubtractCommand(IReceiver receiver, int value)
        {
            this.receiver = receiver;
            this.value = value;
        }

        public bool CanExecute()
        {
            return value < 1 ? false : (bool)receiver?.IsEnabled;
        }

        public void Execute()
        {
            if (receiver == null)
            {
                Console.WriteLine($"No receiver supplied to {nameof(SubtractCommand)}");
                return;
            }

            Log();

            receiver.Subtract(value);
        }

        public void Undo()
        {
            if (receiver == null)
            {
                Console.WriteLine($"No receiver supplied to {nameof(SubtractCommand)}");
                return;
            }

            receiver.Add(value);
            Log();
        }

        private void Log([CallerMemberName]string caller = null)
        {
            var message = $"\n{nameof(SubtractCommand)} {caller}() on {receiver.GetName()} with param {value}.";
            Console.WriteLine(message);
        }
    }
}
