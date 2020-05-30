using OCP.OpenClosedPrinciple.CommonTypes;

namespace OCP.OpenClosedPrinciple.Good
{
    public class PdfReportGenerationHelper : ReportGenerationHelper
    {
        public override string GenerateReport(ReportInfo report)
        {
            string generatedPath = null;

            // Lógica para gerar um relatório PDF
            // ....  
            // ....  
            generatedPath = @"%appdata%\Info\Report.pdf";

            return generatedPath;
        }
    }
}
