# Invoicetronic.Sdk.Model.Update
An SDI status update for a sent invoice.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Unique identifier. For POST requests, leave it at &#x60;0&#x60; — the server will assign one automatically. For PUT requests, set it to the id of the record you want to update. | [optional] 
**Created** | **DateTime** | Creation date. It is set automatically. | [optional] [readonly] 
**VarVersion** | **int** | Row version, for optimistic concurrency. It is set automatically. | [optional] [readonly] 
**UserId** | **int** | User id. | [optional] 
**CompanyId** | **int** | Company id. | [optional] 
**SendId** | **int** | Send id. This is the id of the sent invoice to which this update refers to. | [optional] 
**LastUpdate** | **DateTime** | Last update from SDI. | [optional] 
**State** | **string** | State of the document. These are the possible values, as per the SDI documentation: | [optional] 
**Description** | **string** | Description for the state. | [optional] 
**MessageId** | **string** | SDI message id. | [optional] 
**Errors** | [**List&lt;Error&gt;**](Error.md) | SDI errors, if any. | [optional] 
**IsRead** | **bool** | Whether the item has been read at least once. | [optional] 
**Send** | [**SendReduced**](SendReduced.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

