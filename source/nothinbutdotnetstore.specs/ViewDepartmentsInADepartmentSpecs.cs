 using System;
 using System.Collections.Generic;
 using Machine.Specifications;
 using developwithpassion.specifications.rhinomocks;
 using developwithpassion.specifications.extensions;
 using nothinbutdotnetstore.web.application;
 using nothinbutdotnetstore.web.application.catalogbrowsing;
 using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.specs
{   
    public class ViewDepartmentsInADepartmentSpecs
    {
        public abstract class concern : Observes<IProcessApplicationSpecificBehaviour,
                                            ViewDepartmentsInADepartment>
        {
        
        }

        [Subject(typeof(ViewDepartmentsInADepartment))]
        public class when_run : concern
        {
            Establish c = () =>
            {
                request = fake.an<IContainRequestInformation>();
                report_engine = depends.on<IDisplayReportModels>();
                department_repository = depends.on<IFindDepartments>();

                the_departments = new List<DepartmentItem> {new DepartmentItem()};

                department_repository.setup(x => x.get_departments_of(request.department)).Return(the_departments);
            };

            Because b = () =>
                sut.run(request);

            It should_display_the_departments = () =>        /* ..._of_the_given_department? */
                    report_engine.received(x => x.display(the_departments));

            static IDisplayReportModels report_engine;
            static IEnumerable<DepartmentItem> the_departments;
            static IContainRequestInformation request;
            static IFindDepartments department_repository;
        }
    }

    public class ViewDepartmentsInADepartment : IProcessApplicationSpecificBehaviour
    {
        public void run(IContainRequestInformation request)
        {
            throw new NotImplementedException();
        }
    }
}
