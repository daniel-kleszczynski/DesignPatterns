using ObserverDemo.DotnetFour.Models;
using System;

namespace ObserverDemo.DotnetFour.Observers
{
    public class ObserverA : AbstractObserver
    {
        public ObserverA() : base(Category.A)
        {
        }

        public override void OnCompleted()
        {
            Console.WriteLine($"In {nameof(ObserverA)} {nameof(OnCompleted)}()");
        }

        public override void OnError(Exception error)
        {
            Console.WriteLine(error.Message);
        }

        public override void OnNext(Package value)
        {
            Console.WriteLine($"In {nameof(ObserverA)} Category: {value.Category} Quantity: {value.Quantity}");
        }
    }
}
