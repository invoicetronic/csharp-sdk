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
    /// FatturaElettronicaBody
    /// </summary>
    [DataContract(Name = "FatturaElettronicaBody")]
    public partial class FatturaElettronicaBody : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FatturaElettronicaBody" /> class.
        /// </summary>
        /// <param name="datiGenerali">datiGenerali.</param>
        /// <param name="datiBeniServizi">datiBeniServizi.</param>
        /// <param name="datiVeicoli">datiVeicoli.</param>
        /// <param name="datiPagamento">datiPagamento.</param>
        /// <param name="allegati">allegati.</param>
        public FatturaElettronicaBody(DatiGenerali datiGenerali = default, DatiBeniServizi datiBeniServizi = default, DatiVeicoli datiVeicoli = default, List<DatiPagamento> datiPagamento = default, List<Allegati> allegati = default)
        {
            this.DatiGenerali = datiGenerali;
            this.DatiBeniServizi = datiBeniServizi;
            this.DatiVeicoli = datiVeicoli;
            this.DatiPagamento = datiPagamento;
            this.Allegati = allegati;
        }

        /// <summary>
        /// Gets or Sets DatiGenerali
        /// </summary>
        [DataMember(Name = "dati_generali", EmitDefaultValue = false)]
        public DatiGenerali DatiGenerali { get; set; }

        /// <summary>
        /// Gets or Sets DatiBeniServizi
        /// </summary>
        [DataMember(Name = "dati_beni_servizi", EmitDefaultValue = false)]
        public DatiBeniServizi DatiBeniServizi { get; set; }

        /// <summary>
        /// Gets or Sets DatiVeicoli
        /// </summary>
        [DataMember(Name = "dati_veicoli", EmitDefaultValue = false)]
        public DatiVeicoli DatiVeicoli { get; set; }

        /// <summary>
        /// Gets or Sets DatiPagamento
        /// </summary>
        [DataMember(Name = "dati_pagamento", EmitDefaultValue = true)]
        public List<DatiPagamento> DatiPagamento { get; set; }

        /// <summary>
        /// Gets or Sets Allegati
        /// </summary>
        [DataMember(Name = "allegati", EmitDefaultValue = true)]
        public List<Allegati> Allegati { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FatturaElettronicaBody {\n");
            sb.Append("  DatiGenerali: ").Append(DatiGenerali).Append("\n");
            sb.Append("  DatiBeniServizi: ").Append(DatiBeniServizi).Append("\n");
            sb.Append("  DatiVeicoli: ").Append(DatiVeicoli).Append("\n");
            sb.Append("  DatiPagamento: ").Append(DatiPagamento).Append("\n");
            sb.Append("  Allegati: ").Append(Allegati).Append("\n");
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
