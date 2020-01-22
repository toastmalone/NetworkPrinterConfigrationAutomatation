using System;
using System.Collections.Generic;
using System.Text;

namespace NetworkPrinterConfigurationAutomation.Model
{
    public class PrinterWebSite
    {
        public string AdministrationURL { get; set; }
        public string PasswordTag { get; set; }
        public string ConfirmPasswordTag { get; set; }
        public string ApplyButtonTag { get; set; }
        public string ModelTag { get; set; }
    }
}
