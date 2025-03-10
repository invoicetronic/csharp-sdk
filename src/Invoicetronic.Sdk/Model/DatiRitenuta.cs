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
    /// DatiRitenuta
    /// </summary>
    public partial class DatiRitenuta : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatiRitenuta" /> class.
        /// </summary>
        /// <param name="tipoRitenuta">tipoRitenuta</param>
        /// <param name="importoRitenuta">importoRitenuta</param>
        /// <param name="aliquotaRitenuta">aliquotaRitenuta</param>
        /// <param name="causalePagamento">causalePagamento</param>
        [JsonConstructor]
        public DatiRitenuta(Option<string> tipoRitenuta = default, Option<double?> importoRitenuta = default, Option<double?> aliquotaRitenuta = default, Option<string> causalePagamento = default)
        {
            TipoRitenutaOption = tipoRitenuta;
            ImportoRitenutaOption = importoRitenuta;
            AliquotaRitenutaOption = aliquotaRitenuta;
            CausalePagamentoOption = causalePagamento;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of TipoRitenuta
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> TipoRitenutaOption { get; private set; }

        /// <summary>
        /// Gets or Sets TipoRitenuta
        /// </summary>
        [JsonPropertyName("tipo_ritenuta")]
        public string TipoRitenuta { get { return this.TipoRitenutaOption; } set { this.TipoRitenutaOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of ImportoRitenuta
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<double?> ImportoRitenutaOption { get; private set; }

        /// <summary>
        /// Gets or Sets ImportoRitenuta
        /// </summary>
        [JsonPropertyName("importo_ritenuta")]
        public double? ImportoRitenuta { get { return this.ImportoRitenutaOption; } set { this.ImportoRitenutaOption = new Option<double?>(value); } }

        /// <summary>
        /// Used to track the state of AliquotaRitenuta
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<double?> AliquotaRitenutaOption { get; private set; }

        /// <summary>
        /// Gets or Sets AliquotaRitenuta
        /// </summary>
        [JsonPropertyName("aliquota_ritenuta")]
        public double? AliquotaRitenuta { get { return this.AliquotaRitenutaOption; } set { this.AliquotaRitenutaOption = new Option<double?>(value); } }

        /// <summary>
        /// Used to track the state of CausalePagamento
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> CausalePagamentoOption { get; private set; }

        /// <summary>
        /// Gets or Sets CausalePagamento
        /// </summary>
        [JsonPropertyName("causale_pagamento")]
        public string CausalePagamento { get { return this.CausalePagamentoOption; } set { this.CausalePagamentoOption = new Option<string>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DatiRitenuta {\n");
            sb.Append("  TipoRitenuta: ").Append(TipoRitenuta).Append("\n");
            sb.Append("  ImportoRitenuta: ").Append(ImportoRitenuta).Append("\n");
            sb.Append("  AliquotaRitenuta: ").Append(AliquotaRitenuta).Append("\n");
            sb.Append("  CausalePagamento: ").Append(CausalePagamento).Append("\n");
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
    /// A Json converter for type <see cref="DatiRitenuta" />
    /// </summary>
    public class DatiRitenutaJsonConverter : JsonConverter<DatiRitenuta>
    {
        /// <summary>
        /// Deserializes json to <see cref="DatiRitenuta" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override DatiRitenuta Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> tipoRitenuta = default;
            Option<double?> importoRitenuta = default;
            Option<double?> aliquotaRitenuta = default;
            Option<string> causalePagamento = default;

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
                        case "tipo_ritenuta":
                            tipoRitenuta = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "importo_ritenuta":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                importoRitenuta = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "aliquota_ritenuta":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                aliquotaRitenuta = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "causale_pagamento":
                            causalePagamento = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (importoRitenuta.IsSet && importoRitenuta.Value == null)
                throw new ArgumentNullException(nameof(importoRitenuta), "Property is not nullable for class DatiRitenuta.");

            if (aliquotaRitenuta.IsSet && aliquotaRitenuta.Value == null)
                throw new ArgumentNullException(nameof(aliquotaRitenuta), "Property is not nullable for class DatiRitenuta.");

            return new DatiRitenuta(tipoRitenuta, importoRitenuta, aliquotaRitenuta, causalePagamento);
        }

        /// <summary>
        /// Serializes a <see cref="DatiRitenuta" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="datiRitenuta"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, DatiRitenuta datiRitenuta, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, datiRitenuta, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="DatiRitenuta" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="datiRitenuta"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, DatiRitenuta datiRitenuta, JsonSerializerOptions jsonSerializerOptions)
        {
            if (datiRitenuta.TipoRitenutaOption.IsSet)
                if (datiRitenuta.TipoRitenutaOption.Value != null)
                    writer.WriteString("tipo_ritenuta", datiRitenuta.TipoRitenuta);
                else
                    writer.WriteNull("tipo_ritenuta");

            if (datiRitenuta.ImportoRitenutaOption.IsSet)
                writer.WriteNumber("importo_ritenuta", datiRitenuta.ImportoRitenutaOption.Value.Value);

            if (datiRitenuta.AliquotaRitenutaOption.IsSet)
                writer.WriteNumber("aliquota_ritenuta", datiRitenuta.AliquotaRitenutaOption.Value.Value);

            if (datiRitenuta.CausalePagamentoOption.IsSet)
                if (datiRitenuta.CausalePagamentoOption.Value != null)
                    writer.WriteString("causale_pagamento", datiRitenuta.CausalePagamento);
                else
                    writer.WriteNull("causale_pagamento");
        }
    }
}
