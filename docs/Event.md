# Invoicetronic.InvoiceApi.Model.Event

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Unique identifier. Leave it at 0 for new records as it will be set automatically. | [optional] 
**Created** | **DateTime** | Creation date. It is set automatically. | [optional] 
**VarVersion** | **int** | Row version, for optimistic concurrency. It is set automatically. | [optional] 
**CompanyId** | **int?** | Company id. | [optional] 
**Method** | **string** | Request method. | [optional] 
**Query** | **string** | Request query. | [optional] 
**Endpoint** | **string** | API endpoint. | [optional] 
**ApiVersion** | **int** | Api version. | [optional] 
**StatusCode** | **int** | Status code returned by the API. | [optional] 
**DateTime** | **DateTime** | Date and time of the request. | [optional] 
**Error** | **string** | Response error. | [optional] 
**RequestBody** | **string** | Request payload. It is guaranteed to be cyphered at rest. | [optional] 
**ResponseBody** | **string** | Response payload. It is guaranteed to be cyphered at rest. | [optional] 
**Success** | **bool** | Wether the request was successful. | [optional] [readonly] 
**UserId** | **int** | User id. | [optional] 
**ApiKeyId** | **int** | Api key id. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

