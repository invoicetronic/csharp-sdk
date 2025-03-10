// <auto-generated>
/*
 * Invoicetronic API
 *
 * The [Invoicetronic API][2] is a RESTful service that allows you to send and receive invoices through the Italian [Servizio di Interscambio (SDI)][1], or Interchange Service. The API is designed to be simple and easy to use, abstracting away SDI complexity while providing complete control over the invoice send/receive process. It provides advanced features as encryption at rest, multi-language pre-flight invoice validation, multiple upload formats, webhooks, event logging, client SDKs, and CLI tools.  For more information, see  [Invoicetronic website][2]  [1]: https://www.fatturapa.gov.it/it/sistemainterscambio/cose-il-sdi/ [2]: https://invoicetronic.com/
 *
 * The version of the OpenAPI document: 1
 * Contact: support@invoicetronic.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


namespace Invoicetronic.Sdk.Client
{
    /// <summary>
    /// A wrapper for operation parameters which are not required
    /// </summary>
    public struct Option<TType>
    {
        /// <summary>
        /// The value to send to the server
        /// </summary>
        public TType Value { get; }

        /// <summary>
        /// When true the value will be sent to the server
        /// </summary>
        internal bool IsSet { get; }

        /// <summary>
        /// A wrapper for operation parameters which are not required
        /// </summary>
        /// <param name="value"></param>
        public Option(TType value)
        {
            IsSet = true;
            Value = value;
        }

        /// <summary>
        /// Implicitly converts this option to the contained type
        /// </summary>
        /// <param name="option"></param>
        public static implicit operator TType(Option<TType> option) => option.Value;

        /// <summary>
        /// Implicitly converts the provided value to an Option
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator Option<TType>(TType value) => new Option<TType>(value);
    }
}