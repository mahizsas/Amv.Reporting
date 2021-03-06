using System;
using AmvReporting.Domain.Reports;

namespace AmvReporting.Domain.Preview.ViewModels
{
    public class ReportResultPreview
    {
        public String Data { get; set; }
        public String JavaScript { get; set; }
        public String GlobalJs { get; set; }
        public String Css { get; set; }
        public String GlobalCss { get; set; }
        public String HtmlOverride { get; set; }
        public ReportType ReportType { get; set; }
    }
}