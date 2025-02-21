/*
 * Italian eInvoice API v1
 *
 * The [Italian eInvoice API][2] is a RESTful API that allows you to send and receive invoices through the Italian [Servizio di Interscambio (SDI)][1], or Interchange Service. The API is designed by Invoicetronic to be simple and easy to use, abstracting away SDI complexity while providing complete control over the invoice send/receive process. The API also provides advanced features as encryption at rest, invoice validation, multiple upload formats, webhooks, event logging, client SDKs for commonly used languages, and CLI tools.  For more information, see  [Invoicetronic website][2]  [1]: https://www.fatturapa.gov.it/it/sistemainterscambio/cose-il-sdi/ [2]: https://invoicetronic.com/
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
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Invoicetronic.Invoice.Sdk.Client.OpenAPIDateConverter;

namespace Invoicetronic.Invoice.Sdk.Model
{
    /// <summary>
    /// Receive
    /// </summary>
    [DataContract(Name = "Receive")]
    public partial class Receive : IValidatableObject
    {
        /// <summary>
        /// Whether the payload is Base64 encoded or a plain XML (text).
        /// </summary>
        /// <value>Whether the payload is Base64 encoded or a plain XML (text).</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EncodingEnum
        {
            /// <summary>
            /// Enum Xml for value: Xml
            /// </summary>
            [EnumMember(Value = "Xml")]
            Xml = 1,

            /// <summary>
            /// Enum Base64 for value: Base64
            /// </summary>
            [EnumMember(Value = "Base64")]
            Base64 = 2
        }


        /// <summary>
        /// Whether the payload is Base64 encoded or a plain XML (text).
        /// </summary>
        /// <value>Whether the payload is Base64 encoded or a plain XML (text).</value>
        [DataMember(Name = "encoding", EmitDefaultValue = false)]
        public EncodingEnum? Encoding { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Receive" /> class.
        /// </summary>
        /// <param name="id">Unique identifier. Leave it at 0 for new records as it will be set automatically..</param>
        /// <param name="created">Creation date. It is set automatically..</param>
        /// <param name="varVersion">Row version, for optimistic concurrency. It is set automatically..</param>
        /// <param name="userId">User id..</param>
        /// <param name="companyId">Company id. On send, this is the sender and must be set in advance. On receive, it will be  automatically set based on the recipient&#39;s VAT number. If a matching company is not found, the invoice will be rejected until the company is created..</param>
        /// <param name="committente">VAT number of the Cessionario/Committente (customer). This is automatically set based on the recipient&#39;s VAT number..</param>
        /// <param name="prestatore">VAT number of the Cedente/Prestatore (vendor). This is automatically set based on the sender&#39;s VAT number..</param>
        /// <param name="identifier">SDI identifier. This is set by the SDI and is guaranted to be unique within the SDI system..</param>
        /// <param name="fileName">Xml file name..</param>
        /// <param name="format">SDI format (FPA12, FPR12, FSM10, ...).</param>
        /// <param name="payload">Xml payloaad. This is the actual xml content, as string. On send, it can be base64 encoded. If it&#39;s not, it will be encoded before sending. It is guaranteed to be cyphered at rest..</param>
        /// <param name="lastUpdate">Last update from SDI..</param>
        /// <param name="dateSent">When the invoice was sent to SDI..</param>
        /// <param name="documents">The invoices included in the payload. This is set by the system, based on the xml content..</param>
        /// <param name="encoding">Whether the payload is Base64 encoded or a plain XML (text)..</param>
        /// <param name="isRead">Wether the invoice has been read at least once..</param>
        /// <param name="messageId">SDI message id..</param>
        public Receive(int id = default(int), DateTime created = default(DateTime), int varVersion = default(int), int userId = default(int), int companyId = default(int), string committente = default(string), string prestatore = default(string), string identifier = default(string), string fileName = default(string), string format = default(string), string payload = default(string), DateTime? lastUpdate = default(DateTime?), DateTime? dateSent = default(DateTime?), List<DocumentData> documents = default(List<DocumentData>), EncodingEnum? encoding = default(EncodingEnum?), bool isRead = default(bool), string messageId = default(string))
        {
            this.Id = id;
            this.Created = created;
            this.VarVersion = varVersion;
            this.UserId = userId;
            this.CompanyId = companyId;
            this.Committente = committente;
            this.Prestatore = prestatore;
            this.Identifier = identifier;
            this.FileName = fileName;
            this.Format = format;
            this.Payload = payload;
            this.LastUpdate = lastUpdate;
            this.DateSent = dateSent;
            this.Documents = documents;
            this.Encoding = encoding;
            this.IsRead = isRead;
            this.MessageId = messageId;
        }

        /// <summary>
        /// Unique identifier. Leave it at 0 for new records as it will be set automatically.
        /// </summary>
        /// <value>Unique identifier. Leave it at 0 for new records as it will be set automatically.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Creation date. It is set automatically.
        /// </summary>
        /// <value>Creation date. It is set automatically.</value>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public DateTime Created { get; set; }

        /// <summary>
        /// Row version, for optimistic concurrency. It is set automatically.
        /// </summary>
        /// <value>Row version, for optimistic concurrency. It is set automatically.</value>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public int VarVersion { get; set; }

        /// <summary>
        /// User id.
        /// </summary>
        /// <value>User id.</value>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public int UserId { get; set; }

        /// <summary>
        /// Company id. On send, this is the sender and must be set in advance. On receive, it will be  automatically set based on the recipient&#39;s VAT number. If a matching company is not found, the invoice will be rejected until the company is created.
        /// </summary>
        /// <value>Company id. On send, this is the sender and must be set in advance. On receive, it will be  automatically set based on the recipient&#39;s VAT number. If a matching company is not found, the invoice will be rejected until the company is created.</value>
        [DataMember(Name = "company_id", EmitDefaultValue = false)]
        public int CompanyId { get; set; }

        /// <summary>
        /// VAT number of the Cessionario/Committente (customer). This is automatically set based on the recipient&#39;s VAT number.
        /// </summary>
        /// <value>VAT number of the Cessionario/Committente (customer). This is automatically set based on the recipient&#39;s VAT number.</value>
        [DataMember(Name = "committente", EmitDefaultValue = true)]
        public string Committente { get; set; }

        /// <summary>
        /// VAT number of the Cedente/Prestatore (vendor). This is automatically set based on the sender&#39;s VAT number.
        /// </summary>
        /// <value>VAT number of the Cedente/Prestatore (vendor). This is automatically set based on the sender&#39;s VAT number.</value>
        [DataMember(Name = "prestatore", EmitDefaultValue = true)]
        public string Prestatore { get; set; }

        /// <summary>
        /// SDI identifier. This is set by the SDI and is guaranted to be unique within the SDI system.
        /// </summary>
        /// <value>SDI identifier. This is set by the SDI and is guaranted to be unique within the SDI system.</value>
        [DataMember(Name = "identifier", EmitDefaultValue = true)]
        public string Identifier { get; set; }

        /// <summary>
        /// Xml file name.
        /// </summary>
        /// <value>Xml file name.</value>
        [DataMember(Name = "file_name", EmitDefaultValue = true)]
        public string FileName { get; set; }

        /// <summary>
        /// SDI format (FPA12, FPR12, FSM10, ...)
        /// </summary>
        /// <value>SDI format (FPA12, FPR12, FSM10, ...)</value>
        [DataMember(Name = "format", EmitDefaultValue = true)]
        public string Format { get; set; }

        /// <summary>
        /// Xml payloaad. This is the actual xml content, as string. On send, it can be base64 encoded. If it&#39;s not, it will be encoded before sending. It is guaranteed to be cyphered at rest.
        /// </summary>
        /// <value>Xml payloaad. This is the actual xml content, as string. On send, it can be base64 encoded. If it&#39;s not, it will be encoded before sending. It is guaranteed to be cyphered at rest.</value>
        [DataMember(Name = "payload", EmitDefaultValue = true)]
        public string Payload { get; set; }

        /// <summary>
        /// Last update from SDI.
        /// </summary>
        /// <value>Last update from SDI.</value>
        [DataMember(Name = "last_update", EmitDefaultValue = true)]
        public DateTime? LastUpdate { get; set; }

        /// <summary>
        /// When the invoice was sent to SDI.
        /// </summary>
        /// <value>When the invoice was sent to SDI.</value>
        [DataMember(Name = "date_sent", EmitDefaultValue = true)]
        public DateTime? DateSent { get; set; }

        /// <summary>
        /// The invoices included in the payload. This is set by the system, based on the xml content.
        /// </summary>
        /// <value>The invoices included in the payload. This is set by the system, based on the xml content.</value>
        [DataMember(Name = "documents", EmitDefaultValue = true)]
        public List<DocumentData> Documents { get; set; }

        /// <summary>
        /// Wether the invoice has been read at least once.
        /// </summary>
        /// <value>Wether the invoice has been read at least once.</value>
        [DataMember(Name = "is_read", EmitDefaultValue = true)]
        public bool IsRead { get; set; }

        /// <summary>
        /// SDI message id.
        /// </summary>
        /// <value>SDI message id.</value>
        [DataMember(Name = "message_id", EmitDefaultValue = true)]
        public string MessageId { get; set; }

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
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
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

}
