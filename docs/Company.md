# Invoicetronic.InvoiceApi.Model.Company
A company model.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Unique identifier. Leave it at 0 for new records as it will be set automatically. | [optional] 
**Created** | **DateTime** | Creation date. It is set automatically. | [optional] 
**VarVersion** | **int** | Row version, for optimistic concurrency. It is set automatically. | [optional] 
**UserId** | **int** | User id. | [optional] 
**Vat** | **string** | Vat number. Must include the country code. | 
**FiscalCode** | **string** | Fiscal code. In most cases it&#39;s the same as the vat number. | 
**Name** | **string** | Name | 
**Counter** | **int** | Holds the last unique value used to generate a XML filename. This is automatically updated by the system   when a raw XML file is uploaded. Normally, you do not need or want to change this value. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

