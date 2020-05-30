using OCP.OpenClosedPrinciple.CommonTypes;

namespace OCP.OpenClosedPrinciple.Good
{
    public class ExcelReportGenerationHelper : ReportGenerationHelper
    {
        public override string GenerateReport(ReportInfo report)
        {
            string generatedPath = null;

            // Lógica para gerar um relatório EXCEL
            // ....  
            // ....  
            generatedPath = @"%appdata%\Info\Report.xls";

            return generatedPath;
        }
    }
}
