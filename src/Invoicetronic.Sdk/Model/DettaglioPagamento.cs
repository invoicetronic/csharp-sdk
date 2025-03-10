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
    /// DettaglioPagamento
    /// </summary>
    public partial class DettaglioPagamento : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DettaglioPagamento" /> class.
        /// </summary>
        /// <param name="beneficiario">beneficiario</param>
        /// <param name="modalitaPagamento">modalitaPagamento</param>
        /// <param name="dataRiferimentoTerminiPagamento">dataRiferimentoTerminiPagamento</param>
        /// <param name="giorniTerminiPagamento">giorniTerminiPagamento</param>
        /// <param name="dataScadenzaPagamento">dataScadenzaPagamento</param>
        /// <param name="importoPagamento">importoPagamento</param>
        /// <param name="codUfficioPostale">codUfficioPostale</param>
        /// <param name="cognomeQuietanzante">cognomeQuietanzante</param>
        /// <param name="nomeQuietanzante">nomeQuietanzante</param>
        /// <param name="cfQuietanzante">cfQuietanzante</param>
        /// <param name="titoloQuietanzante">titoloQuietanzante</param>
        /// <param name="istitutoFinanziario">istitutoFinanziario</param>
        /// <param name="iban">iban</param>
        /// <param name="abi">abi</param>
        /// <param name="cab">cab</param>
        /// <param name="bic">bic</param>
        /// <param name="scontoPagamentoAnticipato">scontoPagamentoAnticipato</param>
        /// <param name="dataLimitePagamentoAnticipato">dataLimitePagamentoAnticipato</param>
        /// <param name="penalitaPagamentiRitardati">penalitaPagamentiRitardati</param>
        /// <param name="dataDecorrenzaPenale">dataDecorrenzaPenale</param>
        /// <param name="codicePagamento">codicePagamento</param>
        [JsonConstructor]
        public DettaglioPagamento(Option<string> beneficiario = default, Option<string> modalitaPagamento = default, Option<DateTime?> dataRiferimentoTerminiPagamento = default, Option<int?> giorniTerminiPagamento = default, Option<DateTime?> dataScadenzaPagamento = default, Option<double?> importoPagamento = default, Option<string> codUfficioPostale = default, Option<string> cognomeQuietanzante = default, Option<string> nomeQuietanzante = default, Option<string> cfQuietanzante = default, Option<string> titoloQuietanzante = default, Option<string> istitutoFinanziario = default, Option<string> iban = default, Option<string> abi = default, Option<string> cab = default, Option<string> bic = default, Option<double?> scontoPagamentoAnticipato = default, Option<DateTime?> dataLimitePagamentoAnticipato = default, Option<double?> penalitaPagamentiRitardati = default, Option<DateTime?> dataDecorrenzaPenale = default, Option<string> codicePagamento = default)
        {
            BeneficiarioOption = beneficiario;
            ModalitaPagamentoOption = modalitaPagamento;
            DataRiferimentoTerminiPagamentoOption = dataRiferimentoTerminiPagamento;
            GiorniTerminiPagamentoOption = giorniTerminiPagamento;
            DataScadenzaPagamentoOption = dataScadenzaPagamento;
            ImportoPagamentoOption = importoPagamento;
            CodUfficioPostaleOption = codUfficioPostale;
            CognomeQuietanzanteOption = cognomeQuietanzante;
            NomeQuietanzanteOption = nomeQuietanzante;
            CfQuietanzanteOption = cfQuietanzante;
            TitoloQuietanzanteOption = titoloQuietanzante;
            IstitutoFinanziarioOption = istitutoFinanziario;
            IbanOption = iban;
            AbiOption = abi;
            CabOption = cab;
            BicOption = bic;
            ScontoPagamentoAnticipatoOption = scontoPagamentoAnticipato;
            DataLimitePagamentoAnticipatoOption = dataLimitePagamentoAnticipato;
            PenalitaPagamentiRitardatiOption = penalitaPagamentiRitardati;
            DataDecorrenzaPenaleOption = dataDecorrenzaPenale;
            CodicePagamentoOption = codicePagamento;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Beneficiario
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> BeneficiarioOption { get; private set; }

        /// <summary>
        /// Gets or Sets Beneficiario
        /// </summary>
        [JsonPropertyName("beneficiario")]
        public string Beneficiario { get { return this.BeneficiarioOption; } set { this.BeneficiarioOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of ModalitaPagamento
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> ModalitaPagamentoOption { get; private set; }

        /// <summary>
        /// Gets or Sets ModalitaPagamento
        /// </summary>
        [JsonPropertyName("modalita_pagamento")]
        public string ModalitaPagamento { get { return this.ModalitaPagamentoOption; } set { this.ModalitaPagamentoOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of DataRiferimentoTerminiPagamento
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> DataRiferimentoTerminiPagamentoOption { get; private set; }

        /// <summary>
        /// Gets or Sets DataRiferimentoTerminiPagamento
        /// </summary>
        [JsonPropertyName("data_riferimento_termini_pagamento")]
        public DateTime? DataRiferimentoTerminiPagamento { get { return this.DataRiferimentoTerminiPagamentoOption; } set { this.DataRiferimentoTerminiPagamentoOption = new Option<DateTime?>(value); } }

        /// <summary>
        /// Used to track the state of GiorniTerminiPagamento
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> GiorniTerminiPagamentoOption { get; private set; }

        /// <summary>
        /// Gets or Sets GiorniTerminiPagamento
        /// </summary>
        [JsonPropertyName("giorni_termini_pagamento")]
        public int? GiorniTerminiPagamento { get { return this.GiorniTerminiPagamentoOption; } set { this.GiorniTerminiPagamentoOption = new Option<int?>(value); } }

        /// <summary>
        /// Used to track the state of DataScadenzaPagamento
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> DataScadenzaPagamentoOption { get; private set; }

        /// <summary>
        /// Gets or Sets DataScadenzaPagamento
        /// </summary>
        [JsonPropertyName("data_scadenza_pagamento")]
        public DateTime? DataScadenzaPagamento { get { return this.DataScadenzaPagamentoOption; } set { this.DataScadenzaPagamentoOption = new Option<DateTime?>(value); } }

        /// <summary>
        /// Used to track the state of ImportoPagamento
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<double?> ImportoPagamentoOption { get; private set; }

        /// <summary>
        /// Gets or Sets ImportoPagamento
        /// </summary>
        [JsonPropertyName("importo_pagamento")]
        public double? ImportoPagamento { get { return this.ImportoPagamentoOption; } set { this.ImportoPagamentoOption = new Option<double?>(value); } }

        /// <summary>
        /// Used to track the state of CodUfficioPostale
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> CodUfficioPostaleOption { get; private set; }

        /// <summary>
        /// Gets or Sets CodUfficioPostale
        /// </summary>
        [JsonPropertyName("cod_ufficio_postale")]
        public string CodUfficioPostale { get { return this.CodUfficioPostaleOption; } set { this.CodUfficioPostaleOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of CognomeQuietanzante
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> CognomeQuietanzanteOption { get; private set; }

        /// <summary>
        /// Gets or Sets CognomeQuietanzante
        /// </summary>
        [JsonPropertyName("cognome_quietanzante")]
        public string CognomeQuietanzante { get { return this.CognomeQuietanzanteOption; } set { this.CognomeQuietanzanteOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of NomeQuietanzante
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> NomeQuietanzanteOption { get; private set; }

        /// <summary>
        /// Gets or Sets NomeQuietanzante
        /// </summary>
        [JsonPropertyName("nome_quietanzante")]
        public string NomeQuietanzante { get { return this.NomeQuietanzanteOption; } set { this.NomeQuietanzanteOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of CfQuietanzante
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> CfQuietanzanteOption { get; private set; }

        /// <summary>
        /// Gets or Sets CfQuietanzante
        /// </summary>
        [JsonPropertyName("cf_quietanzante")]
        public string CfQuietanzante { get { return this.CfQuietanzanteOption; } set { this.CfQuietanzanteOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of TitoloQuietanzante
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> TitoloQuietanzanteOption { get; private set; }

        /// <summary>
        /// Gets or Sets TitoloQuietanzante
        /// </summary>
        [JsonPropertyName("titolo_quietanzante")]
        public string TitoloQuietanzante { get { return this.TitoloQuietanzanteOption; } set { this.TitoloQuietanzanteOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of IstitutoFinanziario
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> IstitutoFinanziarioOption { get; private set; }

        /// <summary>
        /// Gets or Sets IstitutoFinanziario
        /// </summary>
        [JsonPropertyName("istituto_finanziario")]
        public string IstitutoFinanziario { get { return this.IstitutoFinanziarioOption; } set { this.IstitutoFinanziarioOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Iban
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> IbanOption { get; private set; }

        /// <summary>
        /// Gets or Sets Iban
        /// </summary>
        [JsonPropertyName("iban")]
        public string Iban { get { return this.IbanOption; } set { this.IbanOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Abi
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> AbiOption { get; private set; }

        /// <summary>
        /// Gets or Sets Abi
        /// </summary>
        [JsonPropertyName("abi")]
        public string Abi { get { return this.AbiOption; } set { this.AbiOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Cab
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> CabOption { get; private set; }

        /// <summary>
        /// Gets or Sets Cab
        /// </summary>
        [JsonPropertyName("cab")]
        public string Cab { get { return this.CabOption; } set { this.CabOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Bic
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> BicOption { get; private set; }

        /// <summary>
        /// Gets or Sets Bic
        /// </summary>
        [JsonPropertyName("bic")]
        public string Bic { get { return this.BicOption; } set { this.BicOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of ScontoPagamentoAnticipato
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<double?> ScontoPagamentoAnticipatoOption { get; private set; }

        /// <summary>
        /// Gets or Sets ScontoPagamentoAnticipato
        /// </summary>
        [JsonPropertyName("sconto_pagamento_anticipato")]
        public double? ScontoPagamentoAnticipato { get { return this.ScontoPagamentoAnticipatoOption; } set { this.ScontoPagamentoAnticipatoOption = new Option<double?>(value); } }

        /// <summary>
        /// Used to track the state of DataLimitePagamentoAnticipato
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> DataLimitePagamentoAnticipatoOption { get; private set; }

        /// <summary>
        /// Gets or Sets DataLimitePagamentoAnticipato
        /// </summary>
        [JsonPropertyName("data_limite_pagamento_anticipato")]
        public DateTime? DataLimitePagamentoAnticipato { get { return this.DataLimitePagamentoAnticipatoOption; } set { this.DataLimitePagamentoAnticipatoOption = new Option<DateTime?>(value); } }

        /// <summary>
        /// Used to track the state of PenalitaPagamentiRitardati
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<double?> PenalitaPagamentiRitardatiOption { get; private set; }

        /// <summary>
        /// Gets or Sets PenalitaPagamentiRitardati
        /// </summary>
        [JsonPropertyName("penalita_pagamenti_ritardati")]
        public double? PenalitaPagamentiRitardati { get { return this.PenalitaPagamentiRitardatiOption; } set { this.PenalitaPagamentiRitardatiOption = new Option<double?>(value); } }

        /// <summary>
        /// Used to track the state of DataDecorrenzaPenale
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> DataDecorrenzaPenaleOption { get; private set; }

        /// <summary>
        /// Gets or Sets DataDecorrenzaPenale
        /// </summary>
        [JsonPropertyName("data_decorrenza_penale")]
        public DateTime? DataDecorrenzaPenale { get { return this.DataDecorrenzaPenaleOption; } set { this.DataDecorrenzaPenaleOption = new Option<DateTime?>(value); } }

        /// <summary>
        /// Used to track the state of CodicePagamento
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> CodicePagamentoOption { get; private set; }

        /// <summary>
        /// Gets or Sets CodicePagamento
        /// </summary>
        [JsonPropertyName("codice_pagamento")]
        public string CodicePagamento { get { return this.CodicePagamentoOption; } set { this.CodicePagamentoOption = new Option<string>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DettaglioPagamento {\n");
            sb.Append("  Beneficiario: ").Append(Beneficiario).Append("\n");
            sb.Append("  ModalitaPagamento: ").Append(ModalitaPagamento).Append("\n");
            sb.Append("  DataRiferimentoTerminiPagamento: ").Append(DataRiferimentoTerminiPagamento).Append("\n");
            sb.Append("  GiorniTerminiPagamento: ").Append(GiorniTerminiPagamento).Append("\n");
            sb.Append("  DataScadenzaPagamento: ").Append(DataScadenzaPagamento).Append("\n");
            sb.Append("  ImportoPagamento: ").Append(ImportoPagamento).Append("\n");
            sb.Append("  CodUfficioPostale: ").Append(CodUfficioPostale).Append("\n");
            sb.Append("  CognomeQuietanzante: ").Append(CognomeQuietanzante).Append("\n");
            sb.Append("  NomeQuietanzante: ").Append(NomeQuietanzante).Append("\n");
            sb.Append("  CfQuietanzante: ").Append(CfQuietanzante).Append("\n");
            sb.Append("  TitoloQuietanzante: ").Append(TitoloQuietanzante).Append("\n");
            sb.Append("  IstitutoFinanziario: ").Append(IstitutoFinanziario).Append("\n");
            sb.Append("  Iban: ").Append(Iban).Append("\n");
            sb.Append("  Abi: ").Append(Abi).Append("\n");
            sb.Append("  Cab: ").Append(Cab).Append("\n");
            sb.Append("  Bic: ").Append(Bic).Append("\n");
            sb.Append("  ScontoPagamentoAnticipato: ").Append(ScontoPagamentoAnticipato).Append("\n");
            sb.Append("  DataLimitePagamentoAnticipato: ").Append(DataLimitePagamentoAnticipato).Append("\n");
            sb.Append("  PenalitaPagamentiRitardati: ").Append(PenalitaPagamentiRitardati).Append("\n");
            sb.Append("  DataDecorrenzaPenale: ").Append(DataDecorrenzaPenale).Append("\n");
            sb.Append("  CodicePagamento: ").Append(CodicePagamento).Append("\n");
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
    /// A Json converter for type <see cref="DettaglioPagamento" />
    /// </summary>
    public class DettaglioPagamentoJsonConverter : JsonConverter<DettaglioPagamento>
    {
        /// <summary>
        /// The format to use to serialize DataRiferimentoTerminiPagamento
        /// </summary>
        public static string DataRiferimentoTerminiPagamentoFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// The format to use to serialize DataScadenzaPagamento
        /// </summary>
        public static string DataScadenzaPagamentoFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// The format to use to serialize DataLimitePagamentoAnticipato
        /// </summary>
        public static string DataLimitePagamentoAnticipatoFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// The format to use to serialize DataDecorrenzaPenale
        /// </summary>
        public static string DataDecorrenzaPenaleFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="DettaglioPagamento" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override DettaglioPagamento Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> beneficiario = default;
            Option<string> modalitaPagamento = default;
            Option<DateTime?> dataRiferimentoTerminiPagamento = default;
            Option<int?> giorniTerminiPagamento = default;
            Option<DateTime?> dataScadenzaPagamento = default;
            Option<double?> importoPagamento = default;
            Option<string> codUfficioPostale = default;
            Option<string> cognomeQuietanzante = default;
            Option<string> nomeQuietanzante = default;
            Option<string> cfQuietanzante = default;
            Option<string> titoloQuietanzante = default;
            Option<string> istitutoFinanziario = default;
            Option<string> iban = default;
            Option<string> abi = default;
            Option<string> cab = default;
            Option<string> bic = default;
            Option<double?> scontoPagamentoAnticipato = default;
            Option<DateTime?> dataLimitePagamentoAnticipato = default;
            Option<double?> penalitaPagamentiRitardati = default;
            Option<DateTime?> dataDecorrenzaPenale = default;
            Option<string> codicePagamento = default;

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
                        case "beneficiario":
                            beneficiario = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "modalita_pagamento":
                            modalitaPagamento = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "data_riferimento_termini_pagamento":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                dataRiferimentoTerminiPagamento = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime?>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "giorni_termini_pagamento":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                giorniTerminiPagamento = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "data_scadenza_pagamento":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                dataScadenzaPagamento = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime?>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "importo_pagamento":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                importoPagamento = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "cod_ufficio_postale":
                            codUfficioPostale = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "cognome_quietanzante":
                            cognomeQuietanzante = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "nome_quietanzante":
                            nomeQuietanzante = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "cf_quietanzante":
                            cfQuietanzante = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "titolo_quietanzante":
                            titoloQuietanzante = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "istituto_finanziario":
                            istitutoFinanziario = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "iban":
                            iban = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "abi":
                            abi = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "cab":
                            cab = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "bic":
                            bic = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "sconto_pagamento_anticipato":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                scontoPagamentoAnticipato = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "data_limite_pagamento_anticipato":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                dataLimitePagamentoAnticipato = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime?>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "penalita_pagamenti_ritardati":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                penalitaPagamentiRitardati = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "data_decorrenza_penale":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                dataDecorrenzaPenale = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime?>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "codice_pagamento":
                            codicePagamento = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (importoPagamento.IsSet && importoPagamento.Value == null)
                throw new ArgumentNullException(nameof(importoPagamento), "Property is not nullable for class DettaglioPagamento.");

            return new DettaglioPagamento(beneficiario, modalitaPagamento, dataRiferimentoTerminiPagamento, giorniTerminiPagamento, dataScadenzaPagamento, importoPagamento, codUfficioPostale, cognomeQuietanzante, nomeQuietanzante, cfQuietanzante, titoloQuietanzante, istitutoFinanziario, iban, abi, cab, bic, scontoPagamentoAnticipato, dataLimitePagamentoAnticipato, penalitaPagamentiRitardati, dataDecorrenzaPenale, codicePagamento);
        }

        /// <summary>
        /// Serializes a <see cref="DettaglioPagamento" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="dettaglioPagamento"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, DettaglioPagamento dettaglioPagamento, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, dettaglioPagamento, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="DettaglioPagamento" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="dettaglioPagamento"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, DettaglioPagamento dettaglioPagamento, JsonSerializerOptions jsonSerializerOptions)
        {
            if (dettaglioPagamento.BeneficiarioOption.IsSet)
                if (dettaglioPagamento.BeneficiarioOption.Value != null)
                    writer.WriteString("beneficiario", dettaglioPagamento.Beneficiario);
                else
                    writer.WriteNull("beneficiario");

            if (dettaglioPagamento.ModalitaPagamentoOption.IsSet)
                if (dettaglioPagamento.ModalitaPagamentoOption.Value != null)
                    writer.WriteString("modalita_pagamento", dettaglioPagamento.ModalitaPagamento);
                else
                    writer.WriteNull("modalita_pagamento");

            if (dettaglioPagamento.DataRiferimentoTerminiPagamentoOption.IsSet)
                if (dettaglioPagamento.DataRiferimentoTerminiPagamentoOption.Value != null)
                    writer.WriteString("data_riferimento_termini_pagamento", dettaglioPagamento.DataRiferimentoTerminiPagamentoOption.Value.Value.ToString(DataRiferimentoTerminiPagamentoFormat));
                else
                    writer.WriteNull("data_riferimento_termini_pagamento");

            if (dettaglioPagamento.GiorniTerminiPagamentoOption.IsSet)
                if (dettaglioPagamento.GiorniTerminiPagamentoOption.Value != null)
                    writer.WriteNumber("giorni_termini_pagamento", dettaglioPagamento.GiorniTerminiPagamentoOption.Value.Value);
                else
                    writer.WriteNull("giorni_termini_pagamento");

            if (dettaglioPagamento.DataScadenzaPagamentoOption.IsSet)
                if (dettaglioPagamento.DataScadenzaPagamentoOption.Value != null)
                    writer.WriteString("data_scadenza_pagamento", dettaglioPagamento.DataScadenzaPagamentoOption.Value.Value.ToString(DataScadenzaPagamentoFormat));
                else
                    writer.WriteNull("data_scadenza_pagamento");

            if (dettaglioPagamento.ImportoPagamentoOption.IsSet)
                writer.WriteNumber("importo_pagamento", dettaglioPagamento.ImportoPagamentoOption.Value.Value);

            if (dettaglioPagamento.CodUfficioPostaleOption.IsSet)
                if (dettaglioPagamento.CodUfficioPostaleOption.Value != null)
                    writer.WriteString("cod_ufficio_postale", dettaglioPagamento.CodUfficioPostale);
                else
                    writer.WriteNull("cod_ufficio_postale");

            if (dettaglioPagamento.CognomeQuietanzanteOption.IsSet)
                if (dettaglioPagamento.CognomeQuietanzanteOption.Value != null)
                    writer.WriteString("cognome_quietanzante", dettaglioPagamento.CognomeQuietanzante);
                else
                    writer.WriteNull("cognome_quietanzante");

            if (dettaglioPagamento.NomeQuietanzanteOption.IsSet)
                if (dettaglioPagamento.NomeQuietanzanteOption.Value != null)
                    writer.WriteString("nome_quietanzante", dettaglioPagamento.NomeQuietanzante);
                else
                    writer.WriteNull("nome_quietanzante");

            if (dettaglioPagamento.CfQuietanzanteOption.IsSet)
                if (dettaglioPagamento.CfQuietanzanteOption.Value != null)
                    writer.WriteString("cf_quietanzante", dettaglioPagamento.CfQuietanzante);
                else
                    writer.WriteNull("cf_quietanzante");

            if (dettaglioPagamento.TitoloQuietanzanteOption.IsSet)
                if (dettaglioPagamento.TitoloQuietanzanteOption.Value != null)
                    writer.WriteString("titolo_quietanzante", dettaglioPagamento.TitoloQuietanzante);
                else
                    writer.WriteNull("titolo_quietanzante");

            if (dettaglioPagamento.IstitutoFinanziarioOption.IsSet)
                if (dettaglioPagamento.IstitutoFinanziarioOption.Value != null)
                    writer.WriteString("istituto_finanziario", dettaglioPagamento.IstitutoFinanziario);
                else
                    writer.WriteNull("istituto_finanziario");

            if (dettaglioPagamento.IbanOption.IsSet)
                if (dettaglioPagamento.IbanOption.Value != null)
                    writer.WriteString("iban", dettaglioPagamento.Iban);
                else
                    writer.WriteNull("iban");

            if (dettaglioPagamento.AbiOption.IsSet)
                if (dettaglioPagamento.AbiOption.Value != null)
                    writer.WriteString("abi", dettaglioPagamento.Abi);
                else
                    writer.WriteNull("abi");

            if (dettaglioPagamento.CabOption.IsSet)
                if (dettaglioPagamento.CabOption.Value != null)
                    writer.WriteString("cab", dettaglioPagamento.Cab);
                else
                    writer.WriteNull("cab");

            if (dettaglioPagamento.BicOption.IsSet)
                if (dettaglioPagamento.BicOption.Value != null)
                    writer.WriteString("bic", dettaglioPagamento.Bic);
                else
                    writer.WriteNull("bic");

            if (dettaglioPagamento.ScontoPagamentoAnticipatoOption.IsSet)
                if (dettaglioPagamento.ScontoPagamentoAnticipatoOption.Value != null)
                    writer.WriteNumber("sconto_pagamento_anticipato", dettaglioPagamento.ScontoPagamentoAnticipatoOption.Value.Value);
                else
                    writer.WriteNull("sconto_pagamento_anticipato");

            if (dettaglioPagamento.DataLimitePagamentoAnticipatoOption.IsSet)
                if (dettaglioPagamento.DataLimitePagamentoAnticipatoOption.Value != null)
                    writer.WriteString("data_limite_pagamento_anticipato", dettaglioPagamento.DataLimitePagamentoAnticipatoOption.Value.Value.ToString(DataLimitePagamentoAnticipatoFormat));
                else
                    writer.WriteNull("data_limite_pagamento_anticipato");

            if (dettaglioPagamento.PenalitaPagamentiRitardatiOption.IsSet)
                if (dettaglioPagamento.PenalitaPagamentiRitardatiOption.Value != null)
                    writer.WriteNumber("penalita_pagamenti_ritardati", dettaglioPagamento.PenalitaPagamentiRitardatiOption.Value.Value);
                else
                    writer.WriteNull("penalita_pagamenti_ritardati");

            if (dettaglioPagamento.DataDecorrenzaPenaleOption.IsSet)
                if (dettaglioPagamento.DataDecorrenzaPenaleOption.Value != null)
                    writer.WriteString("data_decorrenza_penale", dettaglioPagamento.DataDecorrenzaPenaleOption.Value.Value.ToString(DataDecorrenzaPenaleFormat));
                else
                    writer.WriteNull("data_decorrenza_penale");

            if (dettaglioPagamento.CodicePagamentoOption.IsSet)
                if (dettaglioPagamento.CodicePagamentoOption.Value != null)
                    writer.WriteString("codice_pagamento", dettaglioPagamento.CodicePagamento);
                else
                    writer.WriteNull("codice_pagamento");
        }
    }
}
