using OCP.OpenClosedPrinciple.CommonTypes;

namespace OCP.OpenClosedPrinciple.Bad
{
    public class ReportGenerationHelper
    {
        public string GenerateReport(ReportInfo report)
        {
            string generatedPath = string.Empty;

            if (report.ReportType == "EXCEL")
            {
                // Lógica para gerar arquivo Excel
                // ....  
                generatedPath = @"%appdata%\Info\Report.xls";
            }
            else if (report.ReportType == "PDF")
            {
                // Lógica para gerar arquivo PDF
                // ....  
                generatedPath = @"%appdata%\Info\Report.pdf";
            }
            else if (report.ReportType == "WORD")
            {
                // Lógica para gerar arquivo WORD
                // ....  
                generatedPath = @"%appdata%\Info\Report.docx";
            }

            // E se eu quiser adicionar a geração em XML ???

            else if (report.ReportType == "XML")
            {
                // ...
                generatedPath = @"%appdata%\Info\Report.mxl";
            }

            return generatedPath;
        }
    }
}
