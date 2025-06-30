# Invoicetronic.Sdk.Model.SendReduced
Reduced Send data for Update responses, containing only the essential fields.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Identifier** | **string** | SDI identifier. | [optional] 
**Prestatore** | **string** | VAT number of the Cedente/Prestatore (vendor). | [optional] 
**MetaData** | **Dictionary&lt;string, string&gt;** | Optional metadata, as json. | [optional] 
**Documents** | [**List&lt;DocumentData&gt;**](DocumentData.md) | The invoices included in the payload. | [optional] 
**DateSent** | **DateTime?** | When the invoice was sent to SDI. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

