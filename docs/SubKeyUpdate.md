# Invoicetronic.Sdk.Model.SubKeyUpdate
A restricted key to update. All the editable fields are replaced: an omitted `permissions`, `company_ids` or `cors_origins` means none.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** | Human-readable label, e.g. the name of the tenant the key is for. | 
**Active** | **bool** | Whether the key can authenticate. Defaults to true. | [optional] 
**Permissions** | [**Permissions**](Permissions.md) |  | [optional] 
**CompanyIds** | **List&lt;int&gt;** | Companies the key can access. When omitted or empty, the key can access all the companies of the account, including the ones created later. | [optional] 
**CorsOrigins** | **List&lt;string&gt;** | Browser origins allowed to call the API with this key (CORS), e.g. &#x60;https://app.example.com&#x60; or &#x60;*.example.com&#x60;. A key used from a browser is public: keep its permissions and companies minimal. | [optional] 
**Id** | **int** | Id of the restricted key to update. | [optional] 
**VarVersion** | **int** | Row version read with the key, for optimistic concurrency: a stale version fails with 422. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

