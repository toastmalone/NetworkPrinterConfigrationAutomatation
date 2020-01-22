using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NetworkPrinterConfigurationAutomation.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string textTest;
        public string TextTest 
        { 
            get { return textTest; }
            set { SetProperty(ref textTest, value); }
        }

        public MainWindowViewModel()
        {
            textTest = "test";
        }

        public AsyncDelegateCommand<object> Button => new AsyncDelegateCommand<object>(a => ButtonPush());

        private async Task ButtonPush()
        {
            TextTest = "pushed the button";
        }
    }
}
