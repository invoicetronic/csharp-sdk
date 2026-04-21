# Invoicetronic.Sdk.Model.Send
A sent invoice.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Unique identifier. For POST requests, leave it at &#x60;0&#x60; — the server will assign one automatically. For PUT requests, set it to the id of the record you want to update. | [optional] 
**Created** | **DateTime** | Creation date. It is set automatically. | [optional] [readonly] 
**VarVersion** | **int** | Row version, for optimistic concurrency. It is set automatically. | [optional] [readonly] 
**UserId** | **int** | User id. It is set automatically based on the authenticated user. | [optional] [readonly] 
**CompanyId** | **int** | Company id. It is set automatically based on the VAT number extracted from the invoice payload (the sender for &#x60;send&#x60;, the recipient for &#x60;receive&#x60;). | [optional] [readonly] 
**Committente** | **string** | VAT number of the Cessionario/Committente (customer). This is automatically set based on the recipient&#39;s VAT number. | [optional] [readonly] 
**Prestatore** | **string** | VAT number of the Cedente/Prestatore (vendor). This is automatically set based on the sender&#39;s VAT number. | [optional] [readonly] 
**Identifier** | **string** | SDI identifier. This is set by the SDI and is guaranteed to be unique within the SDI system. | [optional] [readonly] 
**FileName** | **string** | Xml file name. If not provided on send, it will be auto-generated. | [optional] 
**Format** | **string** | SDI format (FPA12, FPR12, FSM10, ...) | [optional] 
**Payload** | **string** | Xml payload. This is the actual xml content, as string. On send, it can be base64 encoded. If it&#39;s not, it will be encoded before sending. It is guaranteed to be encrypted at rest. | 
**LastUpdate** | **DateTime?** | Last update from SDI. | [optional] [readonly] 
**DateSent** | **DateTime?** | When the invoice was sent to SDI. | [optional] [readonly] 
**Documents** | [**List&lt;DocumentData&gt;**](DocumentData.md) | The invoices included in the payload. This is set by the system, based on the xml content. | [optional] [readonly] 
**Encoding** | **string** | Whether the payload is Base64 encoded or a plain XML (text). | [optional] 
**NomeCommittente** | **string** | Business name of the committente (client/buyer) extracted from the invoice XML. | [optional] [readonly] 
**MetaData** | **Dictionary&lt;string, string&gt;** | Optional metadata, as json. | [optional] 
**LatestState** | **string** | Current SDI state of the invoice. Reflects the most recent update received from SDI. Null when no update has been received yet. | [optional] [readonly] 
**Company** | [**Company**](Company.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

