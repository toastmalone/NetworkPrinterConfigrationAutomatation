using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using NetworkPrinterConfigurationAutomation.WPF.Model;

namespace NetworkPrinterConfigurationAutomationTests.ServiceTests
{
    [TestClass]
    public class PrinterXmlReaderIntegrationTest
    {
        [TestInitialize]
        public void TestInit()
        { 
            PrinterRouteScheme printerWebSiteLayout =
                new PrinterRouteScheme()
                {
                    AdministrationURL = "http:\\adminurl.com",
                    ApplyButtonTag = "apply",
                    ConfirmPasswordTag = "confirmpassword",
                    PasswordTag = "password",
                    PrinterModelTag = "HP",
                };
            
        }
    }
}
