# Invoicetronic.Sdk.Model.Permissions
Permissions of a restricted key, per resource. A missing property means no access to that resource. Each permission cannot exceed the one of the main key the restricted key belongs to.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Company** | **string** | Companies: &#x60;Read&#x60; lists and reads them, &#x60;Write&#x60; also creates, updates and deletes them. | [optional] 
**Send** | **string** | Outgoing invoices: &#x60;Read&#x60; lists and reads them, &#x60;Write&#x60; also sends and validates invoices. | [optional] 
**Receive** | **string** | Incoming invoices: &#x60;Read&#x60; lists and reads them, &#x60;Write&#x60; also deletes them. | [optional] 
**Webhook** | **string** | Webhooks: &#x60;Read&#x60; lists and reads them, &#x60;Write&#x60; also creates, updates and deletes them. | [optional] 
**Update** | **string** | SDI status updates of outgoing invoices. | [optional] 
**Log** | **string** | Event log. | [optional] 
**Webhookhistory** | **string** | Webhook delivery history. | [optional] 
**Export** | **string** | Invoice export. | [optional] 
**Status** | **string** | Account status (remaining operations and signatures). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

