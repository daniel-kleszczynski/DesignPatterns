using CommandDemo.Receivers;
using System;
using System.Runtime.CompilerServices;

namespace CommandDemo.Commands
{
    public class AddCommand : ICommand
    {
        private readonly IReceiver receiver;
        private readonly int value;

        public AddCommand(IReceiver receiver, int value)
        {
            this.receiver = receiver;
            this.value = value;
        }

        private void Log([CallerMemberName]string caller = null)
        {
            var message = $"\n{nameof(AddCommand)} {caller}() on {receiver.GetName()} with param {value}.";
            Console.WriteLine(message);
        }

        public void Execute()
        {
            if (receiver == null)
            {
                Console.WriteLine($"No receiver supplied to {nameof(AddCommand)}");
                return;
            }

            Log();
            receiver.Add(value);
        }

        public bool CanExecute()
        {
            return value < 1 ? false :  (bool)receiver?.IsEnabled;
        }

        public void Undo()
        {
            if (receiver == null)
            {
                Console.WriteLine($"No receiver supplied to {nameof(AddCommand)}");
                return;
            }

            receiver.Subtract(value);
            Log();
        }
    }
}
