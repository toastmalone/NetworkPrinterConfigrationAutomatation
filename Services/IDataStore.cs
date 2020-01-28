using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NetworkPrinterConfigurationAutomation.Services
{
    interface IDataStore<T>
    {
        public Task<T> GetItemAsync();
        public IEnumerable<T> GetItemsAsync();
        public Task<bool> DeletItemAsync();
        public Task<bool> AddItemAsync();
    }
}
