using OCP.OpenClosedPrinciple.CommonTypes;

namespace OCP.OpenClosedPrinciple.Good
{
    public class XmlReportGenerationHelper : ReportGenerationHelper
    {
        public override string GenerateReport(ReportInfo report)
        {
            string generatedPath = null;

            // Lógica para gerar um relatório XML
            // ....  
            // ....  
            generatedPath = @"%appdata%\Info\Report.xml";

            return generatedPath;
        }
    }
}
