using System.Collections.Generic;
using nothinbutdotnetstore.web.application.catalogbrowsing;
using nothinbutdotnetstore.web.application.stubs;

namespace nothinbutdotnetstore.web.core.stubs
{
  public class GetTheMainDepartments : IFetchInformationUsingARequest<IEnumerable<DepartmentItem>>
  {
    public IEnumerable<DepartmentItem> fetch_using(IContainRequestInformation request)
    {
      return Stub.with<StubInformationInTheStoreCatalogRepository>().get_departments_in(request.map<DepartmentItem>());
    }
  }
}