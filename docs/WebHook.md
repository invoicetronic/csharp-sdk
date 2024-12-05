# Invoicetronic.InvoiceApi.Model.WebHook

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Unique identifier. Leave it at 0 for new records as it will be set automatically. | [optional] 
**Created** | **DateTime** | Creation date. It is set automatically. | [optional] 
**VarVersion** | **int** | Row version, for optimistic concurrency. It is set automatically. | [optional] 
**UserId** | **int** | User id. | [optional] 
**CompanyId** | **int?** | Company id. | [optional] 
**Url** | **string** | The url of your application&#39;s endpoint that will receive a POST request when the webhook is fired. | [optional] 
**Enabled** | **bool** | Wetehr the webhooks is enabled or not. On creation, this is set to &#x60;true&#x60;. | [optional] 
**Secret** | **string** | The secret used to generate webhook signatures, only returned on creation. You should store this value securely and validate it on every call, to ensure that the caller is InvoiceApi. | [optional] 
**Description** | **string** | An optional description. | [optional] 
**Events** | **List&lt;string&gt;** | List of events to that trigger the webhook.  See InvoiceApi.SupportedEvents.Available for a list of valid event names. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

