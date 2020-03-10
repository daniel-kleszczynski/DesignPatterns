using ChainOfResponsibilityDemo.Models;
using System;

namespace ChainOfResponsibilityDemo.Handlers
{
    public class HandlerA : IHandler
    {
        private IHandler nextHandler;

        public ResponseStatus Process(BusinessData businessData)
        {
            if (businessData == null)
                return ResponseStatus.NullData;

            if (businessData.IsA)
            {
                Console.WriteLine($"{nameof(HandlerA)} is processing ...");
                return ResponseStatus.Processed;
            }
            else
            {
                if (nextHandler != null)
                {
                    Console.WriteLine($"{nameof(HandlerA)} is passing to the next handler.");
                    return nextHandler.Process(businessData);
                }
                else
                {
                    Console.WriteLine($"{nameof(HandlerA)} is terminating.");
                    return ResponseStatus.Unhandled;
                }
            }
        }

        public void SetNext(IHandler nextHandler)
        {
            this.nextHandler = nextHandler;
        }
    }
}
