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
    /// DatiCassaPrevidenziale
    /// </summary>
    [DataContract(Name = "DatiCassaPrevidenziale")]
    public partial class DatiCassaPrevidenziale : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatiCassaPrevidenziale" /> class.
        /// </summary>
        /// <param name="tipoCassa">tipoCassa.</param>
        /// <param name="alCassa">alCassa.</param>
        /// <param name="importoContributoCassa">importoContributoCassa.</param>
        /// <param name="imponibileCassa">imponibileCassa.</param>
        /// <param name="aliquotaIva">aliquotaIva.</param>
        /// <param name="ritenuta">ritenuta.</param>
        /// <param name="natura">natura.</param>
        /// <param name="riferimentoAmministrazione">riferimentoAmministrazione.</param>
        public DatiCassaPrevidenziale(string tipoCassa = default(string), double alCassa = default(double), double importoContributoCassa = default(double), double imponibileCassa = default(double), double aliquotaIva = default(double), string ritenuta = default(string), string natura = default(string), string riferimentoAmministrazione = default(string))
        {
            this.TipoCassa = tipoCassa;
            this.AlCassa = alCassa;
            this.ImportoContributoCassa = importoContributoCassa;
            this.ImponibileCassa = imponibileCassa;
            this.AliquotaIva = aliquotaIva;
            this.Ritenuta = ritenuta;
            this.Natura = natura;
            this.RiferimentoAmministrazione = riferimentoAmministrazione;
        }

        /// <summary>
        /// Gets or Sets TipoCassa
        /// </summary>
        [DataMember(Name = "tipo_cassa", EmitDefaultValue = true)]
        public string TipoCassa { get; set; }

        /// <summary>
        /// Gets or Sets AlCassa
        /// </summary>
        [DataMember(Name = "al_cassa", EmitDefaultValue = false)]
        public double AlCassa { get; set; }

        /// <summary>
        /// Gets or Sets ImportoContributoCassa
        /// </summary>
        [DataMember(Name = "importo_contributo_cassa", EmitDefaultValue = false)]
        public double ImportoContributoCassa { get; set; }

        /// <summary>
        /// Gets or Sets ImponibileCassa
        /// </summary>
        [DataMember(Name = "imponibile_cassa", EmitDefaultValue = false)]
        public double ImponibileCassa { get; set; }

        /// <summary>
        /// Gets or Sets AliquotaIva
        /// </summary>
        [DataMember(Name = "aliquota_iva", EmitDefaultValue = false)]
        public double AliquotaIva { get; set; }

        /// <summary>
        /// Gets or Sets Ritenuta
        /// </summary>
        [DataMember(Name = "ritenuta", EmitDefaultValue = true)]
        public string Ritenuta { get; set; }

        /// <summary>
        /// Gets or Sets Natura
        /// </summary>
        [DataMember(Name = "natura", EmitDefaultValue = true)]
        public string Natura { get; set; }

        /// <summary>
        /// Gets or Sets RiferimentoAmministrazione
        /// </summary>
        [DataMember(Name = "riferimento_amministrazione", EmitDefaultValue = true)]
        public string RiferimentoAmministrazione { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DatiCassaPrevidenziale {\n");
            sb.Append("  TipoCassa: ").Append(TipoCassa).Append("\n");
            sb.Append("  AlCassa: ").Append(AlCassa).Append("\n");
            sb.Append("  ImportoContributoCassa: ").Append(ImportoContributoCassa).Append("\n");
            sb.Append("  ImponibileCassa: ").Append(ImponibileCassa).Append("\n");
            sb.Append("  AliquotaIva: ").Append(AliquotaIva).Append("\n");
            sb.Append("  Ritenuta: ").Append(Ritenuta).Append("\n");
            sb.Append("  Natura: ").Append(Natura).Append("\n");
            sb.Append("  RiferimentoAmministrazione: ").Append(RiferimentoAmministrazione).Append("\n");
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
