namespace Builder.Interfaces
{
    public abstract class ReportBuilder
    {
        protected ReportProduct reportObject;
        public abstract void SetReportType();
        public abstract void SetReportHeader();
        public abstract void SetReportContent();
        public abstract void SetReportFooter();
        public void CreateNewReport()
        {
            reportObject = new ReportProduct();
        }
        public ReportProduct GetReport()
        {
            return reportObject;
        }
    }
}
