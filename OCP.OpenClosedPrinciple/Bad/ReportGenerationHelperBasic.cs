namespace OCP.OpenClosedPrinciple.Bad
{
    public class ReportGenerationHelperBasic
    {
        public string GenerateReport(string data)
        {
            return @"%appdata%\Info\Report.xls";
        }
    }
}
