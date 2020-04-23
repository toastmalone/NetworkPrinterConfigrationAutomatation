using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NetworkPrinterConfigurationAutomation.WPF.Model
{
    public class PrinterRouteScheme
    {
        
        [Required]
        public int Id { get; set; }
        [Required]
        public string AdministrationURL { get; set; }
        [Required]
        public string PasswordTag { get; set; }
        public string ConfirmPasswordTag { get; set; }
        [Required]
        public string ApplyButtonTag { get; set; }
        public string PrinterModelTag { get; set; }
    }
}
