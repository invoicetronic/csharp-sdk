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
    /// Receive
    /// </summary>
    public partial class Receive : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Receive" /> class.
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
        /// <param name="isRead">Wether the invoice has been read at least once.</param>
        /// <param name="messageId">SDI message id.</param>
        [JsonConstructor]
        public Receive(Option<int?> id = default, Option<DateTime?> created = default, Option<int?> varVersion = default, Option<int?> userId = default, Option<int?> companyId = default, Option<string> committente = default, Option<string> prestatore = default, Option<string> identifier = default, Option<string> fileName = default, Option<string> format = default, Option<string> payload = default, Option<DateTime?> lastUpdate = default, Option<DateTime?> dateSent = default, Option<List<DocumentData>> documents = default, Option<EncodingEnum?> encoding = default, Option<bool?> isRead = default, Option<string> messageId = default)
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
            IsReadOption = isRead;
            MessageIdOption = messageId;
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
        /// Used to track the state of IsRead
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> IsReadOption { get; private set; }

        /// <summary>
        /// Wether the invoice has been read at least once.
        /// </summary>
        /// <value>Wether the invoice has been read at least once.</value>
        [JsonPropertyName("is_read")]
        public bool? IsRead { get { return this.IsReadOption; } set { this.IsReadOption = new Option<bool?>(value); } }

        /// <summary>
        /// Used to track the state of MessageId
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> MessageIdOption { get; private set; }

        /// <summary>
        /// SDI message id.
        /// </summary>
        /// <value>SDI message id.</value>
        [JsonPropertyName("message_id")]
        public string MessageId { get { return this.MessageIdOption; } set { this.MessageIdOption = new Option<string>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Receive {\n");
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
            sb.Append("  IsRead: ").Append(IsRead).Append("\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
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
    /// A Json converter for type <see cref="Receive" />
    /// </summary>
    public class ReceiveJsonConverter : JsonConverter<Receive>
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
        /// Deserializes json to <see cref="Receive" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Receive Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
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
            Option<Receive.EncodingEnum?> encoding = default;
            Option<bool?> isRead = default;
            Option<string> messageId = default;

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
                                encoding = new Option<Receive.EncodingEnum?>(Receive.EncodingEnumFromStringOrDefault(encodingRawValue));
                            break;
                        case "is_read":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                isRead = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "message_id":
                            messageId = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class Receive.");

            if (created.IsSet && created.Value == null)
                throw new ArgumentNullException(nameof(created), "Property is not nullable for class Receive.");

            if (varVersion.IsSet && varVersion.Value == null)
                throw new ArgumentNullException(nameof(varVersion), "Property is not nullable for class Receive.");

            if (userId.IsSet && userId.Value == null)
                throw new ArgumentNullException(nameof(userId), "Property is not nullable for class Receive.");

            if (companyId.IsSet && companyId.Value == null)
                throw new ArgumentNullException(nameof(companyId), "Property is not nullable for class Receive.");

            if (encoding.IsSet && encoding.Value == null)
                throw new ArgumentNullException(nameof(encoding), "Property is not nullable for class Receive.");

            if (isRead.IsSet && isRead.Value == null)
                throw new ArgumentNullException(nameof(isRead), "Property is not nullable for class Receive.");

            return new Receive(id, created, varVersion, userId, companyId, committente, prestatore, identifier, fileName, format, payload, lastUpdate, dateSent, documents, encoding, isRead, messageId);
        }

        /// <summary>
        /// Serializes a <see cref="Receive" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="receive"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Receive receive, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, receive, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="Receive" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="receive"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, Receive receive, JsonSerializerOptions jsonSerializerOptions)
        {
            if (receive.IdOption.IsSet)
                writer.WriteNumber("id", receive.IdOption.Value.Value);

            if (receive.CreatedOption.IsSet)
                writer.WriteString("created", receive.CreatedOption.Value.Value.ToString(CreatedFormat));

            if (receive.VarVersionOption.IsSet)
                writer.WriteNumber("version", receive.VarVersionOption.Value.Value);

            if (receive.UserIdOption.IsSet)
                writer.WriteNumber("user_id", receive.UserIdOption.Value.Value);

            if (receive.CompanyIdOption.IsSet)
                writer.WriteNumber("company_id", receive.CompanyIdOption.Value.Value);

            if (receive.CommittenteOption.IsSet)
                if (receive.CommittenteOption.Value != null)
                    writer.WriteString("committente", receive.Committente);
                else
                    writer.WriteNull("committente");

            if (receive.PrestatoreOption.IsSet)
                if (receive.PrestatoreOption.Value != null)
                    writer.WriteString("prestatore", receive.Prestatore);
                else
                    writer.WriteNull("prestatore");

            if (receive.IdentifierOption.IsSet)
                if (receive.IdentifierOption.Value != null)
                    writer.WriteString("identifier", receive.Identifier);
                else
                    writer.WriteNull("identifier");

            if (receive.FileNameOption.IsSet)
                if (receive.FileNameOption.Value != null)
                    writer.WriteString("file_name", receive.FileName);
                else
                    writer.WriteNull("file_name");

            if (receive.FormatOption.IsSet)
                if (receive.FormatOption.Value != null)
                    writer.WriteString("format", receive.Format);
                else
                    writer.WriteNull("format");

            if (receive.PayloadOption.IsSet)
                if (receive.PayloadOption.Value != null)
                    writer.WriteString("payload", receive.Payload);
                else
                    writer.WriteNull("payload");

            if (receive.LastUpdateOption.IsSet)
                if (receive.LastUpdateOption.Value != null)
                    writer.WriteString("last_update", receive.LastUpdateOption.Value.Value.ToString(LastUpdateFormat));
                else
                    writer.WriteNull("last_update");

            if (receive.DateSentOption.IsSet)
                if (receive.DateSentOption.Value != null)
                    writer.WriteString("date_sent", receive.DateSentOption.Value.Value.ToString(DateSentFormat));
                else
                    writer.WriteNull("date_sent");

            if (receive.DocumentsOption.IsSet)
                if (receive.DocumentsOption.Value != null)
                {
                    writer.WritePropertyName("documents");
                    JsonSerializer.Serialize(writer, receive.Documents, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("documents");
            var encodingRawValue = Receive.EncodingEnumToJsonValue(receive.EncodingOption.Value.Value);
            writer.WriteString("encoding", encodingRawValue);
            if (receive.IsReadOption.IsSet)
                writer.WriteBoolean("is_read", receive.IsReadOption.Value.Value);

            if (receive.MessageIdOption.IsSet)
                if (receive.MessageIdOption.Value != null)
                    writer.WriteString("message_id", receive.MessageId);
                else
                    writer.WriteNull("message_id");
        }
    }
}
