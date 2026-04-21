# Invoicetronic.Sdk.Model.Company
A company model.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Unique identifier. For POST requests, leave it at &#x60;0&#x60; — the server will assign one automatically. For PUT requests, set it to the id of the record you want to update. | [optional] 
**Created** | **DateTime** | Creation date. It is set automatically. | [optional] [readonly] 
**VarVersion** | **int** | Row version, for optimistic concurrency. It is set automatically. | [optional] [readonly] 
**UserId** | **int** | User id. It is set automatically based on the authenticated user. | [optional] [readonly] 
**Vat** | **string** | Vat number. Must include the country code. | 
**FiscalCode** | **string** | Fiscal code. In most cases it&#39;s the same as the vat number. | 
**Name** | **string** | Name | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

