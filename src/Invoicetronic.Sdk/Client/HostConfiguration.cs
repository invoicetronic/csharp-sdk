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
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using Invoicetronic.Sdk.Api;
using Invoicetronic.Sdk.Model;

namespace Invoicetronic.Sdk.Client
{
    /// <summary>
    /// Provides hosting configuration for Invoicetronic.Sdk
    /// </summary>
    public class HostConfiguration
    {
        private readonly IServiceCollection _services;
        private readonly JsonSerializerOptions _jsonOptions = new JsonSerializerOptions();

        internal bool HttpClientsAdded { get; private set; }

        /// <summary>
        /// Instantiates the class 
        /// </summary>
        /// <param name="services"></param>
        public HostConfiguration(IServiceCollection services)
        {
            _services = services;
            _jsonOptions.Converters.Add(new JsonStringEnumConverter());
            _jsonOptions.Converters.Add(new DateTimeJsonConverter());
            _jsonOptions.Converters.Add(new DateTimeNullableJsonConverter());
            _jsonOptions.Converters.Add(new AllegatiJsonConverter());
            _jsonOptions.Converters.Add(new AltriDatiGestionaliJsonConverter());
            _jsonOptions.Converters.Add(new AnagraficaJsonConverter());
            _jsonOptions.Converters.Add(new CedentePrestatoreJsonConverter());
            _jsonOptions.Converters.Add(new CessionarioCommittenteJsonConverter());
            _jsonOptions.Converters.Add(new CodiceArticoloJsonConverter());
            _jsonOptions.Converters.Add(new CompanyJsonConverter());
            _jsonOptions.Converters.Add(new ContattiJsonConverter());
            _jsonOptions.Converters.Add(new ContattiTrasmittenteJsonConverter());
            _jsonOptions.Converters.Add(new DatiAnagraficiJsonConverter());
            _jsonOptions.Converters.Add(new DatiAnagraficiCedentePrestatoreJsonConverter());
            _jsonOptions.Converters.Add(new DatiAnagraficiCessionarioCommittenteJsonConverter());
            _jsonOptions.Converters.Add(new DatiAnagraficiVettoreJsonConverter());
            _jsonOptions.Converters.Add(new DatiBeniServiziJsonConverter());
            _jsonOptions.Converters.Add(new DatiBolloJsonConverter());
            _jsonOptions.Converters.Add(new DatiCassaPrevidenzialeJsonConverter());
            _jsonOptions.Converters.Add(new DatiContrattoJsonConverter());
            _jsonOptions.Converters.Add(new DatiConvenzioneJsonConverter());
            _jsonOptions.Converters.Add(new DatiDDTJsonConverter());
            _jsonOptions.Converters.Add(new DatiFattureCollegateJsonConverter());
            _jsonOptions.Converters.Add(new DatiGeneraliJsonConverter());
            _jsonOptions.Converters.Add(new DatiGeneraliDocumentoJsonConverter());
            _jsonOptions.Converters.Add(new DatiOrdineAcquistoJsonConverter());
            _jsonOptions.Converters.Add(new DatiPagamentoJsonConverter());
            _jsonOptions.Converters.Add(new DatiRicezioneJsonConverter());
            _jsonOptions.Converters.Add(new DatiRiepilogoJsonConverter());
            _jsonOptions.Converters.Add(new DatiRitenutaJsonConverter());
            _jsonOptions.Converters.Add(new DatiSALJsonConverter());
            _jsonOptions.Converters.Add(new DatiTrasmissioneJsonConverter());
            _jsonOptions.Converters.Add(new DatiTrasportoJsonConverter());
            _jsonOptions.Converters.Add(new DatiVeicoliJsonConverter());
            _jsonOptions.Converters.Add(new DettaglioLineeJsonConverter());
            _jsonOptions.Converters.Add(new DettaglioPagamentoJsonConverter());
            _jsonOptions.Converters.Add(new DocumentDataJsonConverter());
            _jsonOptions.Converters.Add(new ErrorJsonConverter());
            _jsonOptions.Converters.Add(new EventJsonConverter());
            _jsonOptions.Converters.Add(new FatturaElettronicaBodyJsonConverter());
            _jsonOptions.Converters.Add(new FatturaElettronicaHeaderJsonConverter());
            _jsonOptions.Converters.Add(new FatturaOrdinariaJsonConverter());
            _jsonOptions.Converters.Add(new FatturaPrincipaleJsonConverter());
            _jsonOptions.Converters.Add(new IdFiscaleIVAJsonConverter());
            _jsonOptions.Converters.Add(new IdTrasmittenteJsonConverter());
            _jsonOptions.Converters.Add(new IndirizzoResaJsonConverter());
            _jsonOptions.Converters.Add(new IscrizioneREAJsonConverter());
            _jsonOptions.Converters.Add(new ProblemDetailsJsonConverter());
            _jsonOptions.Converters.Add(new ProblemHttpResultJsonConverter());
            _jsonOptions.Converters.Add(new RappresentanteFiscaleJsonConverter());
            _jsonOptions.Converters.Add(new RappresentanteFiscaleCessionarioCommittenteJsonConverter());
            _jsonOptions.Converters.Add(new ReceiveJsonConverter());
            _jsonOptions.Converters.Add(new ScontoMaggiorazioneJsonConverter());
            _jsonOptions.Converters.Add(new SedeCedentePrestatoreJsonConverter());
            _jsonOptions.Converters.Add(new SedeCessionarioCommittenteJsonConverter());
            _jsonOptions.Converters.Add(new SendJsonConverter());
            _jsonOptions.Converters.Add(new StabileOrganizzazioneJsonConverter());
            _jsonOptions.Converters.Add(new StatusJsonConverter());
            _jsonOptions.Converters.Add(new TerzoIntermediarioOSoggettoEmittenteJsonConverter());
            _jsonOptions.Converters.Add(new UpdateJsonConverter());
            _jsonOptions.Converters.Add(new WebHookJsonConverter());
            _jsonOptions.Converters.Add(new WebHookHistoryJsonConverter());
            JsonSerializerOptionsProvider jsonSerializerOptionsProvider = new JsonSerializerOptionsProvider(_jsonOptions);
            _services.AddSingleton(jsonSerializerOptionsProvider);
            _services.AddSingleton<IApiFactory, ApiFactory>();
            _services.AddSingleton<CompanyApiEvents>();
            _services.AddTransient<ICompanyApi, CompanyApi>();
            _services.AddSingleton<LogApiEvents>();
            _services.AddTransient<ILogApi, LogApi>();
            _services.AddSingleton<ReceiveApiEvents>();
            _services.AddTransient<IReceiveApi, ReceiveApi>();
            _services.AddSingleton<SendApiEvents>();
            _services.AddTransient<ISendApi, SendApi>();
            _services.AddSingleton<StatusApiEvents>();
            _services.AddTransient<IStatusApi, StatusApi>();
            _services.AddSingleton<UpdateApiEvents>();
            _services.AddTransient<IUpdateApi, UpdateApi>();
            _services.AddSingleton<WebhookApiEvents>();
            _services.AddTransient<IWebhookApi, WebhookApi>();
        }

        /// <summary>
        /// Configures the HttpClients.
        /// </summary>
        /// <param name="client"></param>
        /// <param name="builder"></param>
        /// <returns></returns>
        public HostConfiguration AddApiHttpClients
        (
            Action<HttpClient> client = null, Action<IHttpClientBuilder> builder = null)
        {
            if (client == null)
                client = c => c.BaseAddress = new Uri(ClientUtils.BASE_ADDRESS);

            List<IHttpClientBuilder> builders = new List<IHttpClientBuilder>();

            builders.Add(_services.AddHttpClient<ICompanyApi, CompanyApi>(client));
            builders.Add(_services.AddHttpClient<ILogApi, LogApi>(client));
            builders.Add(_services.AddHttpClient<IReceiveApi, ReceiveApi>(client));
            builders.Add(_services.AddHttpClient<ISendApi, SendApi>(client));
            builders.Add(_services.AddHttpClient<IStatusApi, StatusApi>(client));
            builders.Add(_services.AddHttpClient<IUpdateApi, UpdateApi>(client));
            builders.Add(_services.AddHttpClient<IWebhookApi, WebhookApi>(client));
            
            if (builder != null)
                foreach (IHttpClientBuilder instance in builders)
                    builder(instance);

            HttpClientsAdded = true;

            return this;
        }

        /// <summary>
        /// Configures the JsonSerializerSettings
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public HostConfiguration ConfigureJsonOptions(Action<JsonSerializerOptions> options)
        {
            options(_jsonOptions);

            return this;
        }

        /// <summary>
        /// Adds tokens to your IServiceCollection
        /// </summary>
        /// <typeparam name="TTokenBase"></typeparam>
        /// <param name="token"></param>
        /// <returns></returns>
        public HostConfiguration AddTokens<TTokenBase>(TTokenBase token) where TTokenBase : TokenBase
        {
            return AddTokens(new TTokenBase[]{ token });
        }

        /// <summary>
        /// Adds tokens to your IServiceCollection
        /// </summary>
        /// <typeparam name="TTokenBase"></typeparam>
        /// <param name="tokens"></param>
        /// <returns></returns>
        public HostConfiguration AddTokens<TTokenBase>(IEnumerable<TTokenBase> tokens) where TTokenBase : TokenBase
        {
            TokenContainer<TTokenBase> container = new TokenContainer<TTokenBase>(tokens);
            _services.AddSingleton(services => container);

            return this;
        }

        /// <summary>
        /// Adds a token provider to your IServiceCollection
        /// </summary>
        /// <typeparam name="TTokenProvider"></typeparam>
        /// <typeparam name="TTokenBase"></typeparam>
        /// <returns></returns>
        public HostConfiguration UseProvider<TTokenProvider, TTokenBase>() 
            where TTokenProvider : TokenProvider<TTokenBase>
            where TTokenBase : TokenBase
        {
            _services.AddSingleton<TTokenProvider>();
            _services.AddSingleton<TokenProvider<TTokenBase>>(services => services.GetRequiredService<TTokenProvider>());

            return this;
        }
    }
}
