﻿using ChainOfResponsibilityDemo.Models;
using System;

namespace ChainOfResponsibilityDemo.Handlers
{
    public class HandlerA : IHandler
    {
        private IHandler nextHandler;

        public void Handle(BusinessData businessData)
        {
            if (businessData == null)
            {
                Console.WriteLine($"{nameof(businessData)} is null.");
                return;
            }

            if (businessData.IsA)
                Console.WriteLine($"{nameof(HandlerA)} is processing ...");
            else
            {
                if (nextHandler != null)
                {
                    Console.WriteLine($"{nameof(HandlerA)} is passing to the next handler.");
                    nextHandler.Handle(businessData);
                }
                else
                    Console.WriteLine($"{nameof(HandlerA)} is terminating.");
            }
        }

        public void SetNext(IHandler nextHandler)
        {
            this.nextHandler = nextHandler;
        }
    }
}
