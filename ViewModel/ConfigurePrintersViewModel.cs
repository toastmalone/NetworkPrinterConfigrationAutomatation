using System;
using System.Collections.Generic;
using System.Text;

namespace NetworkPrinterConfigurationAutomation.ViewModel
{
    public class ConfigurePrintersViewModel : ViewModelBase
    {
        private MainWindowViewModel _mainWindowViewModel;
        public ConfigurePrintersViewModel(MainWindowViewModel mainWindowViewModel)
        {
            _mainWindowViewModel = mainWindowViewModel;
        }

    }
}
