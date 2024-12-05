/*
 * Italian Invoice API
 *
 *  ## Overview  The Invoice API is a RESTful API that allows you to send and receive invoices through the Italian Servizio di Interscambio (Interchange Service).  ### Authentication  The Invoicetronic API uses API keys to authenticate requests. If you don't have any API Key, you can request one by registering with the [Invoicetronic Developer Portal][1].  Test mode secret keys have the prefix `ik_test_` and live mode secret keys have the prefix `ik_live_`. Make sure to use the correct key for each environment.  > Your API keys carry many privileges, so be sure to keep them secure! Do not share your secret API keys in publicly > accessible areas such as GitHub, client-side code, and so forth.  All API requests must be made over HTTPS. Calls made over plain HTTP will fail. API requests without authentication will also fail.  #### Basic Authentication  Basic Authentication is how you authenticate with the API. Use your API Key as the username and leave the password empty. If your client does not allow empty passwords, you can use any value as the password. Here's an example of how to authenticate with Basic Authentication and curl:  ```curl curl https://api.invoicetronic.com/invoice/v1/send \\     -u ik_test_1234567890abcdefg:  # The colon prevents curl from asking for a password. ```  [1]: https://invoicetronic.com/
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
using Invoicetronic.InvoiceApi.Model;
using Invoicetronic.InvoiceApi.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Invoicetronic.InvoiceApi.Test.Model
{
    /// <summary>
    ///  Class for testing FatturaElettronicaBody
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class FatturaElettronicaBodyTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for FatturaElettronicaBody
        //private FatturaElettronicaBody instance;

        public FatturaElettronicaBodyTests()
        {
            // TODO uncomment below to create an instance of FatturaElettronicaBody
            //instance = new FatturaElettronicaBody();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of FatturaElettronicaBody
        /// </summary>
        [Fact]
        public void FatturaElettronicaBodyInstanceTest()
        {
            // TODO uncomment below to test "IsType" FatturaElettronicaBody
            //Assert.IsType<FatturaElettronicaBody>(instance);
        }

        /// <summary>
        /// Test the property 'DatiGenerali'
        /// </summary>
        [Fact]
        public void DatiGeneraliTest()
        {
            // TODO unit test for the property 'DatiGenerali'
        }

        /// <summary>
        /// Test the property 'DatiBeniServizi'
        /// </summary>
        [Fact]
        public void DatiBeniServiziTest()
        {
            // TODO unit test for the property 'DatiBeniServizi'
        }

        /// <summary>
        /// Test the property 'DatiVeicoli'
        /// </summary>
        [Fact]
        public void DatiVeicoliTest()
        {
            // TODO unit test for the property 'DatiVeicoli'
        }

        /// <summary>
        /// Test the property 'DatiPagamento'
        /// </summary>
        [Fact]
        public void DatiPagamentoTest()
        {
            // TODO unit test for the property 'DatiPagamento'
        }

        /// <summary>
        /// Test the property 'Allegati'
        /// </summary>
        [Fact]
        public void AllegatiTest()
        {
            // TODO unit test for the property 'Allegati'
        }
    }
}
