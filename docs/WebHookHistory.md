# Invoicetronic.Sdk.Model.WebHookHistory
Webhook history.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Unique identifier. For POST requests, leave it at &#x60;0&#x60; — the server will assign one automatically. For PUT requests, set it to the id of the record you want to update. | [optional] 
**Created** | **DateTime** | Creation date. It is set automatically. | [optional] [readonly] 
**VarVersion** | **int** | Row version, for optimistic concurrency. It is set automatically. | [optional] [readonly] 
**WebHookId** | **int** | Webhook id. | [optional] 
**UserId** | **int** | User id. | [optional] 
**Event** | **string** | Event name. | [optional] 
**StatusCode** | **int** | HTTP status code returned by the webhook endpoint. A value of 0 means the request could not be completed due to a network error (e.g., DNS resolution failure, connection refused, or timeout). This typically indicates that the endpoint URL is misconfigured or no longer exists. | [optional] 
**Error** | **string** | Error description, if any. Null when the delivery is successful (2xx). Contains the exception message for network errors (status code 0) or the response body for non-2xx HTTP responses. | [optional] 
**DateTime** | **DateTime** | Date and time of the request. | [optional] 
**Success** | **bool** | Whether the request was successful. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

