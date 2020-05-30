using OCP.OpenClosedPrinciple.CommonTypes;

namespace OCP.OpenClosedPrinciple.Good
{
    public class WordReportGenerationHelper : ReportGenerationHelper
    {
        public override string GenerateReport(ReportInfo report)
        {
            string generatedPath = null;

            // Lógica para gerar um relatório Word
            // ....  
            // ....  
            generatedPath = @"%appdata%\Info\Report.docx";

            return generatedPath;
        }
    }
}
