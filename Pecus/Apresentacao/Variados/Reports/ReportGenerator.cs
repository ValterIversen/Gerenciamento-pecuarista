
using Microsoft.Reporting.WebForms;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Apresentacao.Variados.Reports
{
    public class ReportGenerator
    {
        public void CallReport(string ReportName, List<ReportDataSource> reportDataSources, List<ReportParameter> listReportParameter)
        {

            //Componente de relatório
            ReportViewer reportViewer = new ReportViewer();

            reportViewer.ProcessingMode = ProcessingMode.Local;
            reportViewer.LocalReport.ReportEmbeddedResource = "Apresentacao.Variados.Reports." + ReportName;

            reportViewer.LocalReport.SetParameters(listReportParameter);

            reportViewer.LocalReport.DataSources.Clear();
            foreach (ReportDataSource dataSource in reportDataSources)
            {
                reportViewer.LocalReport.DataSources.Add(dataSource);
            }

            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string filenameExtension;

            byte[] bytes = reportViewer.LocalReport.Render(
                "PDF", null, out mimeType, out encoding, out filenameExtension,
                out streamids, out warnings);

            using (FileStream fs = new FileStream("output.pdf", FileMode.Create))
            {
                fs.Write(bytes, 0, bytes.Length);
            }

            System.Diagnostics.Process.Start("output.pdf");
        }
    }
}
