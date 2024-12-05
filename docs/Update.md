# Invoicetronic.InvoiceApi.Model.Update

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Unique identifier. Leave it at 0 for new records as it will be set automatically. | [optional] 
**Created** | **DateTime** | Creation date. It is set automatically. | [optional] 
**VarVersion** | **int** | Row version, for optimistic concurrency. It is set automatically. | [optional] 
**UserId** | **int** | User id. | [optional] 
**CompanyId** | **int** | Company id. | [optional] 
**SendId** | **int** | Send id. This is the id of the sent invoice to which this update refers to. | [optional] 
**DateSent** | **DateTime?** | When the document was sent to the SDI. | [optional] 
**LastUpdate** | **DateTime** | Last update from SDI. | [optional] 
**Identifier** | **string** | SDI identifier. This is set by the SDI and it is unique within the SDI system. | [optional] 
**State** | **string** | State of the document. Theses are the possible values, as per the SDI documentation: | [optional] 
**Description** | **string** | Description for the state. | [optional] 
**MessageId** | **string** | SDI message id. | [optional] 
**Errors** | [**List&lt;Error&gt;**](Error.md) | SDI errors, if any. | [optional] 
**IsRead** | **bool** | Wether the item has been read at least once. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

