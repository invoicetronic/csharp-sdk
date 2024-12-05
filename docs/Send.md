# Invoicetronic.InvoiceApi.Model.Send

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Unique identifier. Leave it at 0 for new records as it will be set automatically. | [optional] 
**Created** | **DateTime** | Creation date. It is set automatically. | [optional] 
**VarVersion** | **int** | Row version, for optimistic concurrency. It is set automatically. | [optional] 
**UserId** | **int** | User id. | [optional] 
**CompanyId** | **int** | Company id. On send, this is the sender and must be set in advance. On receive, it will be  automatically set based on the recipient&#39;s VAT number. If a matching company is not found, the invoice will be rejected until the company is created. | [optional] 
**Committente** | **string** | VAT number of the Cessionario/Committente (customer). This is automatically set based on the recipient&#39;s VAT number. | [optional] 
**Prestatore** | **string** | VAT number of the Cedente/Prestatore (vendor). This is automatically set based on the sender&#39;s VAT number. | [optional] 
**Identifier** | **string** | SDI identifier. This is set by the SDI and is guaranted to be unique within the SDI system. | [optional] 
**FileName** | **string** | Xml file name. | [optional] 
**Format** | **string** | SDI format (FPA12, FPR12, FSM10, ...) | [optional] 
**Payload** | **string** | Xml payloaad. This is the actual xml content, as string. On send, it can be base64 encoded. If it&#39;s not, it will be encoded before sending. It is guaranteed to be cyphered at rest. | [optional] 
**LastUpdate** | **DateTime?** | Last update from SDI. | [optional] 
**DateSent** | **DateTime?** | When the invoice was sent to SDI. | [optional] 
**Documents** | [**List&lt;DocumentData&gt;**](DocumentData.md) | The invoices included in the payload. This is set by the system, based on the xml content. | [optional] 
**MetaData** | **Dictionary&lt;string, string&gt;** | Optional metadata, as json. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

