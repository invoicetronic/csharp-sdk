/*
 * Invoicetronic API
 *
 * The [Invoicetronic API][2] is a RESTful service that allows you to send and receive invoices through the Italian [Servizio di Interscambio (SDI)][1], or Interchange Service. The API is designed to be simple and easy to use, abstracting away SDI complexity while providing complete control over the invoice send/receive process. It provides advanced features as encryption at rest, multi-language pre-flight invoice validation, multiple upload formats, webhooks, event logging, client SDKs, and CLI tools.  For more information, see  [Invoicetronic website][2]  [1]: https://www.fatturapa.gov.it/it/sistemainterscambio/cose-il-sdi/ [2]: https://invoicetronic.com/
 *
 * The version of the OpenAPI document: 1
 * Contact: support@invoicetronic.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using Microsoft.Extensions.Hosting;
using Invoicetronic.Sdk.Client;
using Invoicetronic.Sdk.Extensions;


/* *********************************************************************************
*              Follow these manual steps to construct tests.
*              This file will not be overwritten.
*  *********************************************************************************
* 1. Navigate to ApiTests.Base.cs and ensure any tokens are being created correctly.
*    Take care not to commit credentials to any repository.
*
* 2. Mocking is coordinated by ApiTestsBase#AddApiHttpClients.
*    To mock the client, use the generic AddApiHttpClients.
*    To mock the server, change the client's BaseAddress.
*
* 3. Locate the test you want below
*      - remove the skip property from the Fact attribute
*      - set the value of any variables if necessary
*
* 4. Run the tests and ensure they work.
*
*/


namespace Invoicetronic.Sdk.Test.Api
{
    /// <summary>
    ///  Base class for API tests
    /// </summary>
    public class ApiTestsBase
    {
        protected readonly IHost _host;

        public ApiTestsBase(string[] args)
        {
            _host = CreateHostBuilder(args).Build();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) => Host.CreateDefaultBuilder(args)
            .ConfigureApi((context, services, options) =>
            {
                string basicTokenUsername1 = context.Configuration["<username>"] ?? throw new Exception("Username not found.");
                string basicTokenPassword1 = context.Configuration["<password>"] ?? throw new Exception("Password not found.");
                BasicToken basicToken1 = new BasicToken(basicTokenUsername1, basicTokenPassword1, timeout: TimeSpan.FromSeconds(1));
                options.AddTokens(basicToken1);
            });
    }
}
