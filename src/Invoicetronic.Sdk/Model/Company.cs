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
    /// A company model.
    /// </summary>
    public partial class Company : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Company" /> class.
        /// </summary>
        /// <param name="vat">Vat number. Must include the country code.</param>
        /// <param name="fiscalCode">Fiscal code. In most cases it&#39;s the same as the vat number.</param>
        /// <param name="name">Name</param>
        /// <param name="id">Unique identifier. Leave it at 0 for new records as it will be set automatically.</param>
        /// <param name="created">Creation date. It is set automatically.</param>
        /// <param name="varVersion">Row version, for optimistic concurrency. It is set automatically.</param>
        /// <param name="userId">User id.</param>
        /// <param name="counter">Holds the last unique value used to generate a XML filename. This is automatically updated by the system   when a raw XML file is uploaded. Normally, you do not need or want to change this value.</param>
        [JsonConstructor]
        public Company(string vat, string fiscalCode, string name, Option<int?> id = default, Option<DateTime?> created = default, Option<int?> varVersion = default, Option<int?> userId = default, Option<int?> counter = default)
        {
            Vat = vat;
            FiscalCode = fiscalCode;
            Name = name;
            IdOption = id;
            CreatedOption = created;
            VarVersionOption = varVersion;
            UserIdOption = userId;
            CounterOption = counter;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Vat number. Must include the country code.
        /// </summary>
        /// <value>Vat number. Must include the country code.</value>
        /* <example>IT01234567891</example> */
        [JsonPropertyName("vat")]
        public string Vat { get; set; }

        /// <summary>
        /// Fiscal code. In most cases it&#39;s the same as the vat number.
        /// </summary>
        /// <value>Fiscal code. In most cases it&#39;s the same as the vat number.</value>
        /* <example>RSSMRA70A01F205V</example> */
        [JsonPropertyName("fiscal_code")]
        public string FiscalCode { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        /* <example>Mario Rossi Srl</example> */
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Used to track the state of Id
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> IdOption { get; private set; }

        /// <summary>
        /// Unique identifier. Leave it at 0 for new records as it will be set automatically.
        /// </summary>
        /// <value>Unique identifier. Leave it at 0 for new records as it will be set automatically.</value>
        [JsonPropertyName("id")]
        public int? Id { get { return this.IdOption; } set { this.IdOption = new Option<int?>(value); } }

        /// <summary>
        /// Used to track the state of Created
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> CreatedOption { get; private set; }

        /// <summary>
        /// Creation date. It is set automatically.
        /// </summary>
        /// <value>Creation date. It is set automatically.</value>
        [JsonPropertyName("created")]
        public DateTime? Created { get { return this.CreatedOption; } set { this.CreatedOption = new Option<DateTime?>(value); } }

        /// <summary>
        /// Used to track the state of VarVersion
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> VarVersionOption { get; private set; }

        /// <summary>
        /// Row version, for optimistic concurrency. It is set automatically.
        /// </summary>
        /// <value>Row version, for optimistic concurrency. It is set automatically.</value>
        [JsonPropertyName("version")]
        public int? VarVersion { get { return this.VarVersionOption; } set { this.VarVersionOption = new Option<int?>(value); } }

        /// <summary>
        /// Used to track the state of UserId
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> UserIdOption { get; private set; }

        /// <summary>
        /// User id.
        /// </summary>
        /// <value>User id.</value>
        [JsonPropertyName("user_id")]
        public int? UserId { get { return this.UserIdOption; } set { this.UserIdOption = new Option<int?>(value); } }

        /// <summary>
        /// Used to track the state of Counter
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> CounterOption { get; private set; }

        /// <summary>
        /// Holds the last unique value used to generate a XML filename. This is automatically updated by the system   when a raw XML file is uploaded. Normally, you do not need or want to change this value.
        /// </summary>
        /// <value>Holds the last unique value used to generate a XML filename. This is automatically updated by the system   when a raw XML file is uploaded. Normally, you do not need or want to change this value.</value>
        [JsonPropertyName("counter")]
        public int? Counter { get { return this.CounterOption; } set { this.CounterOption = new Option<int?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Company {\n");
            sb.Append("  Vat: ").Append(Vat).Append("\n");
            sb.Append("  FiscalCode: ").Append(FiscalCode).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Counter: ").Append(Counter).Append("\n");
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
            // Vat (string) minLength
            if (this.Vat != null && this.Vat.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Vat, length must be greater than 1.", new [] { "Vat" });
            }

            // FiscalCode (string) minLength
            if (this.FiscalCode != null && this.FiscalCode.Length < 1)
            {
                yield return new ValidationResult("Invalid value for FiscalCode, length must be greater than 1.", new [] { "FiscalCode" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="Company" />
    /// </summary>
    public class CompanyJsonConverter : JsonConverter<Company>
    {
        /// <summary>
        /// The format to use to serialize Created
        /// </summary>
        public static string CreatedFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="Company" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Company Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> vat = default;
            Option<string> fiscalCode = default;
            Option<string> name = default;
            Option<int?> id = default;
            Option<DateTime?> created = default;
            Option<int?> varVersion = default;
            Option<int?> userId = default;
            Option<int?> counter = default;

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
                        case "vat":
                            vat = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "fiscal_code":
                            fiscalCode = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "name":
                            name = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "id":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                id = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "created":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                created = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "version":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                varVersion = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "user_id":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                userId = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "counter":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                counter = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!vat.IsSet)
                throw new ArgumentException("Property is required for class Company.", nameof(vat));

            if (!fiscalCode.IsSet)
                throw new ArgumentException("Property is required for class Company.", nameof(fiscalCode));

            if (!name.IsSet)
                throw new ArgumentException("Property is required for class Company.", nameof(name));

            if (vat.IsSet && vat.Value == null)
                throw new ArgumentNullException(nameof(vat), "Property is not nullable for class Company.");

            if (fiscalCode.IsSet && fiscalCode.Value == null)
                throw new ArgumentNullException(nameof(fiscalCode), "Property is not nullable for class Company.");

            if (name.IsSet && name.Value == null)
                throw new ArgumentNullException(nameof(name), "Property is not nullable for class Company.");

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class Company.");

            if (created.IsSet && created.Value == null)
                throw new ArgumentNullException(nameof(created), "Property is not nullable for class Company.");

            if (varVersion.IsSet && varVersion.Value == null)
                throw new ArgumentNullException(nameof(varVersion), "Property is not nullable for class Company.");

            if (userId.IsSet && userId.Value == null)
                throw new ArgumentNullException(nameof(userId), "Property is not nullable for class Company.");

            if (counter.IsSet && counter.Value == null)
                throw new ArgumentNullException(nameof(counter), "Property is not nullable for class Company.");

            return new Company(vat.Value, fiscalCode.Value, name.Value, id, created, varVersion, userId, counter);
        }

        /// <summary>
        /// Serializes a <see cref="Company" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="company"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Company company, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, company, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="Company" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="company"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, Company company, JsonSerializerOptions jsonSerializerOptions)
        {
            if (company.Vat == null)
                throw new ArgumentNullException(nameof(company.Vat), "Property is required for class Company.");

            if (company.FiscalCode == null)
                throw new ArgumentNullException(nameof(company.FiscalCode), "Property is required for class Company.");

            if (company.Name == null)
                throw new ArgumentNullException(nameof(company.Name), "Property is required for class Company.");

            writer.WriteString("vat", company.Vat);

            writer.WriteString("fiscal_code", company.FiscalCode);

            writer.WriteString("name", company.Name);

            if (company.IdOption.IsSet)
                writer.WriteNumber("id", company.IdOption.Value.Value);

            if (company.CreatedOption.IsSet)
                writer.WriteString("created", company.CreatedOption.Value.Value.ToString(CreatedFormat));

            if (company.VarVersionOption.IsSet)
                writer.WriteNumber("version", company.VarVersionOption.Value.Value);

            if (company.UserIdOption.IsSet)
                writer.WriteNumber("user_id", company.UserIdOption.Value.Value);

            if (company.CounterOption.IsSet)
                writer.WriteNumber("counter", company.CounterOption.Value.Value);
        }
    }
}
