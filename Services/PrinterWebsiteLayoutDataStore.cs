using NetworkPrinterConfigurationAutomation.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NetworkPrinterConfigurationAutomation.Services
{
    class PrinterWebsiteLayoutDataStore : IDataStore<PrinterWebSiteLayout>
    {
        public Task<bool> AddItemAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletItemAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PrinterWebSiteLayout> GetItemAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PrinterWebSiteLayout> GetItemsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
