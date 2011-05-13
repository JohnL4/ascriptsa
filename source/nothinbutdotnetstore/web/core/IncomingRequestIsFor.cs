namespace nothinbutdotnetstore.web.core
{
  public class IncomingRequestIsFor<Command>  where Command : IProcessApplicationSpecificBehaviour
  {
    public bool matches(IContainRequestInformation request)
    {
      return false;
    }
    
  }
}