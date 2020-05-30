namespace OCP.OpenClosedPrinciple.CommonTypes
{
    public class ReportInfo
    {
        public ReportInfo(string reportType, string data)
        {
            ReportType = reportType;
            Data = data;
        }

        public string ReportType { get; set; }

        public string Data { get; set; }
    }
}