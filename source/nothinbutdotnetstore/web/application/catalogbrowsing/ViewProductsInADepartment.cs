using nothinbutdotnetstore.web.application.stubs;
using nothinbutdotnetstore.web.core;
using nothinbutdotnetstore.web.core.stubs;

namespace nothinbutdotnetstore.web.application.catalogbrowsing
{
  public class ViewProductsInADepartment : IProcessApplicationSpecificBehaviour
  {
    IDisplayReportModels report_engine;
    IFindInformationInTheStoreCatalog store_catalog;

    public ViewProductsInADepartment()
        : this(Stub.with<StubReportEngine>(),
                                              Stub.with<StubInformationInTheStoreCatalogRepository>())
    {
    }

    public ViewProductsInADepartment(IDisplayReportModels report_engine,
                                     IFindInformationInTheStoreCatalog store_catalog)
    {
      this.report_engine = report_engine;
      this.store_catalog = store_catalog;
    }

    public void run(IContainRequestInformation request)
    {
      report_engine.display(store_catalog.get_products_in(request.map<DepartmentItem>()));
    }
  }
}