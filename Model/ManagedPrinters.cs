using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace NetworkPrinterConfigurationAutomation.Model
{
    class ManagedPrinters
    {
        public static string Password { get; } = ConfigurationManager.AppSettings.Get("Password");
        List<Printer> Printers { get; set; }
    }
}
