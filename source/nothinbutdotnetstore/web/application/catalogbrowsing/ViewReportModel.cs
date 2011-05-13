using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.web.application.catalogbrowsing
{
  public interface IFetchInformationUsingARequest<ReportModel>
  {
    ReportModel fetch_using(IContainRequestInformation request);
  }

  public class ViewReportModel<ReportModel> : IProcessApplicationSpecificBehaviour
  {
    IDisplayReportModels reporting_engine;
    IFetchInformationUsingARequest<ReportModel> query;

    public ViewReportModel(IDisplayReportModels reporting_engine, IFetchInformationUsingARequest<ReportModel> query)
    {
      this.query = query;
      this.reporting_engine = reporting_engine;
    }

    public void run(IContainRequestInformation request)
    {
      reporting_engine.display(query.fetch_using(request));
    }
  }
}