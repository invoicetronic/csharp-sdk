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
    /// ScontoMaggiorazione
    /// </summary>
    public partial class ScontoMaggiorazione : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScontoMaggiorazione" /> class.
        /// </summary>
        /// <param name="tipo">tipo</param>
        /// <param name="percentuale">percentuale</param>
        /// <param name="importo">importo</param>
        [JsonConstructor]
        public ScontoMaggiorazione(Option<string> tipo = default, Option<double?> percentuale = default, Option<double?> importo = default)
        {
            TipoOption = tipo;
            PercentualeOption = percentuale;
            ImportoOption = importo;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Tipo
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> TipoOption { get; private set; }

        /// <summary>
        /// Gets or Sets Tipo
        /// </summary>
        [JsonPropertyName("tipo")]
        public string Tipo { get { return this.TipoOption; } set { this.TipoOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Percentuale
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<double?> PercentualeOption { get; private set; }

        /// <summary>
        /// Gets or Sets Percentuale
        /// </summary>
        [JsonPropertyName("percentuale")]
        public double? Percentuale { get { return this.PercentualeOption; } set { this.PercentualeOption = new Option<double?>(value); } }

        /// <summary>
        /// Used to track the state of Importo
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<double?> ImportoOption { get; private set; }

        /// <summary>
        /// Gets or Sets Importo
        /// </summary>
        [JsonPropertyName("importo")]
        public double? Importo { get { return this.ImportoOption; } set { this.ImportoOption = new Option<double?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ScontoMaggiorazione {\n");
            sb.Append("  Tipo: ").Append(Tipo).Append("\n");
            sb.Append("  Percentuale: ").Append(Percentuale).Append("\n");
            sb.Append("  Importo: ").Append(Importo).Append("\n");
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
    /// A Json converter for type <see cref="ScontoMaggiorazione" />
    /// </summary>
    public class ScontoMaggiorazioneJsonConverter : JsonConverter<ScontoMaggiorazione>
    {
        /// <summary>
        /// Deserializes json to <see cref="ScontoMaggiorazione" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ScontoMaggiorazione Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> tipo = default;
            Option<double?> percentuale = default;
            Option<double?> importo = default;

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
                        case "tipo":
                            tipo = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "percentuale":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                percentuale = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "importo":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                importo = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        default:
                            break;
                    }
                }
            }

            return new ScontoMaggiorazione(tipo, percentuale, importo);
        }

        /// <summary>
        /// Serializes a <see cref="ScontoMaggiorazione" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="scontoMaggiorazione"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ScontoMaggiorazione scontoMaggiorazione, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, scontoMaggiorazione, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="ScontoMaggiorazione" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="scontoMaggiorazione"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, ScontoMaggiorazione scontoMaggiorazione, JsonSerializerOptions jsonSerializerOptions)
        {
            if (scontoMaggiorazione.TipoOption.IsSet)
                if (scontoMaggiorazione.TipoOption.Value != null)
                    writer.WriteString("tipo", scontoMaggiorazione.Tipo);
                else
                    writer.WriteNull("tipo");

            if (scontoMaggiorazione.PercentualeOption.IsSet)
                if (scontoMaggiorazione.PercentualeOption.Value != null)
                    writer.WriteNumber("percentuale", scontoMaggiorazione.PercentualeOption.Value.Value);
                else
                    writer.WriteNull("percentuale");

            if (scontoMaggiorazione.ImportoOption.IsSet)
                if (scontoMaggiorazione.ImportoOption.Value != null)
                    writer.WriteNumber("importo", scontoMaggiorazione.ImportoOption.Value.Value);
                else
                    writer.WriteNull("importo");
        }
    }
}
