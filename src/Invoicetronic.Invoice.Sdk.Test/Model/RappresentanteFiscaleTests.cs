/*
 * Italian eInvoice API
 *
 * The Italian eInvoice API is a RESTful API that allows you to send and receive invoices through the Italian [Servizio di Interscambio (SDI)][1], or Interchange Service. The API is designed by Invoicetronic to be simple and easy to use, abstracting away SDI complexity while providing complete control over the invoice send/receive process. The API also provides advanced features as encryption at rest, invoice validation, multiple upload formats, webhooks, event logging, client SDKs for commonly used languages, and CLI tools.  For more information, see  [Invoicetronic website][2]  [1]: https://www.fatturapa.gov.it/it/sistemainterscambio/cose-il-sdi/ [2]: https://invoicetronic.com/
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: support@invoicetronic.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Invoicetronic.Invoice.Sdk.Model;
using Invoicetronic.Invoice.Sdk.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Invoicetronic.Invoice.Sdk.Test.Model
{
    /// <summary>
    ///  Class for testing RappresentanteFiscale
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class RappresentanteFiscaleTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for RappresentanteFiscale
        //private RappresentanteFiscale instance;

        public RappresentanteFiscaleTests()
        {
            // TODO uncomment below to create an instance of RappresentanteFiscale
            //instance = new RappresentanteFiscale();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of RappresentanteFiscale
        /// </summary>
        [Fact]
        public void RappresentanteFiscaleInstanceTest()
        {
            // TODO uncomment below to test "IsType" RappresentanteFiscale
            //Assert.IsType<RappresentanteFiscale>(instance);
        }

        /// <summary>
        /// Test the property 'DatiAnagrafici'
        /// </summary>
        [Fact]
        public void DatiAnagraficiTest()
        {
            // TODO unit test for the property 'DatiAnagrafici'
        }
    }
}
