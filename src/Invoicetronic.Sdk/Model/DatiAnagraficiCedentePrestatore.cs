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
    /// DatiAnagraficiCedentePrestatore
    /// </summary>
    [DataContract(Name = "DatiAnagraficiCedentePrestatore")]
    public partial class DatiAnagraficiCedentePrestatore : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatiAnagraficiCedentePrestatore" /> class.
        /// </summary>
        /// <param name="idFiscaleIva">idFiscaleIva.</param>
        /// <param name="codiceFiscale">codiceFiscale.</param>
        /// <param name="anagrafica">anagrafica.</param>
        /// <param name="alboProfessionale">alboProfessionale.</param>
        /// <param name="provinciaAlbo">provinciaAlbo.</param>
        /// <param name="numeroIscrizioneAlbo">numeroIscrizioneAlbo.</param>
        /// <param name="dataIscrizioneAlbo">dataIscrizioneAlbo.</param>
        /// <param name="regimeFiscale">regimeFiscale.</param>
        public DatiAnagraficiCedentePrestatore(IdFiscaleIVA idFiscaleIva = default, string codiceFiscale = default, Anagrafica anagrafica = default, string alboProfessionale = default, string provinciaAlbo = default, string numeroIscrizioneAlbo = default, DateTime? dataIscrizioneAlbo = default, string regimeFiscale = default)
        {
            this.IdFiscaleIva = idFiscaleIva;
            this.CodiceFiscale = codiceFiscale;
            this.Anagrafica = anagrafica;
            this.AlboProfessionale = alboProfessionale;
            this.ProvinciaAlbo = provinciaAlbo;
            this.NumeroIscrizioneAlbo = numeroIscrizioneAlbo;
            this.DataIscrizioneAlbo = dataIscrizioneAlbo;
            this.RegimeFiscale = regimeFiscale;
        }

        /// <summary>
        /// Gets or Sets IdFiscaleIva
        /// </summary>
        [DataMember(Name = "id_fiscale_iva", EmitDefaultValue = false)]
        public IdFiscaleIVA IdFiscaleIva { get; set; }

        /// <summary>
        /// Gets or Sets CodiceFiscale
        /// </summary>
        [DataMember(Name = "codice_fiscale", EmitDefaultValue = true)]
        public string CodiceFiscale { get; set; }

        /// <summary>
        /// Gets or Sets Anagrafica
        /// </summary>
        [DataMember(Name = "anagrafica", EmitDefaultValue = false)]
        public Anagrafica Anagrafica { get; set; }

        /// <summary>
        /// Gets or Sets AlboProfessionale
        /// </summary>
        [DataMember(Name = "albo_professionale", EmitDefaultValue = true)]
        public string AlboProfessionale { get; set; }

        /// <summary>
        /// Gets or Sets ProvinciaAlbo
        /// </summary>
        [DataMember(Name = "provincia_albo", EmitDefaultValue = true)]
        public string ProvinciaAlbo { get; set; }

        /// <summary>
        /// Gets or Sets NumeroIscrizioneAlbo
        /// </summary>
        [DataMember(Name = "numero_iscrizione_albo", EmitDefaultValue = true)]
        public string NumeroIscrizioneAlbo { get; set; }

        /// <summary>
        /// Gets or Sets DataIscrizioneAlbo
        /// </summary>
        [DataMember(Name = "data_iscrizione_albo", EmitDefaultValue = true)]
        public DateTime? DataIscrizioneAlbo { get; set; }

        /// <summary>
        /// Gets or Sets RegimeFiscale
        /// </summary>
        [DataMember(Name = "regime_fiscale", EmitDefaultValue = true)]
        public string RegimeFiscale { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DatiAnagraficiCedentePrestatore {\n");
            sb.Append("  IdFiscaleIva: ").Append(IdFiscaleIva).Append("\n");
            sb.Append("  CodiceFiscale: ").Append(CodiceFiscale).Append("\n");
            sb.Append("  Anagrafica: ").Append(Anagrafica).Append("\n");
            sb.Append("  AlboProfessionale: ").Append(AlboProfessionale).Append("\n");
            sb.Append("  ProvinciaAlbo: ").Append(ProvinciaAlbo).Append("\n");
            sb.Append("  NumeroIscrizioneAlbo: ").Append(NumeroIscrizioneAlbo).Append("\n");
            sb.Append("  DataIscrizioneAlbo: ").Append(DataIscrizioneAlbo).Append("\n");
            sb.Append("  RegimeFiscale: ").Append(RegimeFiscale).Append("\n");
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
