namespace Strategy
{
    internal class WordReport : IReport
    {
        public string PrintReport()
        {
            return nameof(WordReport);
        }
    }
}
