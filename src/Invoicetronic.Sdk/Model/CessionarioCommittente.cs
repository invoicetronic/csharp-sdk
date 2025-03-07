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

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using Invoicetronic.Sdk.Client;

namespace Invoicetronic.Sdk.Model
{
    /// <summary>
    /// CessionarioCommittente
    /// </summary>
    public partial class CessionarioCommittente : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CessionarioCommittente" /> class.
        /// </summary>
        /// <param name="datiAnagrafici">datiAnagrafici</param>
        /// <param name="sede">sede</param>
        /// <param name="stabileOrganizzazione">stabileOrganizzazione</param>
        /// <param name="rappresentanteFiscale">rappresentanteFiscale</param>
        [JsonConstructor]
        public CessionarioCommittente(Option<DatiAnagraficiCessionarioCommittente> datiAnagrafici = default, Option<SedeCessionarioCommittente> sede = default, Option<StabileOrganizzazione> stabileOrganizzazione = default, Option<RappresentanteFiscaleCessionarioCommittente> rappresentanteFiscale = default)
        {
            DatiAnagraficiOption = datiAnagrafici;
            SedeOption = sede;
            StabileOrganizzazioneOption = stabileOrganizzazione;
            RappresentanteFiscaleOption = rappresentanteFiscale;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of DatiAnagrafici
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DatiAnagraficiCessionarioCommittente> DatiAnagraficiOption { get; private set; }

        /// <summary>
        /// Gets or Sets DatiAnagrafici
        /// </summary>
        [JsonPropertyName("dati_anagrafici")]
        public DatiAnagraficiCessionarioCommittente DatiAnagrafici { get { return this.DatiAnagraficiOption; } set { this.DatiAnagraficiOption = new Option<DatiAnagraficiCessionarioCommittente>(value); } }

        /// <summary>
        /// Used to track the state of Sede
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<SedeCessionarioCommittente> SedeOption { get; private set; }

        /// <summary>
        /// Gets or Sets Sede
        /// </summary>
        [JsonPropertyName("sede")]
        public SedeCessionarioCommittente Sede { get { return this.SedeOption; } set { this.SedeOption = new Option<SedeCessionarioCommittente>(value); } }

        /// <summary>
        /// Used to track the state of StabileOrganizzazione
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<StabileOrganizzazione> StabileOrganizzazioneOption { get; private set; }

        /// <summary>
        /// Gets or Sets StabileOrganizzazione
        /// </summary>
        [JsonPropertyName("stabile_organizzazione")]
        public StabileOrganizzazione StabileOrganizzazione { get { return this.StabileOrganizzazioneOption; } set { this.StabileOrganizzazioneOption = new Option<StabileOrganizzazione>(value); } }

        /// <summary>
        /// Used to track the state of RappresentanteFiscale
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<RappresentanteFiscaleCessionarioCommittente> RappresentanteFiscaleOption { get; private set; }

        /// <summary>
        /// Gets or Sets RappresentanteFiscale
        /// </summary>
        [JsonPropertyName("rappresentante_fiscale")]
        public RappresentanteFiscaleCessionarioCommittente RappresentanteFiscale { get { return this.RappresentanteFiscaleOption; } set { this.RappresentanteFiscaleOption = new Option<RappresentanteFiscaleCessionarioCommittente>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CessionarioCommittente {\n");
            sb.Append("  DatiAnagrafici: ").Append(DatiAnagrafici).Append("\n");
            sb.Append("  Sede: ").Append(Sede).Append("\n");
            sb.Append("  StabileOrganizzazione: ").Append(StabileOrganizzazione).Append("\n");
            sb.Append("  RappresentanteFiscale: ").Append(RappresentanteFiscale).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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

    /// <summary>
    /// A Json converter for type <see cref="CessionarioCommittente" />
    /// </summary>
    public class CessionarioCommittenteJsonConverter : JsonConverter<CessionarioCommittente>
    {
        /// <summary>
        /// Deserializes json to <see cref="CessionarioCommittente" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override CessionarioCommittente Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<DatiAnagraficiCessionarioCommittente> datiAnagrafici = default;
            Option<SedeCessionarioCommittente> sede = default;
            Option<StabileOrganizzazione> stabileOrganizzazione = default;
            Option<RappresentanteFiscaleCessionarioCommittente> rappresentanteFiscale = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "dati_anagrafici":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                datiAnagrafici = new Option<DatiAnagraficiCessionarioCommittente>(JsonSerializer.Deserialize<DatiAnagraficiCessionarioCommittente>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "sede":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                sede = new Option<SedeCessionarioCommittente>(JsonSerializer.Deserialize<SedeCessionarioCommittente>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "stabile_organizzazione":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                stabileOrganizzazione = new Option<StabileOrganizzazione>(JsonSerializer.Deserialize<StabileOrganizzazione>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "rappresentante_fiscale":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                rappresentanteFiscale = new Option<RappresentanteFiscaleCessionarioCommittente>(JsonSerializer.Deserialize<RappresentanteFiscaleCessionarioCommittente>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (datiAnagrafici.IsSet && datiAnagrafici.Value == null)
                throw new ArgumentNullException(nameof(datiAnagrafici), "Property is not nullable for class CessionarioCommittente.");

            if (sede.IsSet && sede.Value == null)
                throw new ArgumentNullException(nameof(sede), "Property is not nullable for class CessionarioCommittente.");

            if (stabileOrganizzazione.IsSet && stabileOrganizzazione.Value == null)
                throw new ArgumentNullException(nameof(stabileOrganizzazione), "Property is not nullable for class CessionarioCommittente.");

            if (rappresentanteFiscale.IsSet && rappresentanteFiscale.Value == null)
                throw new ArgumentNullException(nameof(rappresentanteFiscale), "Property is not nullable for class CessionarioCommittente.");

            return new CessionarioCommittente(datiAnagrafici, sede, stabileOrganizzazione, rappresentanteFiscale);
        }

        /// <summary>
        /// Serializes a <see cref="CessionarioCommittente" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="cessionarioCommittente"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, CessionarioCommittente cessionarioCommittente, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, cessionarioCommittente, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="CessionarioCommittente" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="cessionarioCommittente"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, CessionarioCommittente cessionarioCommittente, JsonSerializerOptions jsonSerializerOptions)
        {
            if (cessionarioCommittente.DatiAnagraficiOption.IsSet && cessionarioCommittente.DatiAnagrafici == null)
                throw new ArgumentNullException(nameof(cessionarioCommittente.DatiAnagrafici), "Property is required for class CessionarioCommittente.");

            if (cessionarioCommittente.SedeOption.IsSet && cessionarioCommittente.Sede == null)
                throw new ArgumentNullException(nameof(cessionarioCommittente.Sede), "Property is required for class CessionarioCommittente.");

            if (cessionarioCommittente.StabileOrganizzazioneOption.IsSet && cessionarioCommittente.StabileOrganizzazione == null)
                throw new ArgumentNullException(nameof(cessionarioCommittente.StabileOrganizzazione), "Property is required for class CessionarioCommittente.");

            if (cessionarioCommittente.RappresentanteFiscaleOption.IsSet && cessionarioCommittente.RappresentanteFiscale == null)
                throw new ArgumentNullException(nameof(cessionarioCommittente.RappresentanteFiscale), "Property is required for class CessionarioCommittente.");

            if (cessionarioCommittente.DatiAnagraficiOption.IsSet)
            {
                writer.WritePropertyName("dati_anagrafici");
                JsonSerializer.Serialize(writer, cessionarioCommittente.DatiAnagrafici, jsonSerializerOptions);
            }
            if (cessionarioCommittente.SedeOption.IsSet)
            {
                writer.WritePropertyName("sede");
                JsonSerializer.Serialize(writer, cessionarioCommittente.Sede, jsonSerializerOptions);
            }
            if (cessionarioCommittente.StabileOrganizzazioneOption.IsSet)
            {
                writer.WritePropertyName("stabile_organizzazione");
                JsonSerializer.Serialize(writer, cessionarioCommittente.StabileOrganizzazione, jsonSerializerOptions);
            }
            if (cessionarioCommittente.RappresentanteFiscaleOption.IsSet)
            {
                writer.WritePropertyName("rappresentante_fiscale");
                JsonSerializer.Serialize(writer, cessionarioCommittente.RappresentanteFiscale, jsonSerializerOptions);
            }
        }
    }
}
