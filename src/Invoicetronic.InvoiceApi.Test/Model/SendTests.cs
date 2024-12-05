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
    ///  Class for testing Send
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SendTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for Send
        //private Send instance;

        public SendTests()
        {
            // TODO uncomment below to create an instance of Send
            //instance = new Send();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Send
        /// </summary>
        [Fact]
        public void SendInstanceTest()
        {
            // TODO uncomment below to test "IsType" Send
            //Assert.IsType<Send>(instance);
        }

        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }

        /// <summary>
        /// Test the property 'Created'
        /// </summary>
        [Fact]
        public void CreatedTest()
        {
            // TODO unit test for the property 'Created'
        }

        /// <summary>
        /// Test the property 'VarVersion'
        /// </summary>
        [Fact]
        public void VarVersionTest()
        {
            // TODO unit test for the property 'VarVersion'
        }

        /// <summary>
        /// Test the property 'UserId'
        /// </summary>
        [Fact]
        public void UserIdTest()
        {
            // TODO unit test for the property 'UserId'
        }

        /// <summary>
        /// Test the property 'CompanyId'
        /// </summary>
        [Fact]
        public void CompanyIdTest()
        {
            // TODO unit test for the property 'CompanyId'
        }

        /// <summary>
        /// Test the property 'Committente'
        /// </summary>
        [Fact]
        public void CommittenteTest()
        {
            // TODO unit test for the property 'Committente'
        }

        /// <summary>
        /// Test the property 'Prestatore'
        /// </summary>
        [Fact]
        public void PrestatoreTest()
        {
            // TODO unit test for the property 'Prestatore'
        }

        /// <summary>
        /// Test the property 'Identifier'
        /// </summary>
        [Fact]
        public void IdentifierTest()
        {
            // TODO unit test for the property 'Identifier'
        }

        /// <summary>
        /// Test the property 'FileName'
        /// </summary>
        [Fact]
        public void FileNameTest()
        {
            // TODO unit test for the property 'FileName'
        }

        /// <summary>
        /// Test the property 'Format'
        /// </summary>
        [Fact]
        public void FormatTest()
        {
            // TODO unit test for the property 'Format'
        }

        /// <summary>
        /// Test the property 'Payload'
        /// </summary>
        [Fact]
        public void PayloadTest()
        {
            // TODO unit test for the property 'Payload'
        }

        /// <summary>
        /// Test the property 'LastUpdate'
        /// </summary>
        [Fact]
        public void LastUpdateTest()
        {
            // TODO unit test for the property 'LastUpdate'
        }

        /// <summary>
        /// Test the property 'DateSent'
        /// </summary>
        [Fact]
        public void DateSentTest()
        {
            // TODO unit test for the property 'DateSent'
        }

        /// <summary>
        /// Test the property 'Documents'
        /// </summary>
        [Fact]
        public void DocumentsTest()
        {
            // TODO unit test for the property 'Documents'
        }

        /// <summary>
        /// Test the property 'MetaData'
        /// </summary>
        [Fact]
        public void MetaDataTest()
        {
            // TODO unit test for the property 'MetaData'
        }
    }
}
