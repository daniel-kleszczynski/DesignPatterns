using System;

namespace TemplateMethodDemo.Modules
{
    public class ModuleA : AbstractModule
    {
        public override int GetRepeatCount()
        {
            const int COUNT = 4;

            //Some business logic to calculate the count ...

            return COUNT;
        }

        public override void MainStep()
        {
            Console.WriteLine($"Implementation of {nameof(MainStep)} in {nameof(ModuleA)}.");
        }
    }
}
