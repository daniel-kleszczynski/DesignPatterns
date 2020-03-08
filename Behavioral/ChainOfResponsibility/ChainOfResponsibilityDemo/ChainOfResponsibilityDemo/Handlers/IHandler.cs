using ChainOfResponsibilityDemo.Models;

namespace ChainOfResponsibilityDemo.Handlers
{
    public interface IHandler
    {
        void Handle(BusinessData businessData);
        void SetNext(IHandler nextHandler);
    }
}
