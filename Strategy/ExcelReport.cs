namespace Strategy
{
    internal class ExcelReport : IReport
    {
        public string PrintReport()
        {
            return nameof(ExcelReport);
        }
    }
}
