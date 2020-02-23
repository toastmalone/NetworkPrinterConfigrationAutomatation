using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NetworkPrinterConfigurationAutomation.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    { 
        private readonly ConfigurePrintersViewModel _configurePrintersViewModel;

        private ViewModelBase _currentViewModel;
        public ViewModelBase CurrentViewModel { get { return _currentViewModel; } set { SetProperty(ref _currentViewModel, value); } }
        public MainWindowViewModel()
        {
            _configurePrintersViewModel = new ConfigurePrintersViewModel(this);
            _currentViewModel = _configurePrintersViewModel;
        }
        public DelegateCommand<string> NavCommand => new DelegateCommand<string>(a => OnNav(a));

        public void OnNav(string destination)
        {

            switch (destination)
            {
                case "configure":
                    {
                        CurrentViewModel = _configurePrintersViewModel;
                        break;
                    }

            }
        }
    }
}
