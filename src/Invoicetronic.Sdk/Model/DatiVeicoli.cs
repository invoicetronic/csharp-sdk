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
    /// DatiVeicoli
    /// </summary>
    public partial class DatiVeicoli : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatiVeicoli" /> class.
        /// </summary>
        /// <param name="data">data</param>
        /// <param name="totalePercorso">totalePercorso</param>
        [JsonConstructor]
        public DatiVeicoli(Option<DateTime?> data = default, Option<string> totalePercorso = default)
        {
            DataOption = data;
            TotalePercorsoOption = totalePercorso;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Data
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> DataOption { get; private set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [JsonPropertyName("data")]
        public DateTime? Data { get { return this.DataOption; } set { this.DataOption = new Option<DateTime?>(value); } }

        /// <summary>
        /// Used to track the state of TotalePercorso
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> TotalePercorsoOption { get; private set; }

        /// <summary>
        /// Gets or Sets TotalePercorso
        /// </summary>
        [JsonPropertyName("totale_percorso")]
        public string TotalePercorso { get { return this.TotalePercorsoOption; } set { this.TotalePercorsoOption = new Option<string>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DatiVeicoli {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  TotalePercorso: ").Append(TotalePercorso).Append("\n");
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
    /// A Json converter for type <see cref="DatiVeicoli" />
    /// </summary>
    public class DatiVeicoliJsonConverter : JsonConverter<DatiVeicoli>
    {
        /// <summary>
        /// The format to use to serialize Data
        /// </summary>
        public static string DataFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="DatiVeicoli" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override DatiVeicoli Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<DateTime?> data = default;
            Option<string> totalePercorso = default;

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
                        case "data":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                data = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime?>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "totale_percorso":
                            totalePercorso = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            return new DatiVeicoli(data, totalePercorso);
        }

        /// <summary>
        /// Serializes a <see cref="DatiVeicoli" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="datiVeicoli"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, DatiVeicoli datiVeicoli, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, datiVeicoli, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="DatiVeicoli" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="datiVeicoli"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, DatiVeicoli datiVeicoli, JsonSerializerOptions jsonSerializerOptions)
        {
            if (datiVeicoli.DataOption.IsSet)
                if (datiVeicoli.DataOption.Value != null)
                    writer.WriteString("data", datiVeicoli.DataOption.Value.Value.ToString(DataFormat));
                else
                    writer.WriteNull("data");

            if (datiVeicoli.TotalePercorsoOption.IsSet)
                if (datiVeicoli.TotalePercorsoOption.Value != null)
                    writer.WriteString("totale_percorso", datiVeicoli.TotalePercorso);
                else
                    writer.WriteNull("totale_percorso");
        }
    }
}
