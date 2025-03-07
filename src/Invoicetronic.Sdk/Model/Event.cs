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
    /// Event
    /// </summary>
    public partial class Event : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Event" /> class.
        /// </summary>
        /// <param name="id">Unique identifier. Leave it at 0 for new records as it will be set automatically.</param>
        /// <param name="created">Creation date. It is set automatically.</param>
        /// <param name="varVersion">Row version, for optimistic concurrency. It is set automatically.</param>
        /// <param name="userId">User id.</param>
        /// <param name="apiKeyId">Api key id.</param>
        /// <param name="companyId">Company id.</param>
        /// <param name="method">Request method.</param>
        /// <param name="query">Request query.</param>
        /// <param name="endpoint">API endpoint.</param>
        /// <param name="apiVersion">Api version.</param>
        /// <param name="statusCode">Status code returned by the API.</param>
        /// <param name="dateTime">Date and time of the request.</param>
        /// <param name="error">Response error.</param>
        /// <param name="success">Wether the request was successful.</param>
        /// <param name="responseBody">Response payload. It is guaranteed to be cyphered at rest.</param>
        [JsonConstructor]
        public Event(Option<int?> id = default, Option<DateTime?> created = default, Option<int?> varVersion = default, Option<int?> userId = default, Option<int?> apiKeyId = default, Option<int?> companyId = default, Option<string> method = default, Option<string> query = default, Option<string> endpoint = default, Option<int?> apiVersion = default, Option<int?> statusCode = default, Option<DateTime?> dateTime = default, Option<string> error = default, Option<bool?> success = default, Option<string> responseBody = default)
        {
            IdOption = id;
            CreatedOption = created;
            VarVersionOption = varVersion;
            UserIdOption = userId;
            ApiKeyIdOption = apiKeyId;
            CompanyIdOption = companyId;
            MethodOption = method;
            QueryOption = query;
            EndpointOption = endpoint;
            ApiVersionOption = apiVersion;
            StatusCodeOption = statusCode;
            DateTimeOption = dateTime;
            ErrorOption = error;
            SuccessOption = success;
            ResponseBodyOption = responseBody;
            OnCreated();
        }

        partial void OnCreated();

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
        /// Used to track the state of ApiKeyId
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> ApiKeyIdOption { get; private set; }

        /// <summary>
        /// Api key id.
        /// </summary>
        /// <value>Api key id.</value>
        [JsonPropertyName("api_key_id")]
        public int? ApiKeyId { get { return this.ApiKeyIdOption; } set { this.ApiKeyIdOption = new Option<int?>(value); } }

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
        /// Used to track the state of Method
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> MethodOption { get; private set; }

        /// <summary>
        /// Request method.
        /// </summary>
        /// <value>Request method.</value>
        [JsonPropertyName("method")]
        public string Method { get { return this.MethodOption; } set { this.MethodOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Query
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> QueryOption { get; private set; }

        /// <summary>
        /// Request query.
        /// </summary>
        /// <value>Request query.</value>
        [JsonPropertyName("query")]
        public string Query { get { return this.QueryOption; } set { this.QueryOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Endpoint
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> EndpointOption { get; private set; }

        /// <summary>
        /// API endpoint.
        /// </summary>
        /// <value>API endpoint.</value>
        [JsonPropertyName("endpoint")]
        public string Endpoint { get { return this.EndpointOption; } set { this.EndpointOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of ApiVersion
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> ApiVersionOption { get; private set; }

        /// <summary>
        /// Api version.
        /// </summary>
        /// <value>Api version.</value>
        [JsonPropertyName("api_version")]
        public int? ApiVersion { get { return this.ApiVersionOption; } set { this.ApiVersionOption = new Option<int?>(value); } }

        /// <summary>
        /// Used to track the state of StatusCode
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> StatusCodeOption { get; private set; }

        /// <summary>
        /// Status code returned by the API.
        /// </summary>
        /// <value>Status code returned by the API.</value>
        [JsonPropertyName("status_code")]
        public int? StatusCode { get { return this.StatusCodeOption; } set { this.StatusCodeOption = new Option<int?>(value); } }

        /// <summary>
        /// Used to track the state of DateTime
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> DateTimeOption { get; private set; }

        /// <summary>
        /// Date and time of the request.
        /// </summary>
        /// <value>Date and time of the request.</value>
        [JsonPropertyName("date_time")]
        public DateTime? DateTime { get { return this.DateTimeOption; } set { this.DateTimeOption = new Option<DateTime?>(value); } }

        /// <summary>
        /// Used to track the state of Error
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> ErrorOption { get; private set; }

        /// <summary>
        /// Response error.
        /// </summary>
        /// <value>Response error.</value>
        [JsonPropertyName("error")]
        public string Error { get { return this.ErrorOption; } set { this.ErrorOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Success
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> SuccessOption { get; }

        /// <summary>
        /// Wether the request was successful.
        /// </summary>
        /// <value>Wether the request was successful.</value>
        [JsonPropertyName("success")]
        public bool? Success { get { return this.SuccessOption; } }

        /// <summary>
        /// Used to track the state of ResponseBody
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> ResponseBodyOption { get; private set; }

        /// <summary>
        /// Response payload. It is guaranteed to be cyphered at rest.
        /// </summary>
        /// <value>Response payload. It is guaranteed to be cyphered at rest.</value>
        [JsonPropertyName("response_body")]
        public string ResponseBody { get { return this.ResponseBodyOption; } set { this.ResponseBodyOption = new Option<string>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Event {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  ApiKeyId: ").Append(ApiKeyId).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  Endpoint: ").Append(Endpoint).Append("\n");
            sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  DateTime: ").Append(DateTime).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  ResponseBody: ").Append(ResponseBody).Append("\n");
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
    /// A Json converter for type <see cref="Event" />
    /// </summary>
    public class EventJsonConverter : JsonConverter<Event>
    {
        /// <summary>
        /// The format to use to serialize Created
        /// </summary>
        public static string CreatedFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// The format to use to serialize DateTime
        /// </summary>
        public static string DateTimeFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="Event" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Event Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<int?> id = default;
            Option<DateTime?> created = default;
            Option<int?> varVersion = default;
            Option<int?> userId = default;
            Option<int?> apiKeyId = default;
            Option<int?> companyId = default;
            Option<string> method = default;
            Option<string> query = default;
            Option<string> endpoint = default;
            Option<int?> apiVersion = default;
            Option<int?> statusCode = default;
            Option<DateTime?> dateTime = default;
            Option<string> error = default;
            Option<bool?> success = default;
            Option<string> responseBody = default;

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
                        case "api_key_id":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                apiKeyId = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "company_id":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                companyId = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "method":
                            method = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "query":
                            query = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "endpoint":
                            endpoint = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "api_version":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                apiVersion = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "status_code":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                statusCode = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "date_time":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                dateTime = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "error":
                            error = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "success":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                success = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "response_body":
                            responseBody = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class Event.");

            if (created.IsSet && created.Value == null)
                throw new ArgumentNullException(nameof(created), "Property is not nullable for class Event.");

            if (varVersion.IsSet && varVersion.Value == null)
                throw new ArgumentNullException(nameof(varVersion), "Property is not nullable for class Event.");

            if (userId.IsSet && userId.Value == null)
                throw new ArgumentNullException(nameof(userId), "Property is not nullable for class Event.");

            if (apiKeyId.IsSet && apiKeyId.Value == null)
                throw new ArgumentNullException(nameof(apiKeyId), "Property is not nullable for class Event.");

            if (apiVersion.IsSet && apiVersion.Value == null)
                throw new ArgumentNullException(nameof(apiVersion), "Property is not nullable for class Event.");

            if (statusCode.IsSet && statusCode.Value == null)
                throw new ArgumentNullException(nameof(statusCode), "Property is not nullable for class Event.");

            if (dateTime.IsSet && dateTime.Value == null)
                throw new ArgumentNullException(nameof(dateTime), "Property is not nullable for class Event.");

            if (success.IsSet && success.Value == null)
                throw new ArgumentNullException(nameof(success), "Property is not nullable for class Event.");

            return new Event(id, created, varVersion, userId, apiKeyId, companyId, method, query, endpoint, apiVersion, statusCode, dateTime, error, success, responseBody);
        }

        /// <summary>
        /// Serializes a <see cref="Event" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="varEvent"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Event varEvent, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, varEvent, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="Event" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="varEvent"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, Event varEvent, JsonSerializerOptions jsonSerializerOptions)
        {
            if (varEvent.IdOption.IsSet)
                writer.WriteNumber("id", varEvent.IdOption.Value.Value);

            if (varEvent.CreatedOption.IsSet)
                writer.WriteString("created", varEvent.CreatedOption.Value.Value.ToString(CreatedFormat));

            if (varEvent.VarVersionOption.IsSet)
                writer.WriteNumber("version", varEvent.VarVersionOption.Value.Value);

            if (varEvent.UserIdOption.IsSet)
                writer.WriteNumber("user_id", varEvent.UserIdOption.Value.Value);

            if (varEvent.ApiKeyIdOption.IsSet)
                writer.WriteNumber("api_key_id", varEvent.ApiKeyIdOption.Value.Value);

            if (varEvent.CompanyIdOption.IsSet)
                if (varEvent.CompanyIdOption.Value != null)
                    writer.WriteNumber("company_id", varEvent.CompanyIdOption.Value.Value);
                else
                    writer.WriteNull("company_id");

            if (varEvent.MethodOption.IsSet)
                if (varEvent.MethodOption.Value != null)
                    writer.WriteString("method", varEvent.Method);
                else
                    writer.WriteNull("method");

            if (varEvent.QueryOption.IsSet)
                if (varEvent.QueryOption.Value != null)
                    writer.WriteString("query", varEvent.Query);
                else
                    writer.WriteNull("query");

            if (varEvent.EndpointOption.IsSet)
                if (varEvent.EndpointOption.Value != null)
                    writer.WriteString("endpoint", varEvent.Endpoint);
                else
                    writer.WriteNull("endpoint");

            if (varEvent.ApiVersionOption.IsSet)
                writer.WriteNumber("api_version", varEvent.ApiVersionOption.Value.Value);

            if (varEvent.StatusCodeOption.IsSet)
                writer.WriteNumber("status_code", varEvent.StatusCodeOption.Value.Value);

            if (varEvent.DateTimeOption.IsSet)
                writer.WriteString("date_time", varEvent.DateTimeOption.Value.Value.ToString(DateTimeFormat));

            if (varEvent.ErrorOption.IsSet)
                if (varEvent.ErrorOption.Value != null)
                    writer.WriteString("error", varEvent.Error);
                else
                    writer.WriteNull("error");

            if (varEvent.SuccessOption.IsSet)
                writer.WriteBoolean("success", varEvent.SuccessOption.Value.Value);

            if (varEvent.ResponseBodyOption.IsSet)
                if (varEvent.ResponseBodyOption.Value != null)
                    writer.WriteString("response_body", varEvent.ResponseBody);
                else
                    writer.WriteNull("response_body");
        }
    }
}
