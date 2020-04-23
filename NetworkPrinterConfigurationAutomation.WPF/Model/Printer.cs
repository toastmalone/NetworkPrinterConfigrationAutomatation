using System;
using System.Collections.Generic;
using System.Text;

namespace NetworkPrinterConfigurationAutomation.WPF.Model
{
    public class Printer
    {
        public string Ip { get; set; }
        public string HostName { get; set; }
        public string PrinterModel { get; set; }
        public PrinterRouteScheme Scheme {get; set;}
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
