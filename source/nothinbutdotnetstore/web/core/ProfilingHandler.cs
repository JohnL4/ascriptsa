using System;

namespace nothinbutdotnetstore.web.core
{
    public class ProfilingHandler : IProcessOneUniqueRequest
    {
        IProcessOneUniqueRequest handler; 

        public ProfilingHandler(IProcessOneUniqueRequest handler)
        {
            this.handler = handler;
        }

        public void run(IContainRequestInformation request)
        {
            Console.WriteLine(handler.GetType().Name + ": start: " + new DateTime());
            handler.run(request);
            Console.WriteLine(handler.GetType().Name + ": end: " + new DateTime());

        }

        public bool can_handle(IContainRequestInformation request)
        {
            return true;
        }
    }
}