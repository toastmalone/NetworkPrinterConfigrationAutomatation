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
        public PrinterWebSiteLayout HtmlLayout {get; set;}
        public bool IsAccesible ()
        {
            throw new NotImplementedException();
        }

        public bool IsLockedDown ()
        {
            throw new NotImplementedException();
        }
    }
}
