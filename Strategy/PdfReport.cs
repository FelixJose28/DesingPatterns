namespace Strategy
{
    internal class PdfReport : IReport
    {
        public string PrintReport()
        {
            return nameof(PdfReport);
        }
    }
}
