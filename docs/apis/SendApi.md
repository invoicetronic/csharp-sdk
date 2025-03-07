# Invoicetronic.Sdk.Api.SendApi

All URIs are relative to *https://api.invoicetronic.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SendFilePost**](SendApi.md#sendfilepost) | **POST** /send/file | Add an invoice by file |
| [**SendGet**](SendApi.md#sendget) | **GET** /send | List invoices |
| [**SendIdGet**](SendApi.md#sendidget) | **GET** /send/{id} | Get a invoice by id |
| [**SendJsonPost**](SendApi.md#sendjsonpost) | **POST** /send/json | Add an invoice by json |
| [**SendPost**](SendApi.md#sendpost) | **POST** /send | Add an invoice |
| [**SendValidateFilesPost**](SendApi.md#sendvalidatefilespost) | **POST** /send/validate/files | Validate an invoice by file |
| [**SendValidateJsonPost**](SendApi.md#sendvalidatejsonpost) | **POST** /send/validate/json | Validate an invoice by json |
| [**SendValidatePost**](SendApi.md#sendvalidatepost) | **POST** /send/validate | Validate an invoice |
| [**SendValidateXmlPost**](SendApi.md#sendvalidatexmlpost) | **POST** /send/validate/xml | Validate an invoice by xml |
| [**SendXmlPost**](SendApi.md#sendxmlpost) | **POST** /send/xml | Add an invoice by xml |

<a id="sendfilepost"></a>
# **SendFilePost**
> Send SendFilePost (System.IO.Stream file, bool validate = null, string signature = null)

Add an invoice by file

Send invoices are the invoices that are sent to the SDI. They are preserved for two years in the live environment and 15 days in the Sandbox.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Invoicetronic.Sdk.Api;
using Invoicetronic.Sdk.Client;
using Invoicetronic.Sdk.Model;

namespace Example
{
    public class SendFilePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.invoicetronic.com";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SendApi(config);
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | 
            var validate = false;  // bool | Validate the document first, and reject it on failure. (optional)  (default to false)
            var signature = "None";  // string | Whether to digitally sign the document. (optional)  (default to Auto)

            try
            {
                // Add an invoice by file
                Send result = apiInstance.SendFilePost(file, validate, signature);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SendApi.SendFilePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendFilePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add an invoice by file
    ApiResponse<Send> response = apiInstance.SendFilePostWithHttpInfo(file, validate, signature);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SendApi.SendFilePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **file** | **System.IO.Stream****System.IO.Stream** |  |  |
| **validate** | **bool** | Validate the document first, and reject it on failure. | [optional] [default to false] |
| **signature** | **string** | Whether to digitally sign the document. | [optional] [default to Auto] |

### Return type

[**Send**](Send.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Bad Request |  -  |
| **422** | Unprocessable Content |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="sendget"></a>
# **SendGet**
> List&lt;Send&gt; SendGet (int companyId = null, string identifier = null, string committente = null, string prestatore = null, string fileName = null, DateTime lastUpdateFrom = null, DateTime lastUpdateTo = null, DateTime dateSentFrom = null, DateTime dateSentTo = null, DateTime documentDateFrom = null, DateTime documentDateTo = null, string documentNumber = null, int page = null, int pageSize = null, string sort = null)

List invoices

test **markdown**.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Invoicetronic.Sdk.Api;
using Invoicetronic.Sdk.Client;
using Invoicetronic.Sdk.Model;

namespace Example
{
    public class SendGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.invoicetronic.com";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SendApi(config);
            var companyId = 56;  // int | Company id (optional) 
            var identifier = "identifier_example";  // string | SDI identifier. (optional) 
            var committente = "committente_example";  // string | Vat number or fiscal code. (optional) 
            var prestatore = "prestatore_example";  // string | Vat number or fiscal code. (optional) 
            var fileName = "fileName_example";  // string | File name. (optional) 
            var lastUpdateFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | UTC ISO 8601 (2024-11-29T12:34:56Z) (optional) 
            var lastUpdateTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | UTC ISO 8601 (2024-11-29T12:34:56Z) (optional) 
            var dateSentFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | UTC ISO 8601 (2024-11-29T12:34:56Z) (optional) 
            var dateSentTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | UTC ISO 8601 (2024-11-29T12:34:56Z) (optional) 
            var documentDateFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | UTC ISO 8601 (2024-11-29T12:34:56Z) (optional) 
            var documentDateTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | UTC ISO 8601 (2024-11-29T12:34:56Z) (optional) 
            var documentNumber = "documentNumber_example";  // string | Document number. (optional) 
            var page = 1;  // int | Page number. Defaults to 1. (optional)  (default to 1)
            var pageSize = 100;  // int | Items per page. Defaults to 50. Cannot be greater than 200. (optional)  (default to 100)
            var sort = "sort_example";  // string | Sort by field. Prefix with '-' for descending order. (optional) 

            try
            {
                // List invoices
                List<Send> result = apiInstance.SendGet(companyId, identifier, committente, prestatore, fileName, lastUpdateFrom, lastUpdateTo, dateSentFrom, dateSentTo, documentDateFrom, documentDateTo, documentNumber, page, pageSize, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SendApi.SendGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List invoices
    ApiResponse<List<Send>> response = apiInstance.SendGetWithHttpInfo(companyId, identifier, committente, prestatore, fileName, lastUpdateFrom, lastUpdateTo, dateSentFrom, dateSentTo, documentDateFrom, documentDateTo, documentNumber, page, pageSize, sort);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SendApi.SendGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | Company id | [optional]  |
| **identifier** | **string** | SDI identifier. | [optional]  |
| **committente** | **string** | Vat number or fiscal code. | [optional]  |
| **prestatore** | **string** | Vat number or fiscal code. | [optional]  |
| **fileName** | **string** | File name. | [optional]  |
| **lastUpdateFrom** | **DateTime** | UTC ISO 8601 (2024-11-29T12:34:56Z) | [optional]  |
| **lastUpdateTo** | **DateTime** | UTC ISO 8601 (2024-11-29T12:34:56Z) | [optional]  |
| **dateSentFrom** | **DateTime** | UTC ISO 8601 (2024-11-29T12:34:56Z) | [optional]  |
| **dateSentTo** | **DateTime** | UTC ISO 8601 (2024-11-29T12:34:56Z) | [optional]  |
| **documentDateFrom** | **DateTime** | UTC ISO 8601 (2024-11-29T12:34:56Z) | [optional]  |
| **documentDateTo** | **DateTime** | UTC ISO 8601 (2024-11-29T12:34:56Z) | [optional]  |
| **documentNumber** | **string** | Document number. | [optional]  |
| **page** | **int** | Page number. Defaults to 1. | [optional] [default to 1] |
| **pageSize** | **int** | Items per page. Defaults to 50. Cannot be greater than 200. | [optional] [default to 100] |
| **sort** | **string** | Sort by field. Prefix with &#39;-&#39; for descending order. | [optional]  |

### Return type

[**List&lt;Send&gt;**](Send.md)

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

<a id="sendidget"></a>
# **SendIdGet**
> Send SendIdGet (int id)

Get a invoice by id

Send invoices are the invoices that are sent to the SDI. They are preserved for two years in the live environment and 15 days in the Sandbox.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Invoicetronic.Sdk.Api;
using Invoicetronic.Sdk.Client;
using Invoicetronic.Sdk.Model;

namespace Example
{
    public class SendIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.invoicetronic.com";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SendApi(config);
            var id = 56;  // int | Item id

            try
            {
                // Get a invoice by id
                Send result = apiInstance.SendIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SendApi.SendIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a invoice by id
    ApiResponse<Send> response = apiInstance.SendIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SendApi.SendIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Item id |  |

### Return type

[**Send**](Send.md)

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

<a id="sendjsonpost"></a>
# **SendJsonPost**
> Send SendJsonPost (FatturaOrdinaria fatturaOrdinaria, bool validate = null, string signature = null)

Add an invoice by json

Send invoices are the invoices that are sent to the SDI. They are preserved for two years in the live environment and 15 days in the Sandbox.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Invoicetronic.Sdk.Api;
using Invoicetronic.Sdk.Client;
using Invoicetronic.Sdk.Model;

namespace Example
{
    public class SendJsonPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.invoicetronic.com";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SendApi(config);
            var fatturaOrdinaria = new FatturaOrdinaria(); // FatturaOrdinaria | 
            var validate = false;  // bool | Validate the document first, and reject it on failure. (optional)  (default to false)
            var signature = "None";  // string | Whether to digitally sign the document. (optional)  (default to Auto)

            try
            {
                // Add an invoice by json
                Send result = apiInstance.SendJsonPost(fatturaOrdinaria, validate, signature);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SendApi.SendJsonPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendJsonPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add an invoice by json
    ApiResponse<Send> response = apiInstance.SendJsonPostWithHttpInfo(fatturaOrdinaria, validate, signature);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SendApi.SendJsonPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fatturaOrdinaria** | [**FatturaOrdinaria**](FatturaOrdinaria.md) |  |  |
| **validate** | **bool** | Validate the document first, and reject it on failure. | [optional] [default to false] |
| **signature** | **string** | Whether to digitally sign the document. | [optional] [default to Auto] |

### Return type

[**Send**](Send.md)

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="sendpost"></a>
# **SendPost**
> Send SendPost (Send send, bool validate = null, string signature = null)

Add an invoice

Send invoices are the invoices that are sent to the SDI. They are preserved for two years in the live environment and 15 days in the Sandbox.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Invoicetronic.Sdk.Api;
using Invoicetronic.Sdk.Client;
using Invoicetronic.Sdk.Model;

namespace Example
{
    public class SendPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.invoicetronic.com";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SendApi(config);
            var send = new Send(); // Send | 
            var validate = false;  // bool | Validate the document first, and reject it on failure. (optional)  (default to false)
            var signature = "None";  // string | Whether to digitally sign the document. (optional)  (default to Auto)

            try
            {
                // Add an invoice
                Send result = apiInstance.SendPost(send, validate, signature);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SendApi.SendPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add an invoice
    ApiResponse<Send> response = apiInstance.SendPostWithHttpInfo(send, validate, signature);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SendApi.SendPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **send** | [**Send**](Send.md) |  |  |
| **validate** | **bool** | Validate the document first, and reject it on failure. | [optional] [default to false] |
| **signature** | **string** | Whether to digitally sign the document. | [optional] [default to Auto] |

### Return type

[**Send**](Send.md)

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="sendvalidatefilespost"></a>
# **SendValidateFilesPost**
> void SendValidateFilesPost (List<System.IO.Stream> files)

Validate an invoice by file

Send invoices are the invoices that are sent to the SDI. They are preserved for two years in the live environment and 15 days in the Sandbox.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Invoicetronic.Sdk.Api;
using Invoicetronic.Sdk.Client;
using Invoicetronic.Sdk.Model;

namespace Example
{
    public class SendValidateFilesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.invoicetronic.com";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SendApi(config);
            var files = new List<System.IO.Stream>(); // List<System.IO.Stream> | 

            try
            {
                // Validate an invoice by file
                apiInstance.SendValidateFilesPost(files);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SendApi.SendValidateFilesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendValidateFilesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Validate an invoice by file
    apiInstance.SendValidateFilesPostWithHttpInfo(files);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SendApi.SendValidateFilesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **files** | **List&lt;System.IO.Stream&gt;** |  |  |

### Return type

void (empty response body)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **400** | Bad Request |  -  |
| **422** | Unprocessable Content |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="sendvalidatejsonpost"></a>
# **SendValidateJsonPost**
> void SendValidateJsonPost (FatturaOrdinaria fatturaOrdinaria)

Validate an invoice by json

Send invoices are the invoices that are sent to the SDI. They are preserved for two years in the live environment and 15 days in the Sandbox.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Invoicetronic.Sdk.Api;
using Invoicetronic.Sdk.Client;
using Invoicetronic.Sdk.Model;

namespace Example
{
    public class SendValidateJsonPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.invoicetronic.com";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SendApi(config);
            var fatturaOrdinaria = new FatturaOrdinaria(); // FatturaOrdinaria | 

            try
            {
                // Validate an invoice by json
                apiInstance.SendValidateJsonPost(fatturaOrdinaria);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SendApi.SendValidateJsonPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendValidateJsonPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Validate an invoice by json
    apiInstance.SendValidateJsonPostWithHttpInfo(fatturaOrdinaria);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SendApi.SendValidateJsonPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fatturaOrdinaria** | [**FatturaOrdinaria**](FatturaOrdinaria.md) |  |  |

### Return type

void (empty response body)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **400** | Bad Request |  -  |
| **422** | Unprocessable Content |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="sendvalidatepost"></a>
# **SendValidatePost**
> void SendValidatePost (Send send)

Validate an invoice

Send invoices are the invoices that are sent to the SDI. They are preserved for two years in the live environment and 15 days in the Sandbox.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Invoicetronic.Sdk.Api;
using Invoicetronic.Sdk.Client;
using Invoicetronic.Sdk.Model;

namespace Example
{
    public class SendValidatePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.invoicetronic.com";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SendApi(config);
            var send = new Send(); // Send | 

            try
            {
                // Validate an invoice
                apiInstance.SendValidatePost(send);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SendApi.SendValidatePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendValidatePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Validate an invoice
    apiInstance.SendValidatePostWithHttpInfo(send);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SendApi.SendValidatePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **send** | [**Send**](Send.md) |  |  |

### Return type

void (empty response body)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **400** | Bad Request |  -  |
| **422** | Unprocessable Content |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="sendvalidatexmlpost"></a>
# **SendValidateXmlPost**
> void SendValidateXmlPost (FatturaOrdinaria fatturaOrdinaria)

Validate an invoice by xml

Send invoices are the invoices that are sent to the SDI. They are preserved for two years in the live environment and 15 days in the Sandbox.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Invoicetronic.Sdk.Api;
using Invoicetronic.Sdk.Client;
using Invoicetronic.Sdk.Model;

namespace Example
{
    public class SendValidateXmlPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.invoicetronic.com";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SendApi(config);
            var fatturaOrdinaria = new FatturaOrdinaria(); // FatturaOrdinaria | 

            try
            {
                // Validate an invoice by xml
                apiInstance.SendValidateXmlPost(fatturaOrdinaria);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SendApi.SendValidateXmlPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendValidateXmlPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Validate an invoice by xml
    apiInstance.SendValidateXmlPostWithHttpInfo(fatturaOrdinaria);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SendApi.SendValidateXmlPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fatturaOrdinaria** | [**FatturaOrdinaria**](FatturaOrdinaria.md) |  |  |

### Return type

void (empty response body)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **400** | Bad Request |  -  |
| **422** | Unprocessable Content |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="sendxmlpost"></a>
# **SendXmlPost**
> Send SendXmlPost (FatturaOrdinaria fatturaOrdinaria, bool validate = null, string signature = null)

Add an invoice by xml

Send invoices are the invoices that are sent to the SDI. They are preserved for two years in the live environment and 15 days in the Sandbox.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Invoicetronic.Sdk.Api;
using Invoicetronic.Sdk.Client;
using Invoicetronic.Sdk.Model;

namespace Example
{
    public class SendXmlPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.invoicetronic.com";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SendApi(config);
            var fatturaOrdinaria = new FatturaOrdinaria(); // FatturaOrdinaria | 
            var validate = false;  // bool | Validate the document first, and reject it on failure. (optional)  (default to false)
            var signature = "None";  // string | Whether to digitally sign the document. (optional)  (default to Auto)

            try
            {
                // Add an invoice by xml
                Send result = apiInstance.SendXmlPost(fatturaOrdinaria, validate, signature);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SendApi.SendXmlPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendXmlPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add an invoice by xml
    ApiResponse<Send> response = apiInstance.SendXmlPostWithHttpInfo(fatturaOrdinaria, validate, signature);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SendApi.SendXmlPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fatturaOrdinaria** | [**FatturaOrdinaria**](FatturaOrdinaria.md) |  |  |
| **validate** | **bool** | Validate the document first, and reject it on failure. | [optional] [default to false] |
| **signature** | **string** | Whether to digitally sign the document. | [optional] [default to Auto] |

### Return type

[**Send**](Send.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Bad Request |  -  |
| **422** | Unprocessable Content |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

