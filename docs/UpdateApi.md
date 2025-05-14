# Invoicetronic.Sdk.Api.UpdateApi

All URIs are relative to *https://api.invoicetronic.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UpdateGet**](UpdateApi.md#updateget) | **GET** /update | List updates |
| [**UpdateIdGet**](UpdateApi.md#updateidget) | **GET** /update/{id} | Get an update by id |

<a id="updateget"></a>
# **UpdateGet**
> List&lt;Update&gt; UpdateGet (int? companyId = null, string identifier = null, bool? unread = null, int? sendId = null, string state = null, DateTime? lastUpdateFrom = null, DateTime? lastUpdateTo = null, DateTime? dateSentFrom = null, DateTime? dateSentTo = null, int? page = null, int? pageSize = null, string sort = null)

List updates

Updates are notifications sent by the SDI about the status of invoices you sent.

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
            var unread = true;  // bool? | Unread items only. (optional) 
            var sendId = 56;  // int? | Send item's id. (optional) 
            var state = "Inviato";  // string | SDI state (optional) 
            var lastUpdateFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | UTC ISO 8601 (2024-11-29T12:34:56Z) (optional) 
            var lastUpdateTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | UTC ISO 8601 (2024-11-29T12:34:56Z) (optional) 
            var dateSentFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | UTC ISO 8601 (2024-11-29T12:34:56Z) (optional) 
            var dateSentTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | UTC ISO 8601 (2024-11-29T12:34:56Z) (optional) 
            var page = 1;  // int? | Page number. Defaults to 1. (optional)  (default to 1)
            var pageSize = 100;  // int? | Items per page. Defaults to 50. Cannot be greater than 200. (optional)  (default to 100)
            var sort = "sort_example";  // string | Sort by field. Prefix with '-' for descending order. (optional) 

            try
            {
                // List updates
                List<Update> result = apiInstance.UpdateGet(companyId, identifier, unread, sendId, state, lastUpdateFrom, lastUpdateTo, dateSentFrom, dateSentTo, page, pageSize, sort);
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
    ApiResponse<List<Update>> response = apiInstance.UpdateGetWithHttpInfo(companyId, identifier, unread, sendId, state, lastUpdateFrom, lastUpdateTo, dateSentFrom, dateSentTo, page, pageSize, sort);
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
| **unread** | **bool?** | Unread items only. | [optional]  |
| **sendId** | **int?** | Send item&#39;s id. | [optional]  |
| **state** | **string** | SDI state | [optional]  |
| **lastUpdateFrom** | **DateTime?** | UTC ISO 8601 (2024-11-29T12:34:56Z) | [optional]  |
| **lastUpdateTo** | **DateTime?** | UTC ISO 8601 (2024-11-29T12:34:56Z) | [optional]  |
| **dateSentFrom** | **DateTime?** | UTC ISO 8601 (2024-11-29T12:34:56Z) | [optional]  |
| **dateSentTo** | **DateTime?** | UTC ISO 8601 (2024-11-29T12:34:56Z) | [optional]  |
| **page** | **int?** | Page number. Defaults to 1. | [optional] [default to 1] |
| **pageSize** | **int?** | Items per page. Defaults to 50. Cannot be greater than 200. | [optional] [default to 100] |
| **sort** | **string** | Sort by field. Prefix with &#39;-&#39; for descending order. | [optional]  |

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

Updates are notifications sent by the SDI about the status of invoices you sent.

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

