using System;
using System.Collections.Generic;
using System.Text;

namespace NetworkPrinterConfigurationAutomation.Model
{
    public class Printer
    {
        public string Ip { get; set; }
        public string HostName { get; set; }
        public string PrinterModel { get; set; }
        public PrinterWebSite HtmlLayout {get; set;}

    }
}
