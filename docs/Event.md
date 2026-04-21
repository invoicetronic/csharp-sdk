# Invoicetronic.Sdk.Model.Event
An API request log entry.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Unique identifier. For POST requests, leave it at &#x60;0&#x60; — the server will assign one automatically. For PUT requests, set it to the id of the record you want to update. | [optional] 
**Created** | **DateTime** | Creation date. It is set automatically. | [optional] [readonly] 
**VarVersion** | **int** | Row version, for optimistic concurrency. It is set automatically. | [optional] [readonly] 
**UserId** | **int** | User id. | [optional] 
**ApiKeyId** | **int** | Api key id. | [optional] 
**CompanyId** | **int?** | Company id. | [optional] 
**Method** | **string** | Request method. | 
**Endpoint** | **string** | API endpoint. | 
**ApiVersion** | **int** | Api version. | [optional] 
**StatusCode** | **int** | Status code returned by the API. | [optional] 
**DateTime** | **DateTime** | Date and time of the request. | [optional] 
**Error** | **string** | Response error. | [optional] 
**ResourceId** | **int?** | ID of the resource created or modified by this request. | [optional] 
**UserAgent** | **string** | User-Agent header from the HTTP request. | [optional] 
**Success** | **bool** | Whether the request was successful. | [optional] [readonly] 
**Query** | **string** | Request query. Only used for internal logging, not sent to webhooks. | [optional] 
**ResponseBody** | **string** | Response payload. It is guaranteed to be encrypted at rest. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

