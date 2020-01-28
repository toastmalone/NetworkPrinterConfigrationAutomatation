using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using NetworkPrinterConfigurationAutomation.Services.Xml;
using NetworkPrinterConfigurationAutomation.Model;

namespace NetworkPrinterConfigurationAutomationTests.ServiceTests
{
    [TestClass]
    public class PrinterXmlReaderIntegrationTest
    {
        private XmlTextWriter _xmlTextWriter;
        [TestInitialize]
        public void TestInit()
        {
            string xmlPath = "C:\\mockXml.xml";

            PrinterWebSiteLayout printerWebSiteLayout =
                new PrinterWebSiteLayout()
                {
                    AdministrationURL = "http:\\adminurl.com",
                    ApplyButtonTag = "apply",
                    ConfirmPasswordTag = "confirmpassword",
                    PasswordTag = "password",
                    PrinterModelTag = "HP",
                };

            _xmlTextWriter = new XmlTextWriter(xmlPath, null);
            _xmlTextWriter.WriteStartDocument();
            _xmlTextWriter.WriteStartElement(nameof(PrinterWebSiteLayout));
            _xmlTextWriter.WriteStartElement(nameof(PrinterWebSiteLayout.AdministrationURL));
            _xmlTextWriter.WriteEndElement();
            _xmlTextWriter.WriteEndElement();
            _xmlTextWriter.WriteEndDocument();
            _xmlTextWriter.Close();
            
        }
    }
}
