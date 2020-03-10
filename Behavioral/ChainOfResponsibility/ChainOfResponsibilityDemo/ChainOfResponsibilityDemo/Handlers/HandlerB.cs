using ChainOfResponsibilityDemo.Models;
using System;

namespace ChainOfResponsibilityDemo.Handlers
{
    public class HandlerB : IHandler
    {
        private IHandler nextHandler;

        public ResponseStatus Process(BusinessData businessData)
        {
            if (businessData == null)
                return ResponseStatus.NullData;

            if (businessData.IsB)
            {
                Console.WriteLine($"{nameof(HandlerB)} is processing ...");
                return ResponseStatus.Processed;
            }
            else
            {
                if (nextHandler != null)
                {
                    Console.WriteLine($"{nameof(HandlerB)} is passing to the next handler.");
                    return nextHandler.Process(businessData);
                }
                else
                {
                    Console.WriteLine($"{nameof(HandlerB)} is terminating.");
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
