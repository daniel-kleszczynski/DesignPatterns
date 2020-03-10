using ChainOfResponsibilityDemo.Models;
using System;

namespace ChainOfResponsibilityDemo.Handlers
{
    public class HandlerC : IHandler
    {
        private IHandler nextHandler;

        public ResponseStatus Process(BusinessData businessData)
        {
            if (businessData == null)
                return ResponseStatus.NullData;

            if (businessData.IsC)
            {
                Console.WriteLine($"{nameof(HandlerC)} is processing ...");
                return ResponseStatus.Processed;
            }
            else
            {
                if (nextHandler != null)
                {
                    Console.WriteLine($"{nameof(HandlerC)} is passing to the next handler.");
                    return nextHandler.Process(businessData);
                }
                else
                {
                    Console.WriteLine($"{nameof(HandlerC)} is terminating.");
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
