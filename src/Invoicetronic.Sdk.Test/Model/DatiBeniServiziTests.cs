/*
 * Invoicetronic API
 *
 * The [Invoicetronic API][2] is a RESTful service that allows you to send and receive invoices through the Italian [Servizio di Interscambio (SDI)][1], or Interchange Service. The API is designed to be simple and easy to use, abstracting away SDI complexity while providing complete control over the invoice send/receive process. It provides advanced features as encryption at rest, multi-language pre-flight invoice validation, multiple upload formats, webhooks, event logging, client SDKs, and CLI tools.  For more information, see  [Invoicetronic website][2]  [1]: https://www.fatturapa.gov.it/it/sistemainterscambio/cose-il-sdi/ [2]: https://invoicetronic.com/
 *
 * The version of the OpenAPI document: 1
 * Contact: info@invoicetronic.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Invoicetronic.Sdk.Model;
using Invoicetronic.Sdk.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Invoicetronic.Sdk.Test.Model
{
    /// <summary>
    ///  Class for testing DatiBeniServizi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class DatiBeniServiziTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for DatiBeniServizi
        //private DatiBeniServizi instance;

        public DatiBeniServiziTests()
        {
            // TODO uncomment below to create an instance of DatiBeniServizi
            //instance = new DatiBeniServizi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DatiBeniServizi
        /// </summary>
        [Fact]
        public void DatiBeniServiziInstanceTest()
        {
            // TODO uncomment below to test "IsType" DatiBeniServizi
            //Assert.IsType<DatiBeniServizi>(instance);
        }

        /// <summary>
        /// Test the property 'DettaglioLinee'
        /// </summary>
        [Fact]
        public void DettaglioLineeTest()
        {
            // TODO unit test for the property 'DettaglioLinee'
        }

        /// <summary>
        /// Test the property 'DatiRiepilogo'
        /// </summary>
        [Fact]
        public void DatiRiepilogoTest()
        {
            // TODO unit test for the property 'DatiRiepilogo'
        }
    }
}
