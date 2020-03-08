using ChainOfResponsibilityDemo.Models;
using System;

namespace ChainOfResponsibilityDemo.Handlers
{
    public class HandlerB : IHandler
    {
        private IHandler nextHandler;

        public void Handle(BusinessData businessData)
        {
            if (businessData == null)
            {
                Console.WriteLine($"{nameof(businessData)} is null.");
                return;
            }

            if (businessData.IsB)
                Console.WriteLine($"{nameof(HandlerB)} is processing ...");
            else
            {
                if (nextHandler != null)
                {
                    Console.WriteLine($"{nameof(HandlerB)} is passing to the next handler.");
                    nextHandler.Handle(businessData);
                }
                else
                    Console.WriteLine($"{nameof(HandlerB)} is terminating.");
            }
        }

        public void SetNext(IHandler nextHandler)
        {
            this.nextHandler = nextHandler;
        }
    }
}
