namespace ChainOfResponsibilityPattern
{
    public interface IHandler
    {
        void Handle(RequestContext requestContext);
    }
}