using System;

namespace TemplateMethodDemo.Modules
{
    public class ModuleB : AbstractModule
    {
        public override int GetRepeatCount()
        {
            const int COUNT = 1;

            //Some business logic to calculate the count ...

            return COUNT;
        }

        public override void InitialStep()
        {
            Console.WriteLine($"Implementation of {nameof(InitialStep)} in {nameof(ModuleB)}.");
        }

        public override void MainStep()
        {
            Console.WriteLine($"Implementation of {nameof(MainStep)} in {nameof(ModuleB)}.");
        }
    }
}
