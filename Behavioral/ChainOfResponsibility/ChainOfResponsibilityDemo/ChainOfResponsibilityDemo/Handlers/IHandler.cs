using ChainOfResponsibilityDemo.Models;

namespace ChainOfResponsibilityDemo.Handlers
{
    public interface IHandler
    {
        ResponseStatus Process(BusinessData businessData);
        void SetNext(IHandler nextHandler);
    }
}
