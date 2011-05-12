using System;

namespace nothinbutdotnetstore.web.core
{
    public class UniqueRequestProcessor : IProcessOneUniqueRequest
    {
        public void run(IContainRequestInformation request)
        {
            throw new NotImplementedException();
        }

        public bool can_handle(IContainRequestInformation request)
        {
            throw new NotImplementedException();
        }
    }
}