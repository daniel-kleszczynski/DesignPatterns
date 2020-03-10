using ChainOfResponsibilityDemo.Models;
using System;

namespace ChainOfResponsibilityDemo.Handlers
{
    public sealed class EndOfChainHandler : IHandler
    {
        private EndOfChainHandler() { }

        //Static initialization ensures only one instance will be created lazily (despite multi=threading)
        public static EndOfChainHandler Instance { get; } = new EndOfChainHandler();

        public ResponseStatus Process(BusinessData businessData)
        {
            return ResponseStatus.Unhandled;
        }

        public void SetNext(IHandler nextHandler)
        {
        }
    }
}
