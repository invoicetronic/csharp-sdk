# Invoicetronic.Sdk.Api.ReceiveApi

All URIs are relative to *https://api.invoicetronic.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReceiveGet**](ReceiveApi.md#receiveget) | **GET** /receive | List incoming invoices |
| [**ReceiveIdDelete**](ReceiveApi.md#receiveiddelete) | **DELETE** /receive/{id} | Delete an incoming invoice by id |
| [**ReceiveIdGet**](ReceiveApi.md#receiveidget) | **GET** /receive/{id} | Get an incoming invoice by id |

<a id="receiveget"></a>
# **ReceiveGet**
> List&lt;Receive&gt; ReceiveGet (int? companyId = null, string identifier = null, bool? unread = null, string committente = null, string prestatore = null, string fileName = null, DateTime? lastUpdateFrom = null, DateTime? lastUpdateTo = null, DateTime? dateSentFrom = null, DateTime? dateSentTo = null, DateTime? documentDateFrom = null, DateTime? documentDateTo = null, string documentNumber = null, bool? includePayload = null, int? page = null, int? pageSize = null, string sort = null)

List incoming invoices

Receive invoices are the invoices that are received from other companies. They are preserved for two years in the live environment and 24 hours in the Sandbox.

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
    public class ReceiveGetExample
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
            var apiInstance = new ReceiveApi(httpClient, config, httpClientHandler);
            var companyId = 56;  // int? | Company id (optional) 
            var identifier = "identifier_example";  // string | SDI identifier. (optional) 
            var unread = true;  // bool? | Unread items only. (optional) 
            var committente = "committente_example";  // string | Vat number or fiscal code. (optional) 
            var prestatore = "prestatore_example";  // string | Vat number or fiscal code. (optional) 
            var fileName = "fileName_example";  // string | File name. (optional) 
            var lastUpdateFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | UTC ISO 8601 (2024-11-29T12:34:56Z) (optional) 
            var lastUpdateTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | UTC ISO 8601 (2024-11-29T12:34:56Z) (optional) 
            var dateSentFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | UTC ISO 8601 (2024-11-29T12:34:56Z) (optional) 
            var dateSentTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | UTC ISO 8601 (2024-11-29T12:34:56Z) (optional) 
            var documentDateFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | UTC ISO 8601 (2024-11-29T12:34:56Z) (optional) 
            var documentDateTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | UTC ISO 8601 (2024-11-29T12:34:56Z) (optional) 
            var documentNumber = "documentNumber_example";  // string | Document number. (optional) 
            var includePayload = true;  // bool? | Include payload in the response. Defaults to false. (optional) 
            var page = 1;  // int? | Page number. Defaults to 1. (optional)  (default to 1)
            var pageSize = 100;  // int? | Items per page. Defaults to 50. Cannot be greater than 200. (optional)  (default to 100)
            var sort = "sort_example";  // string | Sort by field. Prefix with '-' for descending order. (optional) 

            try
            {
                // List incoming invoices
                List<Receive> result = apiInstance.ReceiveGet(companyId, identifier, unread, committente, prestatore, fileName, lastUpdateFrom, lastUpdateTo, dateSentFrom, dateSentTo, documentDateFrom, documentDateTo, documentNumber, includePayload, page, pageSize, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReceiveApi.ReceiveGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReceiveGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List incoming invoices
    ApiResponse<List<Receive>> response = apiInstance.ReceiveGetWithHttpInfo(companyId, identifier, unread, committente, prestatore, fileName, lastUpdateFrom, lastUpdateTo, dateSentFrom, dateSentTo, documentDateFrom, documentDateTo, documentNumber, includePayload, page, pageSize, sort);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReceiveApi.ReceiveGetWithHttpInfo: " + e.Message);
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
| **committente** | **string** | Vat number or fiscal code. | [optional]  |
| **prestatore** | **string** | Vat number or fiscal code. | [optional]  |
| **fileName** | **string** | File name. | [optional]  |
| **lastUpdateFrom** | **DateTime?** | UTC ISO 8601 (2024-11-29T12:34:56Z) | [optional]  |
| **lastUpdateTo** | **DateTime?** | UTC ISO 8601 (2024-11-29T12:34:56Z) | [optional]  |
| **dateSentFrom** | **DateTime?** | UTC ISO 8601 (2024-11-29T12:34:56Z) | [optional]  |
| **dateSentTo** | **DateTime?** | UTC ISO 8601 (2024-11-29T12:34:56Z) | [optional]  |
| **documentDateFrom** | **DateTime?** | UTC ISO 8601 (2024-11-29T12:34:56Z) | [optional]  |
| **documentDateTo** | **DateTime?** | UTC ISO 8601 (2024-11-29T12:34:56Z) | [optional]  |
| **documentNumber** | **string** | Document number. | [optional]  |
| **includePayload** | **bool?** | Include payload in the response. Defaults to false. | [optional]  |
| **page** | **int?** | Page number. Defaults to 1. | [optional] [default to 1] |
| **pageSize** | **int?** | Items per page. Defaults to 50. Cannot be greater than 200. | [optional] [default to 100] |
| **sort** | **string** | Sort by field. Prefix with &#39;-&#39; for descending order. | [optional]  |

### Return type

[**List&lt;Receive&gt;**](Receive.md)

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

<a id="receiveiddelete"></a>
# **ReceiveIdDelete**
> Receive ReceiveIdDelete (int id)

Delete an incoming invoice by id

Receive invoices are the invoices that are received from other companies. They are preserved for two years in the live environment and 24 hours in the Sandbox.

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
    public class ReceiveIdDeleteExample
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
            var apiInstance = new ReceiveApi(httpClient, config, httpClientHandler);
            var id = 56;  // int | Item id

            try
            {
                // Delete an incoming invoice by id
                Receive result = apiInstance.ReceiveIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReceiveApi.ReceiveIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReceiveIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an incoming invoice by id
    ApiResponse<Receive> response = apiInstance.ReceiveIdDeleteWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReceiveApi.ReceiveIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Item id |  |

### Return type

[**Receive**](Receive.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **422** | Unprocessable Content |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="receiveidget"></a>
# **ReceiveIdGet**
> Receive ReceiveIdGet (int id)

Get an incoming invoice by id

Receive invoices are the invoices that are received from other companies. They are preserved for two years in the live environment and 24 hours in the Sandbox.

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
    public class ReceiveIdGetExample
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
            var apiInstance = new ReceiveApi(httpClient, config, httpClientHandler);
            var id = 56;  // int | Item id

            try
            {
                // Get an incoming invoice by id
                Receive result = apiInstance.ReceiveIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReceiveApi.ReceiveIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReceiveIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get an incoming invoice by id
    ApiResponse<Receive> response = apiInstance.ReceiveIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReceiveApi.ReceiveIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Item id |  |

### Return type

[**Receive**](Receive.md)

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

