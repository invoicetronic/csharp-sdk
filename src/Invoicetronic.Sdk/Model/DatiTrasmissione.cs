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
    /// DatiTrasmissione
    /// </summary>
    [DataContract(Name = "DatiTrasmissione")]
    public partial class DatiTrasmissione : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatiTrasmissione" /> class.
        /// </summary>
        /// <param name="idTrasmittente">idTrasmittente.</param>
        /// <param name="progressivoInvio">progressivoInvio.</param>
        /// <param name="formatoTrasmissione">formatoTrasmissione.</param>
        /// <param name="codiceDestinatario">codiceDestinatario.</param>
        /// <param name="contattiTrasmittente">contattiTrasmittente.</param>
        /// <param name="pecDestinatario">pecDestinatario.</param>
        public DatiTrasmissione(IdTrasmittente idTrasmittente = default, string progressivoInvio = default, string formatoTrasmissione = default, string codiceDestinatario = default, ContattiTrasmittente contattiTrasmittente = default, string pecDestinatario = default)
        {
            this.IdTrasmittente = idTrasmittente;
            this.ProgressivoInvio = progressivoInvio;
            this.FormatoTrasmissione = formatoTrasmissione;
            this.CodiceDestinatario = codiceDestinatario;
            this.ContattiTrasmittente = contattiTrasmittente;
            this.PecDestinatario = pecDestinatario;
        }

        /// <summary>
        /// Gets or Sets IdTrasmittente
        /// </summary>
        [DataMember(Name = "id_trasmittente", EmitDefaultValue = false)]
        public IdTrasmittente IdTrasmittente { get; set; }

        /// <summary>
        /// Gets or Sets ProgressivoInvio
        /// </summary>
        [DataMember(Name = "progressivo_invio", EmitDefaultValue = true)]
        public string ProgressivoInvio { get; set; }

        /// <summary>
        /// Gets or Sets FormatoTrasmissione
        /// </summary>
        [DataMember(Name = "formato_trasmissione", EmitDefaultValue = true)]
        public string FormatoTrasmissione { get; set; }

        /// <summary>
        /// Gets or Sets CodiceDestinatario
        /// </summary>
        [DataMember(Name = "codice_destinatario", EmitDefaultValue = true)]
        public string CodiceDestinatario { get; set; }

        /// <summary>
        /// Gets or Sets ContattiTrasmittente
        /// </summary>
        [DataMember(Name = "contatti_trasmittente", EmitDefaultValue = false)]
        public ContattiTrasmittente ContattiTrasmittente { get; set; }

        /// <summary>
        /// Gets or Sets PecDestinatario
        /// </summary>
        [DataMember(Name = "pec_destinatario", EmitDefaultValue = true)]
        public string PecDestinatario { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DatiTrasmissione {\n");
            sb.Append("  IdTrasmittente: ").Append(IdTrasmittente).Append("\n");
            sb.Append("  ProgressivoInvio: ").Append(ProgressivoInvio).Append("\n");
            sb.Append("  FormatoTrasmissione: ").Append(FormatoTrasmissione).Append("\n");
            sb.Append("  CodiceDestinatario: ").Append(CodiceDestinatario).Append("\n");
            sb.Append("  ContattiTrasmittente: ").Append(ContattiTrasmittente).Append("\n");
            sb.Append("  PecDestinatario: ").Append(PecDestinatario).Append("\n");
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
