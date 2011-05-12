using Machine.Specifications;
 using developwithpassion.specifications.rhinomocks;
 using developwithpassion.specifications.extensions;
 using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.specs
{   
    public class UniqueRequestProcessorSpecs
    {
        public abstract class concern : Observes<IProcessOneUniqueRequest,
                                            UniqueRequestProcessor>
        {
        
        }

        [Subject(typeof(UniqueRequestProcessor))]
        public class when_determining_if_a_request_can_be_processed_and_it_can_do_so : concern
        {
            Establish c = () =>
            {
                request = fake.an<IContainRequestInformation>();
            };

            Because b = () =>
                result = sut.can_handle(request);

            It should_return_true = () =>
                result.ShouldEqual(true);

            static IContainRequestInformation request;
            static bool result;
        }
    }
}
