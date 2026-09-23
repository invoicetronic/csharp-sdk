# Invoicetronic.Sdk.Model.SubKeyWithSecrets
A restricted key with its secrets, returned only when the key is created or rolled. Store them safely: they cannot be read again.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Unique identifier. | [optional] 
**Created** | **DateTime** | Creation date. | [optional] [readonly] 
**VarVersion** | **int** | Row version, for optimistic concurrency. | [optional] [readonly] 
**Description** | **string** | Human-readable label. | [optional] 
**Active** | **bool** | Whether the key can authenticate. | [optional] 
**Permissions** | [**Permissions**](Permissions.md) |  | [optional] 
**CompanyIds** | **List&lt;int&gt;** | Companies the key can access. Empty means all the companies of the account. | [optional] 
**CorsOrigins** | **List&lt;string&gt;** | Browser origins allowed to call the API with this key (CORS). | [optional] 
**PreviousKeyExpiresAt** | **DateTime?** | When the secrets replaced by the last roll stop working; null when there are none still valid. | [optional] 
**TestKey** | **string** | Sandbox secret. | [optional] 
**LiveKey** | **string** | Production secret. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

