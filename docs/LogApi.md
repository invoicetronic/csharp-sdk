# Invoicetronic.Invoice.Sdk.Api.LogApi

All URIs are relative to *https://api.invoicetronic.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**InvoiceV1LogGet**](LogApi.md#invoicev1logget) | **GET** /invoice/v1/log | List events |
| [**InvoiceV1LogIdGet**](LogApi.md#invoicev1logidget) | **GET** /invoice/v1/log/{id} | Get an event by id |

<a id="invoicev1logget"></a>
# **InvoiceV1LogGet**
> List&lt;Event&gt; InvoiceV1LogGet (int? companyId = null, string endpoint = null, string method = null, int? apiVerion = null, int? statusCode = null, DateTime? dateCreatedFrom = null, DateTime? dateCreatedTo = null, int? page = null, int? pageSize = null)

List events

Every API operation is logged and can be retrieved here.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Invoicetronic.Invoice.Sdk.Api;
using Invoicetronic.Invoice.Sdk.Client;
using Invoicetronic.Invoice.Sdk.Model;

namespace Example
{
    public class InvoiceV1LogGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.invoicetronic.com";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new LogApi(config);
            var companyId = 56;  // int? | Company id (optional) 
            var endpoint = "endpoint_example";  // string |  (optional) 
            var method = "method_example";  // string |  (optional) 
            var apiVerion = 56;  // int? | Api version (optional) 
            var statusCode = 56;  // int? | Response status code (optional) 
            var dateCreatedFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | UTC ISO 8601 (2024-11-29T12:34:56Z) (optional) 
            var dateCreatedTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | UTC ISO 8601 (2024-11-29T12:34:56Z) (optional) 
            var page = 1;  // int? | Page number. Defaults to 1. (optional)  (default to 1)
            var pageSize = 100;  // int? | Items per page. Defaults to 50. Cannot be greater than 200. (optional)  (default to 100)

            try
            {
                // List events
                List<Event> result = apiInstance.InvoiceV1LogGet(companyId, endpoint, method, apiVerion, statusCode, dateCreatedFrom, dateCreatedTo, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LogApi.InvoiceV1LogGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InvoiceV1LogGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List events
    ApiResponse<List<Event>> response = apiInstance.InvoiceV1LogGetWithHttpInfo(companyId, endpoint, method, apiVerion, statusCode, dateCreatedFrom, dateCreatedTo, page, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LogApi.InvoiceV1LogGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int?** | Company id | [optional]  |
| **endpoint** | **string** |  | [optional]  |
| **method** | **string** |  | [optional]  |
| **apiVerion** | **int?** | Api version | [optional]  |
| **statusCode** | **int?** | Response status code | [optional]  |
| **dateCreatedFrom** | **DateTime?** | UTC ISO 8601 (2024-11-29T12:34:56Z) | [optional]  |
| **dateCreatedTo** | **DateTime?** | UTC ISO 8601 (2024-11-29T12:34:56Z) | [optional]  |
| **page** | **int?** | Page number. Defaults to 1. | [optional] [default to 1] |
| **pageSize** | **int?** | Items per page. Defaults to 50. Cannot be greater than 200. | [optional] [default to 100] |

### Return type

[**List&lt;Event&gt;**](Event.md)

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

<a id="invoicev1logidget"></a>
# **InvoiceV1LogIdGet**
> Event InvoiceV1LogIdGet (int id)

Get an event by id

Every API operation is logged and can be retrieved here.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Invoicetronic.Invoice.Sdk.Api;
using Invoicetronic.Invoice.Sdk.Client;
using Invoicetronic.Invoice.Sdk.Model;

namespace Example
{
    public class InvoiceV1LogIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.invoicetronic.com";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new LogApi(config);
            var id = 56;  // int | Item id

            try
            {
                // Get an event by id
                Event result = apiInstance.InvoiceV1LogIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LogApi.InvoiceV1LogIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InvoiceV1LogIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get an event by id
    ApiResponse<Event> response = apiInstance.InvoiceV1LogIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LogApi.InvoiceV1LogIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Item id |  |

### Return type

[**Event**](Event.md)

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

