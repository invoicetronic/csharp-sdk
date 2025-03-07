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
    /// Send
    /// </summary>
    public partial class Send : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Send" /> class.
        /// </summary>
        /// <param name="id">Unique identifier. Leave it at 0 for new records as it will be set automatically.</param>
        /// <param name="created">Creation date. It is set automatically.</param>
        /// <param name="varVersion">Row version, for optimistic concurrency. It is set automatically.</param>
        /// <param name="userId">User id.</param>
        /// <param name="companyId">Company id. On send, this is the sender and must be set in advance. On receive, it will be  automatically set based on the recipient&#39;s VAT number. If a matching company is not found, the invoice will be rejected until the company is created.</param>
        /// <param name="committente">VAT number of the Cessionario/Committente (customer). This is automatically set based on the recipient&#39;s VAT number.</param>
        /// <param name="prestatore">VAT number of the Cedente/Prestatore (vendor). This is automatically set based on the sender&#39;s VAT number.</param>
        /// <param name="identifier">SDI identifier. This is set by the SDI and is guaranted to be unique within the SDI system.</param>
        /// <param name="fileName">Xml file name.</param>
        /// <param name="format">SDI format (FPA12, FPR12, FSM10, ...)</param>
        /// <param name="payload">Xml payloaad. This is the actual xml content, as string. On send, it can be base64 encoded. If it&#39;s not, it will be encoded before sending. It is guaranteed to be cyphered at rest.</param>
        /// <param name="lastUpdate">Last update from SDI.</param>
        /// <param name="dateSent">When the invoice was sent to SDI.</param>
        /// <param name="documents">The invoices included in the payload. This is set by the system, based on the xml content.</param>
        /// <param name="encoding">Whether the payload is Base64 encoded or a plain XML (text).</param>
        /// <param name="metaData">Optional metadata, as json.</param>
        /// <param name="company">company</param>
        [JsonConstructor]
        public Send(Option<int?> id = default, Option<DateTime?> created = default, Option<int?> varVersion = default, Option<int?> userId = default, Option<int?> companyId = default, Option<string> committente = default, Option<string> prestatore = default, Option<string> identifier = default, Option<string> fileName = default, Option<string> format = default, Option<string> payload = default, Option<DateTime?> lastUpdate = default, Option<DateTime?> dateSent = default, Option<List<DocumentData>> documents = default, Option<EncodingEnum?> encoding = default, Option<Dictionary<string, string>> metaData = default, Option<Company> company = default)
        {
            IdOption = id;
            CreatedOption = created;
            VarVersionOption = varVersion;
            UserIdOption = userId;
            CompanyIdOption = companyId;
            CommittenteOption = committente;
            PrestatoreOption = prestatore;
            IdentifierOption = identifier;
            FileNameOption = fileName;
            FormatOption = format;
            PayloadOption = payload;
            LastUpdateOption = lastUpdate;
            DateSentOption = dateSent;
            DocumentsOption = documents;
            EncodingOption = encoding;
            MetaDataOption = metaData;
            CompanyOption = company;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Whether the payload is Base64 encoded or a plain XML (text).
        /// </summary>
        /// <value>Whether the payload is Base64 encoded or a plain XML (text).</value>
        public enum EncodingEnum
        {
            /// <summary>
            /// Enum Xml for value: Xml
            /// </summary>
            Xml = 1,

            /// <summary>
            /// Enum Base64 for value: Base64
            /// </summary>
            Base64 = 2
        }

        /// <summary>
        /// Returns a <see cref="EncodingEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static EncodingEnum EncodingEnumFromString(string value)
        {
            if (value.Equals("Xml"))
                return EncodingEnum.Xml;

            if (value.Equals("Base64"))
                return EncodingEnum.Base64;

            throw new NotImplementedException($"Could not convert value to type EncodingEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="EncodingEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static EncodingEnum? EncodingEnumFromStringOrDefault(string value)
        {
            if (value.Equals("Xml"))
                return EncodingEnum.Xml;

            if (value.Equals("Base64"))
                return EncodingEnum.Base64;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="EncodingEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string EncodingEnumToJsonValue(EncodingEnum? value)
        {
            if (value == EncodingEnum.Xml)
                return "Xml";

            if (value == EncodingEnum.Base64)
                return "Base64";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Used to track the state of Encoding
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<EncodingEnum?> EncodingOption { get; private set; }

        /// <summary>
        /// Whether the payload is Base64 encoded or a plain XML (text).
        /// </summary>
        /// <value>Whether the payload is Base64 encoded or a plain XML (text).</value>
        [JsonPropertyName("encoding")]
        public EncodingEnum? Encoding { get { return this.EncodingOption; } set { this.EncodingOption = new Option<EncodingEnum?>(value); } }

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
        /// Used to track the state of CompanyId
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> CompanyIdOption { get; private set; }

        /// <summary>
        /// Company id. On send, this is the sender and must be set in advance. On receive, it will be  automatically set based on the recipient&#39;s VAT number. If a matching company is not found, the invoice will be rejected until the company is created.
        /// </summary>
        /// <value>Company id. On send, this is the sender and must be set in advance. On receive, it will be  automatically set based on the recipient&#39;s VAT number. If a matching company is not found, the invoice will be rejected until the company is created.</value>
        [JsonPropertyName("company_id")]
        public int? CompanyId { get { return this.CompanyIdOption; } set { this.CompanyIdOption = new Option<int?>(value); } }

        /// <summary>
        /// Used to track the state of Committente
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> CommittenteOption { get; private set; }

        /// <summary>
        /// VAT number of the Cessionario/Committente (customer). This is automatically set based on the recipient&#39;s VAT number.
        /// </summary>
        /// <value>VAT number of the Cessionario/Committente (customer). This is automatically set based on the recipient&#39;s VAT number.</value>
        [JsonPropertyName("committente")]
        public string Committente { get { return this.CommittenteOption; } set { this.CommittenteOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Prestatore
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> PrestatoreOption { get; private set; }

        /// <summary>
        /// VAT number of the Cedente/Prestatore (vendor). This is automatically set based on the sender&#39;s VAT number.
        /// </summary>
        /// <value>VAT number of the Cedente/Prestatore (vendor). This is automatically set based on the sender&#39;s VAT number.</value>
        [JsonPropertyName("prestatore")]
        public string Prestatore { get { return this.PrestatoreOption; } set { this.PrestatoreOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Identifier
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> IdentifierOption { get; private set; }

        /// <summary>
        /// SDI identifier. This is set by the SDI and is guaranted to be unique within the SDI system.
        /// </summary>
        /// <value>SDI identifier. This is set by the SDI and is guaranted to be unique within the SDI system.</value>
        [JsonPropertyName("identifier")]
        public string Identifier { get { return this.IdentifierOption; } set { this.IdentifierOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of FileName
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> FileNameOption { get; private set; }

        /// <summary>
        /// Xml file name.
        /// </summary>
        /// <value>Xml file name.</value>
        [JsonPropertyName("file_name")]
        public string FileName { get { return this.FileNameOption; } set { this.FileNameOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Format
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> FormatOption { get; private set; }

        /// <summary>
        /// SDI format (FPA12, FPR12, FSM10, ...)
        /// </summary>
        /// <value>SDI format (FPA12, FPR12, FSM10, ...)</value>
        [JsonPropertyName("format")]
        public string Format { get { return this.FormatOption; } set { this.FormatOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Payload
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> PayloadOption { get; private set; }

        /// <summary>
        /// Xml payloaad. This is the actual xml content, as string. On send, it can be base64 encoded. If it&#39;s not, it will be encoded before sending. It is guaranteed to be cyphered at rest.
        /// </summary>
        /// <value>Xml payloaad. This is the actual xml content, as string. On send, it can be base64 encoded. If it&#39;s not, it will be encoded before sending. It is guaranteed to be cyphered at rest.</value>
        [JsonPropertyName("payload")]
        public string Payload { get { return this.PayloadOption; } set { this.PayloadOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of LastUpdate
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> LastUpdateOption { get; private set; }

        /// <summary>
        /// Last update from SDI.
        /// </summary>
        /// <value>Last update from SDI.</value>
        [JsonPropertyName("last_update")]
        public DateTime? LastUpdate { get { return this.LastUpdateOption; } set { this.LastUpdateOption = new Option<DateTime?>(value); } }

        /// <summary>
        /// Used to track the state of DateSent
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> DateSentOption { get; private set; }

        /// <summary>
        /// When the invoice was sent to SDI.
        /// </summary>
        /// <value>When the invoice was sent to SDI.</value>
        [JsonPropertyName("date_sent")]
        public DateTime? DateSent { get { return this.DateSentOption; } set { this.DateSentOption = new Option<DateTime?>(value); } }

        /// <summary>
        /// Used to track the state of Documents
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<DocumentData>> DocumentsOption { get; private set; }

        /// <summary>
        /// The invoices included in the payload. This is set by the system, based on the xml content.
        /// </summary>
        /// <value>The invoices included in the payload. This is set by the system, based on the xml content.</value>
        [JsonPropertyName("documents")]
        public List<DocumentData> Documents { get { return this.DocumentsOption; } set { this.DocumentsOption = new Option<List<DocumentData>>(value); } }

        /// <summary>
        /// Used to track the state of MetaData
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Dictionary<string, string>> MetaDataOption { get; private set; }

        /// <summary>
        /// Optional metadata, as json.
        /// </summary>
        /// <value>Optional metadata, as json.</value>
        [JsonPropertyName("meta_data")]
        public Dictionary<string, string> MetaData { get { return this.MetaDataOption; } set { this.MetaDataOption = new Option<Dictionary<string, string>>(value); } }

        /// <summary>
        /// Used to track the state of Company
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Company> CompanyOption { get; private set; }

        /// <summary>
        /// Gets or Sets Company
        /// </summary>
        [JsonPropertyName("company")]
        public Company Company { get { return this.CompanyOption; } set { this.CompanyOption = new Option<Company>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Send {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  Committente: ").Append(Committente).Append("\n");
            sb.Append("  Prestatore: ").Append(Prestatore).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
            sb.Append("  LastUpdate: ").Append(LastUpdate).Append("\n");
            sb.Append("  DateSent: ").Append(DateSent).Append("\n");
            sb.Append("  Documents: ").Append(Documents).Append("\n");
            sb.Append("  Encoding: ").Append(Encoding).Append("\n");
            sb.Append("  MetaData: ").Append(MetaData).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
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
    /// A Json converter for type <see cref="Send" />
    /// </summary>
    public class SendJsonConverter : JsonConverter<Send>
    {
        /// <summary>
        /// The format to use to serialize Created
        /// </summary>
        public static string CreatedFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// The format to use to serialize LastUpdate
        /// </summary>
        public static string LastUpdateFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// The format to use to serialize DateSent
        /// </summary>
        public static string DateSentFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="Send" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Send Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<int?> id = default;
            Option<DateTime?> created = default;
            Option<int?> varVersion = default;
            Option<int?> userId = default;
            Option<int?> companyId = default;
            Option<string> committente = default;
            Option<string> prestatore = default;
            Option<string> identifier = default;
            Option<string> fileName = default;
            Option<string> format = default;
            Option<string> payload = default;
            Option<DateTime?> lastUpdate = default;
            Option<DateTime?> dateSent = default;
            Option<List<DocumentData>> documents = default;
            Option<Send.EncodingEnum?> encoding = default;
            Option<Dictionary<string, string>> metaData = default;
            Option<Company> company = default;

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
                        case "company_id":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                companyId = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "committente":
                            committente = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "prestatore":
                            prestatore = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "identifier":
                            identifier = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "file_name":
                            fileName = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "format":
                            format = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "payload":
                            payload = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "last_update":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                lastUpdate = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime?>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "date_sent":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                dateSent = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime?>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "documents":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                documents = new Option<List<DocumentData>>(JsonSerializer.Deserialize<List<DocumentData>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "encoding":
                            string encodingRawValue = utf8JsonReader.GetString();
                            if (encodingRawValue != null)
                                encoding = new Option<Send.EncodingEnum?>(Send.EncodingEnumFromStringOrDefault(encodingRawValue));
                            break;
                        case "meta_data":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                metaData = new Option<Dictionary<string, string>>(JsonSerializer.Deserialize<Dictionary<string, string>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "company":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                company = new Option<Company>(JsonSerializer.Deserialize<Company>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class Send.");

            if (created.IsSet && created.Value == null)
                throw new ArgumentNullException(nameof(created), "Property is not nullable for class Send.");

            if (varVersion.IsSet && varVersion.Value == null)
                throw new ArgumentNullException(nameof(varVersion), "Property is not nullable for class Send.");

            if (userId.IsSet && userId.Value == null)
                throw new ArgumentNullException(nameof(userId), "Property is not nullable for class Send.");

            if (companyId.IsSet && companyId.Value == null)
                throw new ArgumentNullException(nameof(companyId), "Property is not nullable for class Send.");

            if (encoding.IsSet && encoding.Value == null)
                throw new ArgumentNullException(nameof(encoding), "Property is not nullable for class Send.");

            if (company.IsSet && company.Value == null)
                throw new ArgumentNullException(nameof(company), "Property is not nullable for class Send.");

            return new Send(id, created, varVersion, userId, companyId, committente, prestatore, identifier, fileName, format, payload, lastUpdate, dateSent, documents, encoding, metaData, company);
        }

        /// <summary>
        /// Serializes a <see cref="Send" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="send"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Send send, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, send, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="Send" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="send"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, Send send, JsonSerializerOptions jsonSerializerOptions)
        {
            if (send.CompanyOption.IsSet && send.Company == null)
                throw new ArgumentNullException(nameof(send.Company), "Property is required for class Send.");

            if (send.IdOption.IsSet)
                writer.WriteNumber("id", send.IdOption.Value.Value);

            if (send.CreatedOption.IsSet)
                writer.WriteString("created", send.CreatedOption.Value.Value.ToString(CreatedFormat));

            if (send.VarVersionOption.IsSet)
                writer.WriteNumber("version", send.VarVersionOption.Value.Value);

            if (send.UserIdOption.IsSet)
                writer.WriteNumber("user_id", send.UserIdOption.Value.Value);

            if (send.CompanyIdOption.IsSet)
                writer.WriteNumber("company_id", send.CompanyIdOption.Value.Value);

            if (send.CommittenteOption.IsSet)
                if (send.CommittenteOption.Value != null)
                    writer.WriteString("committente", send.Committente);
                else
                    writer.WriteNull("committente");

            if (send.PrestatoreOption.IsSet)
                if (send.PrestatoreOption.Value != null)
                    writer.WriteString("prestatore", send.Prestatore);
                else
                    writer.WriteNull("prestatore");

            if (send.IdentifierOption.IsSet)
                if (send.IdentifierOption.Value != null)
                    writer.WriteString("identifier", send.Identifier);
                else
                    writer.WriteNull("identifier");

            if (send.FileNameOption.IsSet)
                if (send.FileNameOption.Value != null)
                    writer.WriteString("file_name", send.FileName);
                else
                    writer.WriteNull("file_name");

            if (send.FormatOption.IsSet)
                if (send.FormatOption.Value != null)
                    writer.WriteString("format", send.Format);
                else
                    writer.WriteNull("format");

            if (send.PayloadOption.IsSet)
                if (send.PayloadOption.Value != null)
                    writer.WriteString("payload", send.Payload);
                else
                    writer.WriteNull("payload");

            if (send.LastUpdateOption.IsSet)
                if (send.LastUpdateOption.Value != null)
                    writer.WriteString("last_update", send.LastUpdateOption.Value.Value.ToString(LastUpdateFormat));
                else
                    writer.WriteNull("last_update");

            if (send.DateSentOption.IsSet)
                if (send.DateSentOption.Value != null)
                    writer.WriteString("date_sent", send.DateSentOption.Value.Value.ToString(DateSentFormat));
                else
                    writer.WriteNull("date_sent");

            if (send.DocumentsOption.IsSet)
                if (send.DocumentsOption.Value != null)
                {
                    writer.WritePropertyName("documents");
                    JsonSerializer.Serialize(writer, send.Documents, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("documents");
            var encodingRawValue = Send.EncodingEnumToJsonValue(send.EncodingOption.Value.Value);
            writer.WriteString("encoding", encodingRawValue);
            if (send.MetaDataOption.IsSet)
                if (send.MetaDataOption.Value != null)
                {
                    writer.WritePropertyName("meta_data");
                    JsonSerializer.Serialize(writer, send.MetaData, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("meta_data");
            if (send.CompanyOption.IsSet)
            {
                writer.WritePropertyName("company");
                JsonSerializer.Serialize(writer, send.Company, jsonSerializerOptions);
            }
        }
    }
}
