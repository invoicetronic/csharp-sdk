/*
 * Invoicetronic API
 *
 * The [Invoicetronic API][2] is a RESTful service that allows you to send and receive invoices through the Italian [Servizio di Interscambio (SDI)][1], or Interchange Service. The API is designed to be simple and easy to use, abstracting away SDI complexity while providing complete control over the invoice send/receive process. It provides advanced features as encryption at rest, multi-language pre-flight invoice validation, multiple upload formats, webhooks, event logging, client SDKs, and CLI tools.  For more information, see  [Invoicetronic website][2]  [1]: https://www.fatturapa.gov.it/it/sistemainterscambio/cose-il-sdi/ [2]: https://invoicetronic.com/
 *
 * The version of the OpenAPI document: 1
 * Contact: info@invoicetronic.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = Invoicetronic.Sdk.Client.FileParameter;
using OpenAPIDateConverter = Invoicetronic.Sdk.Client.OpenAPIDateConverter;

namespace Invoicetronic.Sdk.Model
{
    /// <summary>
    /// FatturaPrincipale
    /// </summary>
    [DataContract(Name = "FatturaPrincipale")]
    public partial class FatturaPrincipale : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FatturaPrincipale" /> class.
        /// </summary>
        /// <param name="numeroFatturaPrincipale">numeroFatturaPrincipale.</param>
        /// <param name="dataFatturaPrincipale">dataFatturaPrincipale.</param>
        public FatturaPrincipale(string numeroFatturaPrincipale = default, DateTime? dataFatturaPrincipale = default)
        {
            this.NumeroFatturaPrincipale = numeroFatturaPrincipale;
            this.DataFatturaPrincipale = dataFatturaPrincipale;
        }

        /// <summary>
        /// Gets or Sets NumeroFatturaPrincipale
        /// </summary>
        [DataMember(Name = "numero_fattura_principale", EmitDefaultValue = true)]
        public string NumeroFatturaPrincipale { get; set; }

        /// <summary>
        /// Gets or Sets DataFatturaPrincipale
        /// </summary>
        [DataMember(Name = "data_fattura_principale", EmitDefaultValue = true)]
        public DateTime? DataFatturaPrincipale { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FatturaPrincipale {\n");
            sb.Append("  NumeroFatturaPrincipale: ").Append(NumeroFatturaPrincipale).Append("\n");
            sb.Append("  DataFatturaPrincipale: ").Append(DataFatturaPrincipale).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
