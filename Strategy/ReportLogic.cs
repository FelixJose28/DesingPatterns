using System;

namespace Strategy
{
    internal class ReportLogic
    {
        public void ExecuteReport(IReport report)
        {
            Console.WriteLine(report.PrintReport());
        }
    }
}
