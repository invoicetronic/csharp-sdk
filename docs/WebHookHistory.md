# Invoicetronic.InvoiceApi.Model.WebHookHistory
Webhook history.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Unique identifier. Leave it at 0 for new records as it will be set automatically. | [optional] 
**Created** | **DateTime** | Creation date. It is set automatically. | [optional] 
**VarVersion** | **int** | Row version, for optimistic concurrency. It is set automatically. | [optional] 
**WebHookId** | **int** | Webhook id. | [optional] 
**UserId** | **int** | User id. | [optional] 
**Event** | **string** | Event name. | [optional] 
**StatusCode** | **int** | Status code. | [optional] 
**RequestBody** | **string** | Webhook request body. | [optional] 
**ResponseBody** | **string** | Webhook response body. | [optional] 
**DateTime** | **DateTime** | Date and time of the request. | [optional] 
**Success** | **bool** | Wether the request was successful. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

