/*
 * Italian Invoice API
 *
 *  ## Overview  The Invoice API is a RESTful API that allows you to send and receive invoices through the Italian Servizio di Interscambio (Interchange Service).  ### Authentication  The Invoicetronic API uses API keys to authenticate requests. If you don't have any API Key, you can request one by registering with the [Invoicetronic Developer Portal][1].  Test mode secret keys have the prefix `ik_test_` and live mode secret keys have the prefix `ik_live_`. Make sure to use the correct key for each environment.  > Your API keys carry many privileges, so be sure to keep them secure! Do not share your secret API keys in publicly > accessible areas such as GitHub, client-side code, and so forth.  All API requests must be made over HTTPS. Calls made over plain HTTP will fail. API requests without authentication will also fail.  #### Basic Authentication  Basic Authentication is how you authenticate with the API. Use your API Key as the username and leave the password empty. If your client does not allow empty passwords, you can use any value as the password. Here's an example of how to authenticate with Basic Authentication and curl:  ```curl curl https://api.invoicetronic.com/invoice/v1/send \\     -u ik_test_1234567890abcdefg:  # The colon prevents curl from asking for a password. ```  [1]: https://invoicetronic.com/
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
using OpenAPIDateConverter = Invoicetronic.InvoiceApi.Client.OpenAPIDateConverter;

namespace Invoicetronic.InvoiceApi.Model
{
    /// <summary>
    /// Allegati
    /// </summary>
    [DataContract(Name = "Allegati")]
    public partial class Allegati : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Allegati" /> class.
        /// </summary>
        /// <param name="nomeAttachment">nomeAttachment.</param>
        /// <param name="algoritmoCompressione">algoritmoCompressione.</param>
        /// <param name="formatoAttachment">formatoAttachment.</param>
        /// <param name="descrizioneAttachment">descrizioneAttachment.</param>
        /// <param name="attachment">attachment.</param>
        public Allegati(string nomeAttachment = default(string), string algoritmoCompressione = default(string), string formatoAttachment = default(string), string descrizioneAttachment = default(string), byte[] attachment = default(byte[]))
        {
            this.NomeAttachment = nomeAttachment;
            this.AlgoritmoCompressione = algoritmoCompressione;
            this.FormatoAttachment = formatoAttachment;
            this.DescrizioneAttachment = descrizioneAttachment;
            this.Attachment = attachment;
        }

        /// <summary>
        /// Gets or Sets NomeAttachment
        /// </summary>
        [DataMember(Name = "nome_attachment", EmitDefaultValue = true)]
        public string NomeAttachment { get; set; }

        /// <summary>
        /// Gets or Sets AlgoritmoCompressione
        /// </summary>
        [DataMember(Name = "algoritmo_compressione", EmitDefaultValue = true)]
        public string AlgoritmoCompressione { get; set; }

        /// <summary>
        /// Gets or Sets FormatoAttachment
        /// </summary>
        [DataMember(Name = "formato_attachment", EmitDefaultValue = true)]
        public string FormatoAttachment { get; set; }

        /// <summary>
        /// Gets or Sets DescrizioneAttachment
        /// </summary>
        [DataMember(Name = "descrizione_attachment", EmitDefaultValue = true)]
        public string DescrizioneAttachment { get; set; }

        /// <summary>
        /// Gets or Sets Attachment
        /// </summary>
        [DataMember(Name = "attachment", EmitDefaultValue = true)]
        public byte[] Attachment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Allegati {\n");
            sb.Append("  NomeAttachment: ").Append(NomeAttachment).Append("\n");
            sb.Append("  AlgoritmoCompressione: ").Append(AlgoritmoCompressione).Append("\n");
            sb.Append("  FormatoAttachment: ").Append(FormatoAttachment).Append("\n");
            sb.Append("  DescrizioneAttachment: ").Append(DescrizioneAttachment).Append("\n");
            sb.Append("  Attachment: ").Append(Attachment).Append("\n");
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
