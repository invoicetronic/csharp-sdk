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
    /// SedeCessionarioCommittente
    /// </summary>
    public partial class SedeCessionarioCommittente : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SedeCessionarioCommittente" /> class.
        /// </summary>
        /// <param name="indirizzo">indirizzo</param>
        /// <param name="numeroCivico">numeroCivico</param>
        /// <param name="cap">cap</param>
        /// <param name="comune">comune</param>
        /// <param name="provincia">provincia</param>
        /// <param name="nazione">nazione (default to &quot;IT&quot;)</param>
        [JsonConstructor]
        public SedeCessionarioCommittente(Option<string> indirizzo = default, Option<string> numeroCivico = default, Option<string> cap = default, Option<string> comune = default, Option<string> provincia = default, Option<string> nazione = default)
        {
            IndirizzoOption = indirizzo;
            NumeroCivicoOption = numeroCivico;
            CapOption = cap;
            ComuneOption = comune;
            ProvinciaOption = provincia;
            NazioneOption = nazione;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Indirizzo
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> IndirizzoOption { get; private set; }

        /// <summary>
        /// Gets or Sets Indirizzo
        /// </summary>
        [JsonPropertyName("indirizzo")]
        public string Indirizzo { get { return this.IndirizzoOption; } set { this.IndirizzoOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of NumeroCivico
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> NumeroCivicoOption { get; private set; }

        /// <summary>
        /// Gets or Sets NumeroCivico
        /// </summary>
        [JsonPropertyName("numero_civico")]
        public string NumeroCivico { get { return this.NumeroCivicoOption; } set { this.NumeroCivicoOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Cap
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> CapOption { get; private set; }

        /// <summary>
        /// Gets or Sets Cap
        /// </summary>
        [JsonPropertyName("cap")]
        public string Cap { get { return this.CapOption; } set { this.CapOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Comune
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> ComuneOption { get; private set; }

        /// <summary>
        /// Gets or Sets Comune
        /// </summary>
        [JsonPropertyName("comune")]
        public string Comune { get { return this.ComuneOption; } set { this.ComuneOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Provincia
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> ProvinciaOption { get; private set; }

        /// <summary>
        /// Gets or Sets Provincia
        /// </summary>
        [JsonPropertyName("provincia")]
        public string Provincia { get { return this.ProvinciaOption; } set { this.ProvinciaOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Nazione
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> NazioneOption { get; private set; }

        /// <summary>
        /// Gets or Sets Nazione
        /// </summary>
        [JsonPropertyName("nazione")]
        public string Nazione { get { return this.NazioneOption; } set { this.NazioneOption = new Option<string>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SedeCessionarioCommittente {\n");
            sb.Append("  Indirizzo: ").Append(Indirizzo).Append("\n");
            sb.Append("  NumeroCivico: ").Append(NumeroCivico).Append("\n");
            sb.Append("  Cap: ").Append(Cap).Append("\n");
            sb.Append("  Comune: ").Append(Comune).Append("\n");
            sb.Append("  Provincia: ").Append(Provincia).Append("\n");
            sb.Append("  Nazione: ").Append(Nazione).Append("\n");
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
    /// A Json converter for type <see cref="SedeCessionarioCommittente" />
    /// </summary>
    public class SedeCessionarioCommittenteJsonConverter : JsonConverter<SedeCessionarioCommittente>
    {
        /// <summary>
        /// Deserializes json to <see cref="SedeCessionarioCommittente" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override SedeCessionarioCommittente Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> indirizzo = default;
            Option<string> numeroCivico = default;
            Option<string> cap = default;
            Option<string> comune = default;
            Option<string> provincia = default;
            Option<string> nazione = default;

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
                        case "indirizzo":
                            indirizzo = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "numero_civico":
                            numeroCivico = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "cap":
                            cap = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "comune":
                            comune = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "provincia":
                            provincia = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "nazione":
                            nazione = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            return new SedeCessionarioCommittente(indirizzo, numeroCivico, cap, comune, provincia, nazione);
        }

        /// <summary>
        /// Serializes a <see cref="SedeCessionarioCommittente" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="sedeCessionarioCommittente"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, SedeCessionarioCommittente sedeCessionarioCommittente, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, sedeCessionarioCommittente, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="SedeCessionarioCommittente" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="sedeCessionarioCommittente"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, SedeCessionarioCommittente sedeCessionarioCommittente, JsonSerializerOptions jsonSerializerOptions)
        {
            if (sedeCessionarioCommittente.IndirizzoOption.IsSet)
                if (sedeCessionarioCommittente.IndirizzoOption.Value != null)
                    writer.WriteString("indirizzo", sedeCessionarioCommittente.Indirizzo);
                else
                    writer.WriteNull("indirizzo");

            if (sedeCessionarioCommittente.NumeroCivicoOption.IsSet)
                if (sedeCessionarioCommittente.NumeroCivicoOption.Value != null)
                    writer.WriteString("numero_civico", sedeCessionarioCommittente.NumeroCivico);
                else
                    writer.WriteNull("numero_civico");

            if (sedeCessionarioCommittente.CapOption.IsSet)
                if (sedeCessionarioCommittente.CapOption.Value != null)
                    writer.WriteString("cap", sedeCessionarioCommittente.Cap);
                else
                    writer.WriteNull("cap");

            if (sedeCessionarioCommittente.ComuneOption.IsSet)
                if (sedeCessionarioCommittente.ComuneOption.Value != null)
                    writer.WriteString("comune", sedeCessionarioCommittente.Comune);
                else
                    writer.WriteNull("comune");

            if (sedeCessionarioCommittente.ProvinciaOption.IsSet)
                if (sedeCessionarioCommittente.ProvinciaOption.Value != null)
                    writer.WriteString("provincia", sedeCessionarioCommittente.Provincia);
                else
                    writer.WriteNull("provincia");

            if (sedeCessionarioCommittente.NazioneOption.IsSet)
                if (sedeCessionarioCommittente.NazioneOption.Value != null)
                    writer.WriteString("nazione", sedeCessionarioCommittente.Nazione);
                else
                    writer.WriteNull("nazione");
        }
    }
}
