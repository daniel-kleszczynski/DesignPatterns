using ChainOfResponsibilityDemo.Models;
using System;

namespace ChainOfResponsibilityDemo.Handlers
{
    public class HandlerC : IHandler
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
                Console.WriteLine($"{nameof(HandlerC)} is processing ...");
            else
            {
                if (nextHandler != null)
                {
                    Console.WriteLine($"{nameof(HandlerC)} is passing to the next handler.");
                    nextHandler.Handle(businessData);
                }
                else
                    Console.WriteLine($"{nameof(HandlerC)} is terminating.");
            }
        }

        public void SetNext(IHandler nextHandler)
        {
            this.nextHandler = nextHandler;
        }
    }
}
