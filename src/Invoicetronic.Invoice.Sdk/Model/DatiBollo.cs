/*
 * Italian eInvoice API
 *
 * The Italian eInvoice API is a RESTful API that allows you to send and receive invoices through the Italian [Servizio di Interscambio (SDI)][1], or Interchange Service. The API is designed by Invoicetronic to be simple and easy to use, abstracting away SDI complexity while providing complete control over the invoice send/receive process. The API also provides advanced features as encryption at rest, invoice validation, multiple upload formats, webhooks, event logging, client SDKs for commonly used languages, and CLI tools.  For more information, see  [Invoicetronic website][2]  [1]: https://www.fatturapa.gov.it/it/sistemainterscambio/cose-il-sdi/ [2]: https://invoicetronic.com/
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: support@invoicetronic.com
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
using OpenAPIDateConverter = Invoicetronic.Invoice.Sdk.Client.OpenAPIDateConverter;

namespace Invoicetronic.Invoice.Sdk.Model
{
    /// <summary>
    /// DatiBollo
    /// </summary>
    [DataContract(Name = "DatiBollo")]
    public partial class DatiBollo : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatiBollo" /> class.
        /// </summary>
        /// <param name="bolloVirtuale">bolloVirtuale.</param>
        /// <param name="importoBollo">importoBollo.</param>
        public DatiBollo(string bolloVirtuale = default(string), double? importoBollo = default(double?))
        {
            this.BolloVirtuale = bolloVirtuale;
            this.ImportoBollo = importoBollo;
        }

        /// <summary>
        /// Gets or Sets BolloVirtuale
        /// </summary>
        [DataMember(Name = "bollo_virtuale", EmitDefaultValue = true)]
        public string BolloVirtuale { get; set; }

        /// <summary>
        /// Gets or Sets ImportoBollo
        /// </summary>
        [DataMember(Name = "importo_bollo", EmitDefaultValue = true)]
        public double? ImportoBollo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DatiBollo {\n");
            sb.Append("  BolloVirtuale: ").Append(BolloVirtuale).Append("\n");
            sb.Append("  ImportoBollo: ").Append(ImportoBollo).Append("\n");
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
