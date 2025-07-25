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
    /// FatturaElettronicaHeader
    /// </summary>
    [DataContract(Name = "FatturaElettronicaHeader")]
    public partial class FatturaElettronicaHeader : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FatturaElettronicaHeader" /> class.
        /// </summary>
        /// <param name="datiTrasmissione">datiTrasmissione.</param>
        /// <param name="cedentePrestatore">cedentePrestatore.</param>
        /// <param name="rappresentanteFiscale">rappresentanteFiscale.</param>
        /// <param name="cessionarioCommittente">cessionarioCommittente.</param>
        /// <param name="terzoIntermediarioOSoggettoEmittente">terzoIntermediarioOSoggettoEmittente.</param>
        /// <param name="soggettoEmittente">soggettoEmittente.</param>
        public FatturaElettronicaHeader(DatiTrasmissione datiTrasmissione = default, CedentePrestatore cedentePrestatore = default, RappresentanteFiscale rappresentanteFiscale = default, CessionarioCommittente cessionarioCommittente = default, TerzoIntermediarioOSoggettoEmittente terzoIntermediarioOSoggettoEmittente = default, string soggettoEmittente = default)
        {
            this.DatiTrasmissione = datiTrasmissione;
            this.CedentePrestatore = cedentePrestatore;
            this.RappresentanteFiscale = rappresentanteFiscale;
            this.CessionarioCommittente = cessionarioCommittente;
            this.TerzoIntermediarioOSoggettoEmittente = terzoIntermediarioOSoggettoEmittente;
            this.SoggettoEmittente = soggettoEmittente;
        }

        /// <summary>
        /// Gets or Sets DatiTrasmissione
        /// </summary>
        [DataMember(Name = "dati_trasmissione", EmitDefaultValue = false)]
        public DatiTrasmissione DatiTrasmissione { get; set; }

        /// <summary>
        /// Gets or Sets CedentePrestatore
        /// </summary>
        [DataMember(Name = "cedente_prestatore", EmitDefaultValue = false)]
        public CedentePrestatore CedentePrestatore { get; set; }

        /// <summary>
        /// Gets or Sets RappresentanteFiscale
        /// </summary>
        [DataMember(Name = "RappresentanteFiscale", EmitDefaultValue = false)]
        public RappresentanteFiscale RappresentanteFiscale { get; set; }

        /// <summary>
        /// Gets or Sets CessionarioCommittente
        /// </summary>
        [DataMember(Name = "cessionario_committente", EmitDefaultValue = false)]
        public CessionarioCommittente CessionarioCommittente { get; set; }

        /// <summary>
        /// Gets or Sets TerzoIntermediarioOSoggettoEmittente
        /// </summary>
        [DataMember(Name = "terzo_intermediario_o_soggetto_emittente", EmitDefaultValue = false)]
        public TerzoIntermediarioOSoggettoEmittente TerzoIntermediarioOSoggettoEmittente { get; set; }

        /// <summary>
        /// Gets or Sets SoggettoEmittente
        /// </summary>
        [DataMember(Name = "soggetto_emittente", EmitDefaultValue = true)]
        public string SoggettoEmittente { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FatturaElettronicaHeader {\n");
            sb.Append("  DatiTrasmissione: ").Append(DatiTrasmissione).Append("\n");
            sb.Append("  CedentePrestatore: ").Append(CedentePrestatore).Append("\n");
            sb.Append("  RappresentanteFiscale: ").Append(RappresentanteFiscale).Append("\n");
            sb.Append("  CessionarioCommittente: ").Append(CessionarioCommittente).Append("\n");
            sb.Append("  TerzoIntermediarioOSoggettoEmittente: ").Append(TerzoIntermediarioOSoggettoEmittente).Append("\n");
            sb.Append("  SoggettoEmittente: ").Append(SoggettoEmittente).Append("\n");
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
