using System;

namespace TemplateMethodDemo.Modules
{
    public abstract class AbstractModule
    {
        public abstract void MainStep();
        public abstract int GetRepeatCount();

        public virtual void InitialStep()
        {
            Console.WriteLine($"Default implementation of {nameof(InitialStep)} in {nameof(AbstractModule)}.");
        }

        public void TemplateMethod()
        {
            var count = GetRepeatCount();

            if (count < 1)
                return;

            InitialStep();

            for (int i = 0; i < count; i++)
                MainStep();

            FinalStep();
        }

        private void FinalStep()
        {
            Console.WriteLine($"Constant implementation of {nameof(FinalStep)} in {nameof(AbstractModule)}.");
            Console.WriteLine();
        }
    }
}
