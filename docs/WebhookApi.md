# Invoicetronic.Sdk.Api.WebhookApi

All URIs are relative to *https://api.invoicetronic.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**WebhookGet**](WebhookApi.md#webhookget) | **GET** /webhook | List webhooks |
| [**WebhookIdDelete**](WebhookApi.md#webhookiddelete) | **DELETE** /webhook/{id} | Delete a webhook by id |
| [**WebhookIdGet**](WebhookApi.md#webhookidget) | **GET** /webhook/{id} | Get a webhook by id |
| [**WebhookPost**](WebhookApi.md#webhookpost) | **POST** /webhook | Add a webhook |
| [**WebhookPut**](WebhookApi.md#webhookput) | **PUT** /webhook | Update a webhook |
| [**WebhookhistoryGet**](WebhookApi.md#webhookhistoryget) | **GET** /webhookhistory | List webhook history items |
| [**WebhookhistoryIdGet**](WebhookApi.md#webhookhistoryidget) | **GET** /webhookhistory/{id} | Get a webhook history item by id |

<a id="webhookget"></a>
# **WebhookGet**
> List&lt;WebHook&gt; WebhookGet (int? companyId = null, int? page = null, int? pageSize = null, string sort = null, string description = null, bool? enabled = null, string events = null, string url = null)

List webhooks

Webhooks are used to notify external services about write events that occur in the API. You can subscribe to specific events and receive a notification when they occur.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Invoicetronic.Sdk.Api;
using Invoicetronic.Sdk.Client;
using Invoicetronic.Sdk.Model;

namespace Example
{
    public class WebhookGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.invoicetronic.com";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new WebhookApi(config);
            var companyId = 56;  // int? | Company id (optional) 
            var page = 1;  // int? | Page number. Defaults to 1. (optional)  (default to 1)
            var pageSize = 100;  // int? | Items per page. Defaults to 50. Cannot be greater than 200. (optional)  (default to 100)
            var sort = "sort_example";  // string | Sort by field. Prefix with '-' for descending order. (optional) 
            var description = "description_example";  // string |  (optional) 
            var enabled = true;  // bool? |  (optional) 
            var events = "events_example";  // string |  (optional) 
            var url = "url_example";  // string |  (optional) 

            try
            {
                // List webhooks
                List<WebHook> result = apiInstance.WebhookGet(companyId, page, pageSize, sort, description, enabled, events, url);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookApi.WebhookGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebhookGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List webhooks
    ApiResponse<List<WebHook>> response = apiInstance.WebhookGetWithHttpInfo(companyId, page, pageSize, sort, description, enabled, events, url);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhookApi.WebhookGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int?** | Company id | [optional]  |
| **page** | **int?** | Page number. Defaults to 1. | [optional] [default to 1] |
| **pageSize** | **int?** | Items per page. Defaults to 50. Cannot be greater than 200. | [optional] [default to 100] |
| **sort** | **string** | Sort by field. Prefix with &#39;-&#39; for descending order. | [optional]  |
| **description** | **string** |  | [optional]  |
| **enabled** | **bool?** |  | [optional]  |
| **events** | **string** |  | [optional]  |
| **url** | **string** |  | [optional]  |

### Return type

[**List&lt;WebHook&gt;**](WebHook.md)

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

<a id="webhookiddelete"></a>
# **WebhookIdDelete**
> WebHook WebhookIdDelete (int id)

Delete a webhook by id

Webhooks are used to notify external services about write events that occur in the API. You can subscribe to specific events and receive a notification when they occur.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Invoicetronic.Sdk.Api;
using Invoicetronic.Sdk.Client;
using Invoicetronic.Sdk.Model;

namespace Example
{
    public class WebhookIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.invoicetronic.com";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new WebhookApi(config);
            var id = 56;  // int | Item id

            try
            {
                // Delete a webhook by id
                WebHook result = apiInstance.WebhookIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookApi.WebhookIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebhookIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a webhook by id
    ApiResponse<WebHook> response = apiInstance.WebhookIdDeleteWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhookApi.WebhookIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Item id |  |

### Return type

[**WebHook**](WebHook.md)

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

<a id="webhookidget"></a>
# **WebhookIdGet**
> WebHook WebhookIdGet (int id)

Get a webhook by id

Webhooks are used to notify external services about write events that occur in the API. You can subscribe to specific events and receive a notification when they occur.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Invoicetronic.Sdk.Api;
using Invoicetronic.Sdk.Client;
using Invoicetronic.Sdk.Model;

namespace Example
{
    public class WebhookIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.invoicetronic.com";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new WebhookApi(config);
            var id = 56;  // int | Item id

            try
            {
                // Get a webhook by id
                WebHook result = apiInstance.WebhookIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookApi.WebhookIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebhookIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a webhook by id
    ApiResponse<WebHook> response = apiInstance.WebhookIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhookApi.WebhookIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Item id |  |

### Return type

[**WebHook**](WebHook.md)

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

<a id="webhookpost"></a>
# **WebhookPost**
> WebHook WebhookPost (WebHook webHook)

Add a webhook

Webhooks are used to notify external services about write events that occur in the API. You can subscribe to specific events and receive a notification when they occur.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Invoicetronic.Sdk.Api;
using Invoicetronic.Sdk.Client;
using Invoicetronic.Sdk.Model;

namespace Example
{
    public class WebhookPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.invoicetronic.com";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new WebhookApi(config);
            var webHook = new WebHook(); // WebHook | 

            try
            {
                // Add a webhook
                WebHook result = apiInstance.WebhookPost(webHook);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookApi.WebhookPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebhookPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add a webhook
    ApiResponse<WebHook> response = apiInstance.WebhookPostWithHttpInfo(webHook);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhookApi.WebhookPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **webHook** | [**WebHook**](WebHook.md) |  |  |

### Return type

[**WebHook**](WebHook.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Bad Request |  -  |
| **422** | Unprocessable Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="webhookput"></a>
# **WebhookPut**
> WebHook WebhookPut (WebHook webHook)

Update a webhook

Webhooks are used to notify external services about write events that occur in the API. You can subscribe to specific events and receive a notification when they occur.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Invoicetronic.Sdk.Api;
using Invoicetronic.Sdk.Client;
using Invoicetronic.Sdk.Model;

namespace Example
{
    public class WebhookPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.invoicetronic.com";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new WebhookApi(config);
            var webHook = new WebHook(); // WebHook | 

            try
            {
                // Update a webhook
                WebHook result = apiInstance.WebhookPut(webHook);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookApi.WebhookPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebhookPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a webhook
    ApiResponse<WebHook> response = apiInstance.WebhookPutWithHttpInfo(webHook);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhookApi.WebhookPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **webHook** | [**WebHook**](WebHook.md) |  |  |

### Return type

[**WebHook**](WebHook.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **422** | Unprocessable Content |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="webhookhistoryget"></a>
# **WebhookhistoryGet**
> List&lt;WebHookHistory&gt; WebhookhistoryGet (int? page = null, int? pageSize = null, string sort = null, int? webhookId = null)

List webhook history items

Webhook history items are stored in the database and can be accessed via the API. They are preserved for 15 in both the live and sandbox environments.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Invoicetronic.Sdk.Api;
using Invoicetronic.Sdk.Client;
using Invoicetronic.Sdk.Model;

namespace Example
{
    public class WebhookhistoryGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.invoicetronic.com";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new WebhookApi(config);
            var page = 1;  // int? | Page number. Defaults to 1. (optional)  (default to 1)
            var pageSize = 100;  // int? | Items per page. Defaults to 50. Cannot be greater than 200. (optional)  (default to 100)
            var sort = "sort_example";  // string | Sort by field. Prefix with '-' for descending order. (optional) 
            var webhookId = 56;  // int? | WebHook id (optional) 

            try
            {
                // List webhook history items
                List<WebHookHistory> result = apiInstance.WebhookhistoryGet(page, pageSize, sort, webhookId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookApi.WebhookhistoryGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebhookhistoryGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List webhook history items
    ApiResponse<List<WebHookHistory>> response = apiInstance.WebhookhistoryGetWithHttpInfo(page, pageSize, sort, webhookId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhookApi.WebhookhistoryGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | Page number. Defaults to 1. | [optional] [default to 1] |
| **pageSize** | **int?** | Items per page. Defaults to 50. Cannot be greater than 200. | [optional] [default to 100] |
| **sort** | **string** | Sort by field. Prefix with &#39;-&#39; for descending order. | [optional]  |
| **webhookId** | **int?** | WebHook id | [optional]  |

### Return type

[**List&lt;WebHookHistory&gt;**](WebHookHistory.md)

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

<a id="webhookhistoryidget"></a>
# **WebhookhistoryIdGet**
> WebHookHistory WebhookhistoryIdGet (int id)

Get a webhook history item by id

Webhook history items are stored in the database and can be accessed via the API. They are preserved for 15 in both the live and sandbox environments.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Invoicetronic.Sdk.Api;
using Invoicetronic.Sdk.Client;
using Invoicetronic.Sdk.Model;

namespace Example
{
    public class WebhookhistoryIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.invoicetronic.com";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new WebhookApi(config);
            var id = 56;  // int | Item id

            try
            {
                // Get a webhook history item by id
                WebHookHistory result = apiInstance.WebhookhistoryIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookApi.WebhookhistoryIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebhookhistoryIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a webhook history item by id
    ApiResponse<WebHookHistory> response = apiInstance.WebhookhistoryIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhookApi.WebhookhistoryIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Item id |  |

### Return type

[**WebHookHistory**](WebHookHistory.md)

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

