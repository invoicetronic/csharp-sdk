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
    ///  Class for testing Event
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class EventTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for Event
        //private Event instance;

        public EventTests()
        {
            // TODO uncomment below to create an instance of Event
            //instance = new Event();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Event
        /// </summary>
        [Fact]
        public void EventInstanceTest()
        {
            // TODO uncomment below to test "IsType" Event
            //Assert.IsType<Event>(instance);
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
        /// Test the property 'CompanyId'
        /// </summary>
        [Fact]
        public void CompanyIdTest()
        {
            // TODO unit test for the property 'CompanyId'
        }

        /// <summary>
        /// Test the property 'Method'
        /// </summary>
        [Fact]
        public void MethodTest()
        {
            // TODO unit test for the property 'Method'
        }

        /// <summary>
        /// Test the property 'Query'
        /// </summary>
        [Fact]
        public void QueryTest()
        {
            // TODO unit test for the property 'Query'
        }

        /// <summary>
        /// Test the property 'Endpoint'
        /// </summary>
        [Fact]
        public void EndpointTest()
        {
            // TODO unit test for the property 'Endpoint'
        }

        /// <summary>
        /// Test the property 'ApiVersion'
        /// </summary>
        [Fact]
        public void ApiVersionTest()
        {
            // TODO unit test for the property 'ApiVersion'
        }

        /// <summary>
        /// Test the property 'StatusCode'
        /// </summary>
        [Fact]
        public void StatusCodeTest()
        {
            // TODO unit test for the property 'StatusCode'
        }

        /// <summary>
        /// Test the property 'DateTime'
        /// </summary>
        [Fact]
        public void DateTimeTest()
        {
            // TODO unit test for the property 'DateTime'
        }

        /// <summary>
        /// Test the property 'Error'
        /// </summary>
        [Fact]
        public void ErrorTest()
        {
            // TODO unit test for the property 'Error'
        }

        /// <summary>
        /// Test the property 'RequestBody'
        /// </summary>
        [Fact]
        public void RequestBodyTest()
        {
            // TODO unit test for the property 'RequestBody'
        }

        /// <summary>
        /// Test the property 'ResponseBody'
        /// </summary>
        [Fact]
        public void ResponseBodyTest()
        {
            // TODO unit test for the property 'ResponseBody'
        }

        /// <summary>
        /// Test the property 'Success'
        /// </summary>
        [Fact]
        public void SuccessTest()
        {
            // TODO unit test for the property 'Success'
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
        /// Test the property 'ApiKeyId'
        /// </summary>
        [Fact]
        public void ApiKeyIdTest()
        {
            // TODO unit test for the property 'ApiKeyId'
        }
    }
}
