using ObserverDemo.DotnetFour.Models;
using System;

namespace ObserverDemo.DotnetFour.Observers
{
    public class ObserverB : AbstractObserver
    {
        public ObserverB() : base(Category.B)
        {
        }

        public override void OnCompleted()
        {
            Console.WriteLine($"In {nameof(ObserverB)} {nameof(OnCompleted)}()");
        }

        public override void OnError(Exception error)
        {
            Console.WriteLine(error.Message);
        }

        public override void OnNext(Package value)
        {
            Console.WriteLine($"In {nameof(ObserverB)} Category: {value.Category} Quantity: {value.Quantity}");
        }
    }
}
