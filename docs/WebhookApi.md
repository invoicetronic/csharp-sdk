# Invoicetronic.InvoiceApi.Api.WebhookApi

All URIs are relative to *api.invoicetronic.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**InvoiceV1WebhookGet**](WebhookApi.md#invoicev1webhookget) | **GET** /invoice/v1/webhook | List webhooks |
| [**InvoiceV1WebhookIdDelete**](WebhookApi.md#invoicev1webhookiddelete) | **DELETE** /invoice/v1/webhook/{id} | Delete a webhook by id |
| [**InvoiceV1WebhookIdGet**](WebhookApi.md#invoicev1webhookidget) | **GET** /invoice/v1/webhook/{id} | Get a webhook by id |
| [**InvoiceV1WebhookPost**](WebhookApi.md#invoicev1webhookpost) | **POST** /invoice/v1/webhook | Add a webhook |
| [**InvoiceV1WebhookPut**](WebhookApi.md#invoicev1webhookput) | **PUT** /invoice/v1/webhook | Update a webhook |
| [**InvoiceV1WebhookhistoryGet**](WebhookApi.md#invoicev1webhookhistoryget) | **GET** /invoice/v1/webhookhistory | List webhook history items |
| [**InvoiceV1WebhookhistoryIdGet**](WebhookApi.md#invoicev1webhookhistoryidget) | **GET** /invoice/v1/webhookhistory/{id} | Get a webhook history item by id |

<a id="invoicev1webhookget"></a>
# **InvoiceV1WebhookGet**
> List&lt;WebHook&gt; InvoiceV1WebhookGet (int? page = null, int? pageSize = null)

List webhooks

Webhooks are used to notify external services about write events that occur in the API. You can subscribe to specific events and receive a notification when they occur.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Invoicetronic.InvoiceApi.Api;
using Invoicetronic.InvoiceApi.Client;
using Invoicetronic.InvoiceApi.Model;

namespace Example
{
    public class InvoiceV1WebhookGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "api.invoicetronic.com";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new WebhookApi(config);
            var page = 1;  // int? | Page number. (optional)  (default to 1)
            var pageSize = 100;  // int? | Items per page. (optional)  (default to 100)

            try
            {
                // List webhooks
                List<WebHook> result = apiInstance.InvoiceV1WebhookGet(page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookApi.InvoiceV1WebhookGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InvoiceV1WebhookGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List webhooks
    ApiResponse<List<WebHook>> response = apiInstance.InvoiceV1WebhookGetWithHttpInfo(page, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhookApi.InvoiceV1WebhookGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | Page number. | [optional] [default to 1] |
| **pageSize** | **int?** | Items per page. | [optional] [default to 100] |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="invoicev1webhookiddelete"></a>
# **InvoiceV1WebhookIdDelete**
> WebHook InvoiceV1WebhookIdDelete (int id)

Delete a webhook by id

Webhooks are used to notify external services about write events that occur in the API. You can subscribe to specific events and receive a notification when they occur.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Invoicetronic.InvoiceApi.Api;
using Invoicetronic.InvoiceApi.Client;
using Invoicetronic.InvoiceApi.Model;

namespace Example
{
    public class InvoiceV1WebhookIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "api.invoicetronic.com";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new WebhookApi(config);
            var id = 56;  // int | Item id.

            try
            {
                // Delete a webhook by id
                WebHook result = apiInstance.InvoiceV1WebhookIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookApi.InvoiceV1WebhookIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InvoiceV1WebhookIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a webhook by id
    ApiResponse<WebHook> response = apiInstance.InvoiceV1WebhookIdDeleteWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhookApi.InvoiceV1WebhookIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Item id. |  |

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

<a id="invoicev1webhookidget"></a>
# **InvoiceV1WebhookIdGet**
> WebHook InvoiceV1WebhookIdGet (int id)

Get a webhook by id

Webhooks are used to notify external services about write events that occur in the API. You can subscribe to specific events and receive a notification when they occur.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Invoicetronic.InvoiceApi.Api;
using Invoicetronic.InvoiceApi.Client;
using Invoicetronic.InvoiceApi.Model;

namespace Example
{
    public class InvoiceV1WebhookIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "api.invoicetronic.com";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new WebhookApi(config);
            var id = 56;  // int | Item id.

            try
            {
                // Get a webhook by id
                WebHook result = apiInstance.InvoiceV1WebhookIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookApi.InvoiceV1WebhookIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InvoiceV1WebhookIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a webhook by id
    ApiResponse<WebHook> response = apiInstance.InvoiceV1WebhookIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhookApi.InvoiceV1WebhookIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Item id. |  |

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

<a id="invoicev1webhookpost"></a>
# **InvoiceV1WebhookPost**
> WebHook InvoiceV1WebhookPost (WebHook webHook)

Add a webhook

Webhooks are used to notify external services about write events that occur in the API. You can subscribe to specific events and receive a notification when they occur.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Invoicetronic.InvoiceApi.Api;
using Invoicetronic.InvoiceApi.Client;
using Invoicetronic.InvoiceApi.Model;

namespace Example
{
    public class InvoiceV1WebhookPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "api.invoicetronic.com";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new WebhookApi(config);
            var webHook = new WebHook(); // WebHook | 

            try
            {
                // Add a webhook
                WebHook result = apiInstance.InvoiceV1WebhookPost(webHook);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookApi.InvoiceV1WebhookPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InvoiceV1WebhookPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add a webhook
    ApiResponse<WebHook> response = apiInstance.InvoiceV1WebhookPostWithHttpInfo(webHook);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhookApi.InvoiceV1WebhookPostWithHttpInfo: " + e.Message);
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="invoicev1webhookput"></a>
# **InvoiceV1WebhookPut**
> WebHook InvoiceV1WebhookPut (WebHook webHook)

Update a webhook

Webhooks are used to notify external services about write events that occur in the API. You can subscribe to specific events and receive a notification when they occur.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Invoicetronic.InvoiceApi.Api;
using Invoicetronic.InvoiceApi.Client;
using Invoicetronic.InvoiceApi.Model;

namespace Example
{
    public class InvoiceV1WebhookPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "api.invoicetronic.com";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new WebhookApi(config);
            var webHook = new WebHook(); // WebHook | 

            try
            {
                // Update a webhook
                WebHook result = apiInstance.InvoiceV1WebhookPut(webHook);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookApi.InvoiceV1WebhookPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InvoiceV1WebhookPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a webhook
    ApiResponse<WebHook> response = apiInstance.InvoiceV1WebhookPutWithHttpInfo(webHook);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhookApi.InvoiceV1WebhookPutWithHttpInfo: " + e.Message);
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="invoicev1webhookhistoryget"></a>
# **InvoiceV1WebhookhistoryGet**
> List&lt;WebHookHistory&gt; InvoiceV1WebhookhistoryGet (int? page = null, int? pageSize = null)

List webhook history items

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Invoicetronic.InvoiceApi.Api;
using Invoicetronic.InvoiceApi.Client;
using Invoicetronic.InvoiceApi.Model;

namespace Example
{
    public class InvoiceV1WebhookhistoryGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "api.invoicetronic.com";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new WebhookApi(config);
            var page = 1;  // int? | Page number. (optional)  (default to 1)
            var pageSize = 100;  // int? | Items per page. (optional)  (default to 100)

            try
            {
                // List webhook history items
                List<WebHookHistory> result = apiInstance.InvoiceV1WebhookhistoryGet(page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookApi.InvoiceV1WebhookhistoryGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InvoiceV1WebhookhistoryGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List webhook history items
    ApiResponse<List<WebHookHistory>> response = apiInstance.InvoiceV1WebhookhistoryGetWithHttpInfo(page, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhookApi.InvoiceV1WebhookhistoryGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | Page number. | [optional] [default to 1] |
| **pageSize** | **int?** | Items per page. | [optional] [default to 100] |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="invoicev1webhookhistoryidget"></a>
# **InvoiceV1WebhookhistoryIdGet**
> WebHookHistory InvoiceV1WebhookhistoryIdGet (int id)

Get a webhook history item by id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Invoicetronic.InvoiceApi.Api;
using Invoicetronic.InvoiceApi.Client;
using Invoicetronic.InvoiceApi.Model;

namespace Example
{
    public class InvoiceV1WebhookhistoryIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "api.invoicetronic.com";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new WebhookApi(config);
            var id = 56;  // int | Item id.

            try
            {
                // Get a webhook history item by id
                WebHookHistory result = apiInstance.InvoiceV1WebhookhistoryIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookApi.InvoiceV1WebhookhistoryIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InvoiceV1WebhookhistoryIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a webhook history item by id
    ApiResponse<WebHookHistory> response = apiInstance.InvoiceV1WebhookhistoryIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhookApi.InvoiceV1WebhookhistoryIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Item id. |  |

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

