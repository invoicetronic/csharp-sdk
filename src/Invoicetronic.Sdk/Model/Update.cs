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
    /// Update
    /// </summary>
    public partial class Update : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Update" /> class.
        /// </summary>
        /// <param name="id">Unique identifier. Leave it at 0 for new records as it will be set automatically.</param>
        /// <param name="created">Creation date. It is set automatically.</param>
        /// <param name="varVersion">Row version, for optimistic concurrency. It is set automatically.</param>
        /// <param name="userId">User id.</param>
        /// <param name="companyId">Company id.</param>
        /// <param name="sendId">Send id. This is the id of the sent invoice to which this update refers to.</param>
        /// <param name="dateSent">When the document was sent to the SDI.</param>
        /// <param name="lastUpdate">Last update from SDI.</param>
        /// <param name="identifier">SDI identifier. This is set by the SDI and it is unique within the SDI system.</param>
        /// <param name="state">State of the document. Theses are the possible values, as per the SDI documentation:</param>
        /// <param name="description">Description for the state.</param>
        /// <param name="messageId">SDI message id.</param>
        /// <param name="errors">SDI errors, if any.</param>
        /// <param name="isRead">Wether the item has been read at least once.</param>
        [JsonConstructor]
        public Update(Option<int?> id = default, Option<DateTime?> created = default, Option<int?> varVersion = default, Option<int?> userId = default, Option<int?> companyId = default, Option<int?> sendId = default, Option<DateTime?> dateSent = default, Option<DateTime?> lastUpdate = default, Option<string> identifier = default, Option<StateEnum?> state = default, Option<string> description = default, Option<string> messageId = default, Option<List<Error>> errors = default, Option<bool?> isRead = default)
        {
            IdOption = id;
            CreatedOption = created;
            VarVersionOption = varVersion;
            UserIdOption = userId;
            CompanyIdOption = companyId;
            SendIdOption = sendId;
            DateSentOption = dateSent;
            LastUpdateOption = lastUpdate;
            IdentifierOption = identifier;
            StateOption = state;
            DescriptionOption = description;
            MessageIdOption = messageId;
            ErrorsOption = errors;
            IsReadOption = isRead;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// State of the document. Theses are the possible values, as per the SDI documentation:
        /// </summary>
        /// <value>State of the document. Theses are the possible values, as per the SDI documentation:</value>
        public enum StateEnum
        {
            /// <summary>
            /// Enum Inviato for value: Inviato
            /// </summary>
            Inviato = 1,

            /// <summary>
            /// Enum Consegnato for value: Consegnato
            /// </summary>
            Consegnato = 2,

            /// <summary>
            /// Enum NonConsegnato for value: NonConsegnato
            /// </summary>
            NonConsegnato = 3,

            /// <summary>
            /// Enum Scartato for value: Scartato
            /// </summary>
            Scartato = 4,

            /// <summary>
            /// Enum AccettatoDalDestinatario for value: AccettatoDalDestinatario
            /// </summary>
            AccettatoDalDestinatario = 5,

            /// <summary>
            /// Enum RifiutatoDalDestinatario for value: RifiutatoDalDestinatario
            /// </summary>
            RifiutatoDalDestinatario = 6,

            /// <summary>
            /// Enum ImpossibilitDiRecapito for value: ImpossibilitàDiRecapito
            /// </summary>
            ImpossibilitDiRecapito = 7,

            /// <summary>
            /// Enum DecorrenzaTermini for value: DecorrenzaTermini
            /// </summary>
            DecorrenzaTermini = 8,

            /// <summary>
            /// Enum AttestazioneTrasmissioneFattura for value: AttestazioneTrasmissioneFattura
            /// </summary>
            AttestazioneTrasmissioneFattura = 9
        }

        /// <summary>
        /// Returns a <see cref="StateEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static StateEnum StateEnumFromString(string value)
        {
            if (value.Equals("Inviato"))
                return StateEnum.Inviato;

            if (value.Equals("Consegnato"))
                return StateEnum.Consegnato;

            if (value.Equals("NonConsegnato"))
                return StateEnum.NonConsegnato;

            if (value.Equals("Scartato"))
                return StateEnum.Scartato;

            if (value.Equals("AccettatoDalDestinatario"))
                return StateEnum.AccettatoDalDestinatario;

            if (value.Equals("RifiutatoDalDestinatario"))
                return StateEnum.RifiutatoDalDestinatario;

            if (value.Equals("ImpossibilitàDiRecapito"))
                return StateEnum.ImpossibilitDiRecapito;

            if (value.Equals("DecorrenzaTermini"))
                return StateEnum.DecorrenzaTermini;

            if (value.Equals("AttestazioneTrasmissioneFattura"))
                return StateEnum.AttestazioneTrasmissioneFattura;

            throw new NotImplementedException($"Could not convert value to type StateEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="StateEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static StateEnum? StateEnumFromStringOrDefault(string value)
        {
            if (value.Equals("Inviato"))
                return StateEnum.Inviato;

            if (value.Equals("Consegnato"))
                return StateEnum.Consegnato;

            if (value.Equals("NonConsegnato"))
                return StateEnum.NonConsegnato;

            if (value.Equals("Scartato"))
                return StateEnum.Scartato;

            if (value.Equals("AccettatoDalDestinatario"))
                return StateEnum.AccettatoDalDestinatario;

            if (value.Equals("RifiutatoDalDestinatario"))
                return StateEnum.RifiutatoDalDestinatario;

            if (value.Equals("ImpossibilitàDiRecapito"))
                return StateEnum.ImpossibilitDiRecapito;

            if (value.Equals("DecorrenzaTermini"))
                return StateEnum.DecorrenzaTermini;

            if (value.Equals("AttestazioneTrasmissioneFattura"))
                return StateEnum.AttestazioneTrasmissioneFattura;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="StateEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string StateEnumToJsonValue(StateEnum? value)
        {
            if (value == StateEnum.Inviato)
                return "Inviato";

            if (value == StateEnum.Consegnato)
                return "Consegnato";

            if (value == StateEnum.NonConsegnato)
                return "NonConsegnato";

            if (value == StateEnum.Scartato)
                return "Scartato";

            if (value == StateEnum.AccettatoDalDestinatario)
                return "AccettatoDalDestinatario";

            if (value == StateEnum.RifiutatoDalDestinatario)
                return "RifiutatoDalDestinatario";

            if (value == StateEnum.ImpossibilitDiRecapito)
                return "ImpossibilitàDiRecapito";

            if (value == StateEnum.DecorrenzaTermini)
                return "DecorrenzaTermini";

            if (value == StateEnum.AttestazioneTrasmissioneFattura)
                return "AttestazioneTrasmissioneFattura";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Used to track the state of State
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<StateEnum?> StateOption { get; private set; }

        /// <summary>
        /// State of the document. Theses are the possible values, as per the SDI documentation:
        /// </summary>
        /// <value>State of the document. Theses are the possible values, as per the SDI documentation:</value>
        [JsonPropertyName("state")]
        public StateEnum? State { get { return this.StateOption; } set { this.StateOption = new Option<StateEnum?>(value); } }

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
        /// Company id.
        /// </summary>
        /// <value>Company id.</value>
        [JsonPropertyName("company_id")]
        public int? CompanyId { get { return this.CompanyIdOption; } set { this.CompanyIdOption = new Option<int?>(value); } }

        /// <summary>
        /// Used to track the state of SendId
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> SendIdOption { get; private set; }

        /// <summary>
        /// Send id. This is the id of the sent invoice to which this update refers to.
        /// </summary>
        /// <value>Send id. This is the id of the sent invoice to which this update refers to.</value>
        [JsonPropertyName("send_id")]
        public int? SendId { get { return this.SendIdOption; } set { this.SendIdOption = new Option<int?>(value); } }

        /// <summary>
        /// Used to track the state of DateSent
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> DateSentOption { get; private set; }

        /// <summary>
        /// When the document was sent to the SDI.
        /// </summary>
        /// <value>When the document was sent to the SDI.</value>
        [JsonPropertyName("date_sent")]
        public DateTime? DateSent { get { return this.DateSentOption; } set { this.DateSentOption = new Option<DateTime?>(value); } }

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
        /// Used to track the state of Identifier
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> IdentifierOption { get; private set; }

        /// <summary>
        /// SDI identifier. This is set by the SDI and it is unique within the SDI system.
        /// </summary>
        /// <value>SDI identifier. This is set by the SDI and it is unique within the SDI system.</value>
        [JsonPropertyName("identifier")]
        public string Identifier { get { return this.IdentifierOption; } set { this.IdentifierOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Description
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> DescriptionOption { get; private set; }

        /// <summary>
        /// Description for the state.
        /// </summary>
        /// <value>Description for the state.</value>
        [JsonPropertyName("description")]
        public string Description { get { return this.DescriptionOption; } set { this.DescriptionOption = new Option<string>(value); } }

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
        /// Used to track the state of Errors
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<Error>> ErrorsOption { get; private set; }

        /// <summary>
        /// SDI errors, if any.
        /// </summary>
        /// <value>SDI errors, if any.</value>
        [JsonPropertyName("errors")]
        public List<Error> Errors { get { return this.ErrorsOption; } set { this.ErrorsOption = new Option<List<Error>>(value); } }

        /// <summary>
        /// Used to track the state of IsRead
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> IsReadOption { get; private set; }

        /// <summary>
        /// Wether the item has been read at least once.
        /// </summary>
        /// <value>Wether the item has been read at least once.</value>
        [JsonPropertyName("is_read")]
        public bool? IsRead { get { return this.IsReadOption; } set { this.IsReadOption = new Option<bool?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Update {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  SendId: ").Append(SendId).Append("\n");
            sb.Append("  DateSent: ").Append(DateSent).Append("\n");
            sb.Append("  LastUpdate: ").Append(LastUpdate).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  IsRead: ").Append(IsRead).Append("\n");
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
    /// A Json converter for type <see cref="Update" />
    /// </summary>
    public class UpdateJsonConverter : JsonConverter<Update>
    {
        /// <summary>
        /// The format to use to serialize Created
        /// </summary>
        public static string CreatedFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// The format to use to serialize DateSent
        /// </summary>
        public static string DateSentFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// The format to use to serialize LastUpdate
        /// </summary>
        public static string LastUpdateFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="Update" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Update Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
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
            Option<int?> sendId = default;
            Option<DateTime?> dateSent = default;
            Option<DateTime?> lastUpdate = default;
            Option<string> identifier = default;
            Option<Update.StateEnum?> state = default;
            Option<string> description = default;
            Option<string> messageId = default;
            Option<List<Error>> errors = default;
            Option<bool?> isRead = default;

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
                        case "send_id":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                sendId = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "date_sent":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                dateSent = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime?>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "last_update":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                lastUpdate = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "identifier":
                            identifier = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "state":
                            string stateRawValue = utf8JsonReader.GetString();
                            if (stateRawValue != null)
                                state = new Option<Update.StateEnum?>(Update.StateEnumFromStringOrDefault(stateRawValue));
                            break;
                        case "description":
                            description = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "message_id":
                            messageId = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "errors":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                errors = new Option<List<Error>>(JsonSerializer.Deserialize<List<Error>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "is_read":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                isRead = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class Update.");

            if (created.IsSet && created.Value == null)
                throw new ArgumentNullException(nameof(created), "Property is not nullable for class Update.");

            if (varVersion.IsSet && varVersion.Value == null)
                throw new ArgumentNullException(nameof(varVersion), "Property is not nullable for class Update.");

            if (userId.IsSet && userId.Value == null)
                throw new ArgumentNullException(nameof(userId), "Property is not nullable for class Update.");

            if (companyId.IsSet && companyId.Value == null)
                throw new ArgumentNullException(nameof(companyId), "Property is not nullable for class Update.");

            if (sendId.IsSet && sendId.Value == null)
                throw new ArgumentNullException(nameof(sendId), "Property is not nullable for class Update.");

            if (lastUpdate.IsSet && lastUpdate.Value == null)
                throw new ArgumentNullException(nameof(lastUpdate), "Property is not nullable for class Update.");

            if (state.IsSet && state.Value == null)
                throw new ArgumentNullException(nameof(state), "Property is not nullable for class Update.");

            if (isRead.IsSet && isRead.Value == null)
                throw new ArgumentNullException(nameof(isRead), "Property is not nullable for class Update.");

            return new Update(id, created, varVersion, userId, companyId, sendId, dateSent, lastUpdate, identifier, state, description, messageId, errors, isRead);
        }

        /// <summary>
        /// Serializes a <see cref="Update" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="update"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Update update, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, update, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="Update" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="update"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, Update update, JsonSerializerOptions jsonSerializerOptions)
        {
            if (update.IdOption.IsSet)
                writer.WriteNumber("id", update.IdOption.Value.Value);

            if (update.CreatedOption.IsSet)
                writer.WriteString("created", update.CreatedOption.Value.Value.ToString(CreatedFormat));

            if (update.VarVersionOption.IsSet)
                writer.WriteNumber("version", update.VarVersionOption.Value.Value);

            if (update.UserIdOption.IsSet)
                writer.WriteNumber("user_id", update.UserIdOption.Value.Value);

            if (update.CompanyIdOption.IsSet)
                writer.WriteNumber("company_id", update.CompanyIdOption.Value.Value);

            if (update.SendIdOption.IsSet)
                writer.WriteNumber("send_id", update.SendIdOption.Value.Value);

            if (update.DateSentOption.IsSet)
                if (update.DateSentOption.Value != null)
                    writer.WriteString("date_sent", update.DateSentOption.Value.Value.ToString(DateSentFormat));
                else
                    writer.WriteNull("date_sent");

            if (update.LastUpdateOption.IsSet)
                writer.WriteString("last_update", update.LastUpdateOption.Value.Value.ToString(LastUpdateFormat));

            if (update.IdentifierOption.IsSet)
                if (update.IdentifierOption.Value != null)
                    writer.WriteString("identifier", update.Identifier);
                else
                    writer.WriteNull("identifier");

            var stateRawValue = Update.StateEnumToJsonValue(update.StateOption.Value.Value);
            writer.WriteString("state", stateRawValue);
            if (update.DescriptionOption.IsSet)
                if (update.DescriptionOption.Value != null)
                    writer.WriteString("description", update.Description);
                else
                    writer.WriteNull("description");

            if (update.MessageIdOption.IsSet)
                if (update.MessageIdOption.Value != null)
                    writer.WriteString("message_id", update.MessageId);
                else
                    writer.WriteNull("message_id");

            if (update.ErrorsOption.IsSet)
                if (update.ErrorsOption.Value != null)
                {
                    writer.WritePropertyName("errors");
                    JsonSerializer.Serialize(writer, update.Errors, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("errors");
            if (update.IsReadOption.IsSet)
                writer.WriteBoolean("is_read", update.IsReadOption.Value.Value);
        }
    }
}
