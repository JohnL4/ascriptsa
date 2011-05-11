using System;

namespace nothinbutdotnetstore.web.core
{
    public class FrontController : IProcessApplicationRequests
    {
        IFindSpecificRequestHandlers registry;

        public FrontController(IFindSpecificRequestHandlers registry)
        {
            this.registry = registry;
        }

        public void process(IContainRequestInformation request)
        {
            IProcessOneUniqueRequest processor = registry.get_the_command_that_can_process(request);
            processor.run(request);
        }
    }
}