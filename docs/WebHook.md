# Invoicetronic.Sdk.Model.WebHook
A webhook subscription.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Unique identifier. For POST requests, leave it at &#x60;0&#x60; — the server will assign one automatically. For PUT requests, set it to the id of the record you want to update. | [optional] 
**Created** | **DateTime** | Creation date. It is set automatically. | [optional] [readonly] 
**VarVersion** | **int** | Row version, for optimistic concurrency. It is set automatically. | [optional] [readonly] 
**UserId** | **int** | User id. It is set automatically based on the authenticated user. | [optional] [readonly] 
**CompanyId** | **int?** | Optional company id. If set, the webhook is restricted to events for that company; if omitted, it fires for all companies on the account. | [optional] 
**Url** | **string** | The url of your application&#39;s endpoint that will receive a POST request when the webhook is fired. | 
**Enabled** | **bool** | Whether the webhook is enabled. On creation, this is set to &#x60;true&#x60;. | [optional] 
**Secret** | **string** | The secret used to generate webhook signatures, only returned on creation. You should store this value securely and validate it on every call, to ensure that the caller is InvoicetronicApi. | [optional] 
**Description** | **string** | An optional description. | [optional] 
**Events** | **List&lt;string&gt;** | List of events that trigger the webhook. See Invoicetronic.SupportedEvents.Available for a list of valid event names. | [optional] 
**FailureNotifiedAt** | **DateTime?** | Timestamp of the last failure notification email sent for this webhook. Set by the notifier service; reset to null on successful delivery. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

