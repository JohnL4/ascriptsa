using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.web.application.catalogbrowsing
{
  public class ViewTheMainDepartmentsInTheStore : IProcessApplicationSpecificBehaviour
  {
    IFindInformationInTheStoreCatalog store_catalog;
    IDisplayReportModels reporting_engine;

    public ViewTheMainDepartmentsInTheStore(IFindInformationInTheStoreCatalog store_catalog,
                                            IDisplayReportModels reporting_engine)
    {
      this.store_catalog = store_catalog;
      this.reporting_engine = reporting_engine;
    }

    public void run(IContainRequestInformation request)
    {
      reporting_engine.display(store_catalog.get_the_main_departments_in_the_store());
    }
  }
}