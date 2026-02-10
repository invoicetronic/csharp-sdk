# Invoicetronic.Sdk.Api.UpdateApi

All URIs are relative to *https://api.invoicetronic.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UpdateGet**](UpdateApi.md#updateget) | **GET** /update | List updates |
| [**UpdateIdGet**](UpdateApi.md#updateidget) | **GET** /update/{id} | Get an update by id |

<a id="updateget"></a>
# **UpdateGet**
> List&lt;Update&gt; UpdateGet (int? companyId = null, string identifier = null, string prestatore = null, bool? unread = null, int? sendId = null, string state = null, DateTime? lastUpdateFrom = null, DateTime? lastUpdateTo = null, DateTime? dateSentFrom = null, DateTime? dateSentTo = null, int? page = null, int? pageSize = null, string sort = null)

List updates

Retrieve a paginated list of updates. Results can be filtered by various criteria such as company, send item, SDI state, and date ranges.  **Updates** are status notifications from Italy's SDI (Sistema di Interscambio) about invoices you sent. Multiple updates can exist for the same send item as the invoice progresses through the SDI workflow.  The `state` field is the most important property and can have the following values:  | Value | Name | Description | |- -- -- --|- -- -- -|- -- -- -- -- -- --| | 2 | `Inviato` | Sent to the SDI. | | 5 | `Consegnato` | Delivered to the recipient. | | 6 | `NonConsegnato` | Not delivered to the recipient. Only relevant for public administration entities. | | 7 | `Scartato` | Rejected by the SDI. | | 8 | `AccettatoDalDestinatario` | Accepted by the recipient. Only relevant for public administration entities. | | 9 | `RifiutatoDalDestinatario` | Rejected by the recipient. Only relevant for public administration entities. | | 10 | `ImpossibilitaDiRecapito` | Available on the recipient's tax drawer, but it was not possible to deliver it to the recipient's reception system. | | 11 | `DecorrenzaTermini` | A public administration entity has not responded for more than 15 days. The document is considered delivered. | | 12 | `AttestazioneTrasmissioneFattura` | A public administration entity has received the document, but has not yet processed it. |  **Important:** Always monitor the state of your sent invoices. A state of `Inviato` only means the invoice has been submitted to SDI, not that it has been delivered. A state like `Scartato` indicates that the invoice was **not** successfully delivered and may require corrective action, such as fixing validation errors and resubmitting. In that case, `description` contains the reason for the rejection.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Invoicetronic.Sdk.Api;
using Invoicetronic.Sdk.Client;
using Invoicetronic.Sdk.Model;

namespace Example
{
    public class UpdateGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.invoicetronic.com";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new UpdateApi(httpClient, config, httpClientHandler);
            var companyId = 56;  // int? | Company id (optional) 
            var identifier = "identifier_example";  // string | SDI identifier. (optional) 
            var prestatore = "prestatore_example";  // string | Vat number or fiscal code. (optional) 
            var unread = true;  // bool? | Unread items only. (optional) 
            var sendId = 56;  // int? | Send item's id. (optional) 
            var state = "Inviato";  // string | SDI state (optional) 
            var lastUpdateFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | UTC ISO 8601 (2024-11-29T12:34:56Z) (optional) 
            var lastUpdateTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | UTC ISO 8601 (2024-11-29T12:34:56Z) (optional) 
            var dateSentFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | UTC ISO 8601 (2024-11-29T12:34:56Z) (optional) 
            var dateSentTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | UTC ISO 8601 (2024-11-29T12:34:56Z) (optional) 
            var page = 1;  // int? | Page number. (optional)  (default to 1)
            var pageSize = 100;  // int? | Items per page. Cannot be greater than 200. (optional)  (default to 100)
            var sort = "\"last_update\"";  // string | Sort by field. Prefix with '-' for descending order. (optional)  (default to "last_update")

            try
            {
                // List updates
                List<Update> result = apiInstance.UpdateGet(companyId, identifier, prestatore, unread, sendId, state, lastUpdateFrom, lastUpdateTo, dateSentFrom, dateSentTo, page, pageSize, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UpdateApi.UpdateGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List updates
    ApiResponse<List<Update>> response = apiInstance.UpdateGetWithHttpInfo(companyId, identifier, prestatore, unread, sendId, state, lastUpdateFrom, lastUpdateTo, dateSentFrom, dateSentTo, page, pageSize, sort);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UpdateApi.UpdateGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int?** | Company id | [optional]  |
| **identifier** | **string** | SDI identifier. | [optional]  |
| **prestatore** | **string** | Vat number or fiscal code. | [optional]  |
| **unread** | **bool?** | Unread items only. | [optional]  |
| **sendId** | **int?** | Send item&#39;s id. | [optional]  |
| **state** | **string** | SDI state | [optional]  |
| **lastUpdateFrom** | **DateTime?** | UTC ISO 8601 (2024-11-29T12:34:56Z) | [optional]  |
| **lastUpdateTo** | **DateTime?** | UTC ISO 8601 (2024-11-29T12:34:56Z) | [optional]  |
| **dateSentFrom** | **DateTime?** | UTC ISO 8601 (2024-11-29T12:34:56Z) | [optional]  |
| **dateSentTo** | **DateTime?** | UTC ISO 8601 (2024-11-29T12:34:56Z) | [optional]  |
| **page** | **int?** | Page number. | [optional] [default to 1] |
| **pageSize** | **int?** | Items per page. Cannot be greater than 200. | [optional] [default to 100] |
| **sort** | **string** | Sort by field. Prefix with &#39;-&#39; for descending order. | [optional] [default to &quot;last_update&quot;] |

### Return type

[**List&lt;Update&gt;**](Update.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateidget"></a>
# **UpdateIdGet**
> Update UpdateIdGet (int id)

Get an update by id

Retrieve an update by its internal id.  **Updates** are status notifications from Italy's SDI (Sistema di Interscambio) about invoices you sent. Multiple updates can exist for the same send item as the invoice progresses through the SDI workflow.  The `state` field is the most important property and can have the following values:  | Value | Name | Description | |- -- -- --|- -- -- -|- -- -- -- -- -- --| | 2 | `Inviato` | Sent to the SDI. | | 5 | `Consegnato` | Delivered to the recipient. | | 6 | `NonConsegnato` | Not delivered to the recipient. Only relevant for public administration entities. | | 7 | `Scartato` | Rejected by the SDI. | | 8 | `AccettatoDalDestinatario` | Accepted by the recipient. Only relevant for public administration entities. | | 9 | `RifiutatoDalDestinatario` | Rejected by the recipient. Only relevant for public administration entities. | | 10 | `ImpossibilitaDiRecapito` | Available on the recipient's tax drawer, but it was not possible to deliver it to the recipient's reception system. | | 11 | `DecorrenzaTermini` | A public administration entity has not responded for more than 15 days. The document is considered delivered. | | 12 | `AttestazioneTrasmissioneFattura` | A public administration entity has received the document, but has not yet processed it. |  **Important:** Always monitor the state of your sent invoices. A state of `Inviato` only means the invoice has been submitted to SDI, not that it has been delivered. A state like `Scartato` indicates that the invoice was **not** successfully delivered and may require corrective action, such as fixing validation errors and resubmitting. In that case, `description` contains the reason for the rejection.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Invoicetronic.Sdk.Api;
using Invoicetronic.Sdk.Client;
using Invoicetronic.Sdk.Model;

namespace Example
{
    public class UpdateIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.invoicetronic.com";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new UpdateApi(httpClient, config, httpClientHandler);
            var id = 56;  // int | Item id

            try
            {
                // Get an update by id
                Update result = apiInstance.UpdateIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UpdateApi.UpdateIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get an update by id
    ApiResponse<Update> response = apiInstance.UpdateIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UpdateApi.UpdateIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Item id |  |

### Return type

[**Update**](Update.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

