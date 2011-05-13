using nothinbutdotnetstore.web.application.stubs;
using nothinbutdotnetstore.web.core;
using nothinbutdotnetstore.web.core.stubs;

namespace nothinbutdotnetstore.web.application.catalogbrowsing
{
  public class ViewTheDepartmentsInADepartments : IProcessApplicationSpecificBehaviour
  {
    IFindInformationInTheStoreCatalog store_catalog;
    IDisplayReportModels report_engine;

    public ViewTheDepartmentsInADepartments():this(new StubInformationInTheStoreCatalogRepository(),
      new StubReportEngine())
    {
    }

    public ViewTheDepartmentsInADepartments(IFindInformationInTheStoreCatalog store_catalog, IDisplayReportModels report_engine)
    {
      this.store_catalog = store_catalog;
      this.report_engine = report_engine;
    }

    public void run(IContainRequestInformation request)
    {
      report_engine.display(store_catalog.get_departments_in(request.map<DepartmentItem>()));
    }
  }
}