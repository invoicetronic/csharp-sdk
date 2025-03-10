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
    /// CodiceArticolo
    /// </summary>
    public partial class CodiceArticolo : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CodiceArticolo" /> class.
        /// </summary>
        /// <param name="codiceTipo">codiceTipo</param>
        /// <param name="codiceValore">codiceValore</param>
        [JsonConstructor]
        public CodiceArticolo(Option<string> codiceTipo = default, Option<string> codiceValore = default)
        {
            CodiceTipoOption = codiceTipo;
            CodiceValoreOption = codiceValore;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of CodiceTipo
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> CodiceTipoOption { get; private set; }

        /// <summary>
        /// Gets or Sets CodiceTipo
        /// </summary>
        [JsonPropertyName("codice_tipo")]
        public string CodiceTipo { get { return this.CodiceTipoOption; } set { this.CodiceTipoOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of CodiceValore
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> CodiceValoreOption { get; private set; }

        /// <summary>
        /// Gets or Sets CodiceValore
        /// </summary>
        [JsonPropertyName("codice_valore")]
        public string CodiceValore { get { return this.CodiceValoreOption; } set { this.CodiceValoreOption = new Option<string>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CodiceArticolo {\n");
            sb.Append("  CodiceTipo: ").Append(CodiceTipo).Append("\n");
            sb.Append("  CodiceValore: ").Append(CodiceValore).Append("\n");
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
    /// A Json converter for type <see cref="CodiceArticolo" />
    /// </summary>
    public class CodiceArticoloJsonConverter : JsonConverter<CodiceArticolo>
    {
        /// <summary>
        /// Deserializes json to <see cref="CodiceArticolo" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override CodiceArticolo Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> codiceTipo = default;
            Option<string> codiceValore = default;

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
                        case "codice_tipo":
                            codiceTipo = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "codice_valore":
                            codiceValore = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            return new CodiceArticolo(codiceTipo, codiceValore);
        }

        /// <summary>
        /// Serializes a <see cref="CodiceArticolo" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="codiceArticolo"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, CodiceArticolo codiceArticolo, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, codiceArticolo, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="CodiceArticolo" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="codiceArticolo"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, CodiceArticolo codiceArticolo, JsonSerializerOptions jsonSerializerOptions)
        {
            if (codiceArticolo.CodiceTipoOption.IsSet)
                if (codiceArticolo.CodiceTipoOption.Value != null)
                    writer.WriteString("codice_tipo", codiceArticolo.CodiceTipo);
                else
                    writer.WriteNull("codice_tipo");

            if (codiceArticolo.CodiceValoreOption.IsSet)
                if (codiceArticolo.CodiceValoreOption.Value != null)
                    writer.WriteString("codice_valore", codiceArticolo.CodiceValore);
                else
                    writer.WriteNull("codice_valore");
        }
    }
}
