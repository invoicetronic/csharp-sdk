# Invoicetronic.Sdk.Api.LogApi

All URIs are relative to *https://api.invoicetronic.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**LogGet**](LogApi.md#logget) | **GET** /log | List events |
| [**LogIdGet**](LogApi.md#logidget) | **GET** /log/{id} | Get an event by id |

<a id="logget"></a>
# **LogGet**
> List&lt;Event&gt; LogGet (int companyId = null, string endpoint = null, string method = null, int apiVerion = null, int statusCode = null, DateTime dateCreatedFrom = null, DateTime dateCreatedTo = null, int page = null, int pageSize = null, string sort = null, string query = null, bool success = null, DateTime dateTimeFrom = null, DateTime dateTimeTo = null)

List events

Every API operation is logged and can be retrieved here. Log records are preserved for 15 days.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Invoicetronic.Sdk.Api;
using Invoicetronic.Sdk.Client;
using Invoicetronic.Sdk.Model;

namespace Example
{
    public class LogGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.invoicetronic.com";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new LogApi(config);
            var companyId = 56;  // int | Company id (optional) 
            var endpoint = "endpoint_example";  // string |  (optional) 
            var method = "method_example";  // string |  (optional) 
            var apiVerion = 56;  // int | Api version (optional) 
            var statusCode = 56;  // int | Response status code (optional) 
            var dateCreatedFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | UTC ISO 8601 (2024-11-29T12:34:56Z) (optional) 
            var dateCreatedTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | UTC ISO 8601 (2024-11-29T12:34:56Z) (optional) 
            var page = 1;  // int | Page number. Defaults to 1. (optional)  (default to 1)
            var pageSize = 100;  // int | Items per page. Defaults to 50. Cannot be greater than 200. (optional)  (default to 100)
            var sort = "sort_example";  // string | Sort by field. Prefix with '-' for descending order. (optional) 
            var query = "query_example";  // string |  (optional) 
            var success = true;  // bool |  (optional) 
            var dateTimeFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Date and time of the event (optional) 
            var dateTimeTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Date and time of the event (optional) 

            try
            {
                // List events
                List<Event> result = apiInstance.LogGet(companyId, endpoint, method, apiVerion, statusCode, dateCreatedFrom, dateCreatedTo, page, pageSize, sort, query, success, dateTimeFrom, dateTimeTo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LogApi.LogGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LogGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List events
    ApiResponse<List<Event>> response = apiInstance.LogGetWithHttpInfo(companyId, endpoint, method, apiVerion, statusCode, dateCreatedFrom, dateCreatedTo, page, pageSize, sort, query, success, dateTimeFrom, dateTimeTo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LogApi.LogGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | Company id | [optional]  |
| **endpoint** | **string** |  | [optional]  |
| **method** | **string** |  | [optional]  |
| **apiVerion** | **int** | Api version | [optional]  |
| **statusCode** | **int** | Response status code | [optional]  |
| **dateCreatedFrom** | **DateTime** | UTC ISO 8601 (2024-11-29T12:34:56Z) | [optional]  |
| **dateCreatedTo** | **DateTime** | UTC ISO 8601 (2024-11-29T12:34:56Z) | [optional]  |
| **page** | **int** | Page number. Defaults to 1. | [optional] [default to 1] |
| **pageSize** | **int** | Items per page. Defaults to 50. Cannot be greater than 200. | [optional] [default to 100] |
| **sort** | **string** | Sort by field. Prefix with &#39;-&#39; for descending order. | [optional]  |
| **query** | **string** |  | [optional]  |
| **success** | **bool** |  | [optional]  |
| **dateTimeFrom** | **DateTime** | Date and time of the event | [optional]  |
| **dateTimeTo** | **DateTime** | Date and time of the event | [optional]  |

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="logidget"></a>
# **LogIdGet**
> Event LogIdGet (int id)

Get an event by id

Every API operation is logged and can be retrieved here. Log records are preserved for 15 days.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Invoicetronic.Sdk.Api;
using Invoicetronic.Sdk.Client;
using Invoicetronic.Sdk.Model;

namespace Example
{
    public class LogIdGetExample
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
                Event result = apiInstance.LogIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LogApi.LogIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LogIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get an event by id
    ApiResponse<Event> response = apiInstance.LogIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LogApi.LogIdGetWithHttpInfo: " + e.Message);
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

