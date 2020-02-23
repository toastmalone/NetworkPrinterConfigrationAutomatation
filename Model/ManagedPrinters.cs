using System;
using System.Collections.Generic;
using System.Text;

namespace NetworkPrinterConfigurationAutomation.Model
{
    class ManagedPrinters
    { 
        string Domain { get; set; }
        string Password { get; set; }
        List<Printer> Printers { get; set; }

    }
}
