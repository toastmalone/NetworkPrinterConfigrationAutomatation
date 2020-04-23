using NetworkPrinterConfigurationAutomation.Delegates;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NetworkPrinterConfigurationAutomation.WPF.Model;

namespace NetworkPrinterConfigurationAutomation.ViewModel
{
    public class ConfigurePrintersViewModel : ViewModelBase
    {
        private ManagedPrinters _managedPrinters;
        private MainWindowViewModel _mainWindowViewModel;
        public ConfigurePrintersViewModel(MainWindowViewModel mainWindowViewModel)
        {
            _mainWindowViewModel = mainWindowViewModel;
            _managedPrinters = new ManagedPrinters();
        }

        public DelegateCommand<string> ConfigurePrinterCommand => new DelegateCommand<string>(s => ConfigurePrinter(s));
        
        public void ConfigurePrinter(string IP)
        {

            using(IWebDriver driver = new ChromeDriver())
            {
                
            }
        }
    }
}
