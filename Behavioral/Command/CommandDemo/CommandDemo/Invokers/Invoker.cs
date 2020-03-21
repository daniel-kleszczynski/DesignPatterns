using CommandDemo.Commands;
using CommandDemo.Receivers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;

namespace CommandDemo.Invokers
{
    public class Invoker
    {
        private Dictionary<string, Type> commandTypes = new Dictionary<string, Type>();
        private List<ICommand> commands = new List<ICommand>();
        private Stack<ICommand> executedCommands = new Stack<ICommand>();
        private IReceiver receiver;

        public Invoker(IReceiver receiver)
        {
            this.receiver = receiver;
        }

        public void SetupCommands()
        {
            var commandsText = ConfigurationManager.AppSettings.Get("commandsList");

            if (string.IsNullOrEmpty(commandsText))
                return;

            var parts = commandsText.Split(new char[] { ',' }, System.StringSplitOptions.RemoveEmptyEntries);
            var assembly = Assembly.GetExecutingAssembly();

            LoadCommandTypes(assembly);

            for (int i = 0; i < parts.Length - 1; i++)
            {
                var commandText = parts[i].Trim();
                var paramText = parts[++i].Trim();

                try
                {
                    var param = int.Parse(paramText);
                    var commandType = commandTypes[commandText];
                    var command = (ICommand)Activator.CreateInstance(commandType, receiver, param);
                    commands.Add(command);
                }
                catch (Exception ex)
                {
                }
            }
        }

        public void ExecuteAll()
        {
            foreach (var command in commands)
            {
                try
                {
                    if (!command.CanExecute())
                        continue;

                    command.Execute();
                    executedCommands.Push(command);
                }
                catch (Exception ex)
                {
                }
            }
        }

        public void UndoAll()
        {
            try
            {
                while (true)
                {
                    var command = executedCommands.Pop();

                    if (command == null)
                        break;

                    command.Undo();
                }
            }
            catch (Exception)
            {
            }
        }

        private void LoadCommandTypes(Assembly assembly)
        {
            var types = assembly.GetTypes().Where(t => t.Name.EndsWith("Command") && t.Name != "ICommand");

            foreach (var type in types)
            {
                commandTypes.Add(type.FullName, type);
            }
        }
    }
}
