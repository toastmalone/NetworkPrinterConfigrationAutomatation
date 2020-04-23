using NetworkPrinterConfigurationAutomation.WPF.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NetworkPrinterConfigurationAutomation.Services
{
    class PrinterWebsiteLayoutDataStore : IDataStore<PrinterRouteScheme>
    {
        public Task<bool> AddItemAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletItemAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PrinterRouteScheme> GetItemAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PrinterRouteScheme> GetItemsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
