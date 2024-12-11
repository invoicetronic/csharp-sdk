# Invoicetronic.Invoice.Sdk.Api.SendApi

All URIs are relative to *https://api.invoicetronic.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**InvoiceV1SendFilesPost**](SendApi.md#invoicev1sendfilespost) | **POST** /invoice/v1/send/files | Add an invoice by file |
| [**InvoiceV1SendGet**](SendApi.md#invoicev1sendget) | **GET** /invoice/v1/send | List invoices |
| [**InvoiceV1SendIdGet**](SendApi.md#invoicev1sendidget) | **GET** /invoice/v1/send/{id} | Get a invoice by id |
| [**InvoiceV1SendJsonPost**](SendApi.md#invoicev1sendjsonpost) | **POST** /invoice/v1/send/json | Add an invoice by json |
| [**InvoiceV1SendPost**](SendApi.md#invoicev1sendpost) | **POST** /invoice/v1/send | Add an invoice |
| [**InvoiceV1SendValidateFilesPost**](SendApi.md#invoicev1sendvalidatefilespost) | **POST** /invoice/v1/send/validate/files | Validate an invoice by file |
| [**InvoiceV1SendValidateJsonPost**](SendApi.md#invoicev1sendvalidatejsonpost) | **POST** /invoice/v1/send/validate/json | Validate an invoice by json |
| [**InvoiceV1SendValidatePost**](SendApi.md#invoicev1sendvalidatepost) | **POST** /invoice/v1/send/validate | Validate an invoice |
| [**InvoiceV1SendValidateXmlPost**](SendApi.md#invoicev1sendvalidatexmlpost) | **POST** /invoice/v1/send/validate/xml | Validate an invoice by xml |
| [**InvoiceV1SendXmlPost**](SendApi.md#invoicev1sendxmlpost) | **POST** /invoice/v1/send/xml | Add an invoice by xml |

<a id="invoicev1sendfilespost"></a>
# **InvoiceV1SendFilesPost**
> Send InvoiceV1SendFilesPost (List<System.IO.Stream> files, bool? validate = null)

Add an invoice by file

Send invoices are the invoices that are sent to the SDI.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Invoicetronic.Invoice.Sdk.Api;
using Invoicetronic.Invoice.Sdk.Client;
using Invoicetronic.Invoice.Sdk.Model;

namespace Example
{
    public class InvoiceV1SendFilesPostExample
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
            var validate = false;  // bool? | Validate the document first, and reject it on failure. (optional)  (default to false)

            try
            {
                // Add an invoice by file
                Send result = apiInstance.InvoiceV1SendFilesPost(files, validate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SendApi.InvoiceV1SendFilesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InvoiceV1SendFilesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add an invoice by file
    ApiResponse<Send> response = apiInstance.InvoiceV1SendFilesPostWithHttpInfo(files, validate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SendApi.InvoiceV1SendFilesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **files** | **List&lt;System.IO.Stream&gt;** |  |  |
| **validate** | **bool?** | Validate the document first, and reject it on failure. | [optional] [default to false] |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="invoicev1sendget"></a>
# **InvoiceV1SendGet**
> List&lt;Send&gt; InvoiceV1SendGet (int? companyId = null, string identifier = null, string committente = null, string prestatore = null, string fileName = null, DateTime? lastUpdateFrom = null, DateTime? lastUpdateTo = null, DateTime? dateSentFrom = null, DateTime? dateSentTo = null, DateTime? documentDateFrom = null, DateTime? documentDateTo = null, string documentNumber = null, int? page = null, int? pageSize = null)

List invoices

test **markdown**.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Invoicetronic.Invoice.Sdk.Api;
using Invoicetronic.Invoice.Sdk.Client;
using Invoicetronic.Invoice.Sdk.Model;

namespace Example
{
    public class InvoiceV1SendGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.invoicetronic.com";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SendApi(config);
            var companyId = 56;  // int? | Company id. (optional) 
            var identifier = "identifier_example";  // string | SDI identifier. (optional) 
            var committente = "committente_example";  // string | VAT number or fiscal code. (optional) 
            var prestatore = "prestatore_example";  // string | VAT number or fiscal code. (optional) 
            var fileName = "fileName_example";  // string | File name. (optional) 
            var lastUpdateFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | UTC ISO 8601 (2024-11-29T12:34:56Z) (optional) 
            var lastUpdateTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | UTC ISO 8601 (2024-11-29T12:34:56Z) (optional) 
            var dateSentFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | UTC ISO 8601 (2024-11-29T12:34:56Z) (optional) 
            var dateSentTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | UTC ISO 8601 (2024-11-29T12:34:56Z) (optional) 
            var documentDateFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | UTC ISO 8601 (2024-11-29T12:34:56Z) (optional) 
            var documentDateTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | UTC ISO 8601 (2024-11-29T12:34:56Z) (optional) 
            var documentNumber = "documentNumber_example";  // string | Document number. (optional) 
            var page = 1;  // int? | Page number. (optional)  (default to 1)
            var pageSize = 100;  // int? | Items per page. (optional)  (default to 100)

            try
            {
                // List invoices
                List<Send> result = apiInstance.InvoiceV1SendGet(companyId, identifier, committente, prestatore, fileName, lastUpdateFrom, lastUpdateTo, dateSentFrom, dateSentTo, documentDateFrom, documentDateTo, documentNumber, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SendApi.InvoiceV1SendGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InvoiceV1SendGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List invoices
    ApiResponse<List<Send>> response = apiInstance.InvoiceV1SendGetWithHttpInfo(companyId, identifier, committente, prestatore, fileName, lastUpdateFrom, lastUpdateTo, dateSentFrom, dateSentTo, documentDateFrom, documentDateTo, documentNumber, page, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SendApi.InvoiceV1SendGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int?** | Company id. | [optional]  |
| **identifier** | **string** | SDI identifier. | [optional]  |
| **committente** | **string** | VAT number or fiscal code. | [optional]  |
| **prestatore** | **string** | VAT number or fiscal code. | [optional]  |
| **fileName** | **string** | File name. | [optional]  |
| **lastUpdateFrom** | **DateTime?** | UTC ISO 8601 (2024-11-29T12:34:56Z) | [optional]  |
| **lastUpdateTo** | **DateTime?** | UTC ISO 8601 (2024-11-29T12:34:56Z) | [optional]  |
| **dateSentFrom** | **DateTime?** | UTC ISO 8601 (2024-11-29T12:34:56Z) | [optional]  |
| **dateSentTo** | **DateTime?** | UTC ISO 8601 (2024-11-29T12:34:56Z) | [optional]  |
| **documentDateFrom** | **DateTime?** | UTC ISO 8601 (2024-11-29T12:34:56Z) | [optional]  |
| **documentDateTo** | **DateTime?** | UTC ISO 8601 (2024-11-29T12:34:56Z) | [optional]  |
| **documentNumber** | **string** | Document number. | [optional]  |
| **page** | **int?** | Page number. | [optional] [default to 1] |
| **pageSize** | **int?** | Items per page. | [optional] [default to 100] |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="invoicev1sendidget"></a>
# **InvoiceV1SendIdGet**
> Send InvoiceV1SendIdGet (int id)

Get a invoice by id

Send invoices are the invoices that are sent to the SDI.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Invoicetronic.Invoice.Sdk.Api;
using Invoicetronic.Invoice.Sdk.Client;
using Invoicetronic.Invoice.Sdk.Model;

namespace Example
{
    public class InvoiceV1SendIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.invoicetronic.com";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SendApi(config);
            var id = 56;  // int | Item id.

            try
            {
                // Get a invoice by id
                Send result = apiInstance.InvoiceV1SendIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SendApi.InvoiceV1SendIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InvoiceV1SendIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a invoice by id
    ApiResponse<Send> response = apiInstance.InvoiceV1SendIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SendApi.InvoiceV1SendIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Item id. |  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="invoicev1sendjsonpost"></a>
# **InvoiceV1SendJsonPost**
> Send InvoiceV1SendJsonPost (FatturaOrdinaria fatturaOrdinaria, bool? validate = null)

Add an invoice by json

Send invoices are the invoices that are sent to the SDI.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Invoicetronic.Invoice.Sdk.Api;
using Invoicetronic.Invoice.Sdk.Client;
using Invoicetronic.Invoice.Sdk.Model;

namespace Example
{
    public class InvoiceV1SendJsonPostExample
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
            var validate = false;  // bool? | Validate the document first, and reject it on failure. (optional)  (default to false)

            try
            {
                // Add an invoice by json
                Send result = apiInstance.InvoiceV1SendJsonPost(fatturaOrdinaria, validate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SendApi.InvoiceV1SendJsonPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InvoiceV1SendJsonPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add an invoice by json
    ApiResponse<Send> response = apiInstance.InvoiceV1SendJsonPostWithHttpInfo(fatturaOrdinaria, validate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SendApi.InvoiceV1SendJsonPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fatturaOrdinaria** | [**FatturaOrdinaria**](FatturaOrdinaria.md) |  |  |
| **validate** | **bool?** | Validate the document first, and reject it on failure. | [optional] [default to false] |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="invoicev1sendpost"></a>
# **InvoiceV1SendPost**
> Send InvoiceV1SendPost (Send send, bool? validate = null)

Add an invoice

Send invoices are the invoices that are sent to the SDI.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Invoicetronic.Invoice.Sdk.Api;
using Invoicetronic.Invoice.Sdk.Client;
using Invoicetronic.Invoice.Sdk.Model;

namespace Example
{
    public class InvoiceV1SendPostExample
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
            var validate = false;  // bool? | Validate the document first, and reject it on failure. (optional)  (default to false)

            try
            {
                // Add an invoice
                Send result = apiInstance.InvoiceV1SendPost(send, validate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SendApi.InvoiceV1SendPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InvoiceV1SendPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add an invoice
    ApiResponse<Send> response = apiInstance.InvoiceV1SendPostWithHttpInfo(send, validate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SendApi.InvoiceV1SendPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **send** | [**Send**](Send.md) |  |  |
| **validate** | **bool?** | Validate the document first, and reject it on failure. | [optional] [default to false] |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="invoicev1sendvalidatefilespost"></a>
# **InvoiceV1SendValidateFilesPost**
> void InvoiceV1SendValidateFilesPost (List<System.IO.Stream> files)

Validate an invoice by file

Send invoices are the invoices that are sent to the SDI.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Invoicetronic.Invoice.Sdk.Api;
using Invoicetronic.Invoice.Sdk.Client;
using Invoicetronic.Invoice.Sdk.Model;

namespace Example
{
    public class InvoiceV1SendValidateFilesPostExample
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
                apiInstance.InvoiceV1SendValidateFilesPost(files);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SendApi.InvoiceV1SendValidateFilesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InvoiceV1SendValidateFilesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Validate an invoice by file
    apiInstance.InvoiceV1SendValidateFilesPostWithHttpInfo(files);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SendApi.InvoiceV1SendValidateFilesPostWithHttpInfo: " + e.Message);
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="invoicev1sendvalidatejsonpost"></a>
# **InvoiceV1SendValidateJsonPost**
> void InvoiceV1SendValidateJsonPost (FatturaOrdinaria fatturaOrdinaria)

Validate an invoice by json

Send invoices are the invoices that are sent to the SDI.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Invoicetronic.Invoice.Sdk.Api;
using Invoicetronic.Invoice.Sdk.Client;
using Invoicetronic.Invoice.Sdk.Model;

namespace Example
{
    public class InvoiceV1SendValidateJsonPostExample
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
                apiInstance.InvoiceV1SendValidateJsonPost(fatturaOrdinaria);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SendApi.InvoiceV1SendValidateJsonPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InvoiceV1SendValidateJsonPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Validate an invoice by json
    apiInstance.InvoiceV1SendValidateJsonPostWithHttpInfo(fatturaOrdinaria);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SendApi.InvoiceV1SendValidateJsonPostWithHttpInfo: " + e.Message);
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="invoicev1sendvalidatepost"></a>
# **InvoiceV1SendValidatePost**
> void InvoiceV1SendValidatePost (Send send)

Validate an invoice

Send invoices are the invoices that are sent to the SDI.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Invoicetronic.Invoice.Sdk.Api;
using Invoicetronic.Invoice.Sdk.Client;
using Invoicetronic.Invoice.Sdk.Model;

namespace Example
{
    public class InvoiceV1SendValidatePostExample
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
                apiInstance.InvoiceV1SendValidatePost(send);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SendApi.InvoiceV1SendValidatePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InvoiceV1SendValidatePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Validate an invoice
    apiInstance.InvoiceV1SendValidatePostWithHttpInfo(send);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SendApi.InvoiceV1SendValidatePostWithHttpInfo: " + e.Message);
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="invoicev1sendvalidatexmlpost"></a>
# **InvoiceV1SendValidateXmlPost**
> void InvoiceV1SendValidateXmlPost (FatturaOrdinaria fatturaOrdinaria)

Validate an invoice by xml

Send invoices are the invoices that are sent to the SDI.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Invoicetronic.Invoice.Sdk.Api;
using Invoicetronic.Invoice.Sdk.Client;
using Invoicetronic.Invoice.Sdk.Model;

namespace Example
{
    public class InvoiceV1SendValidateXmlPostExample
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
                apiInstance.InvoiceV1SendValidateXmlPost(fatturaOrdinaria);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SendApi.InvoiceV1SendValidateXmlPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InvoiceV1SendValidateXmlPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Validate an invoice by xml
    apiInstance.InvoiceV1SendValidateXmlPostWithHttpInfo(fatturaOrdinaria);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SendApi.InvoiceV1SendValidateXmlPostWithHttpInfo: " + e.Message);
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="invoicev1sendxmlpost"></a>
# **InvoiceV1SendXmlPost**
> Send InvoiceV1SendXmlPost (FatturaOrdinaria fatturaOrdinaria, bool? validate = null)

Add an invoice by xml

Send invoices are the invoices that are sent to the SDI.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Invoicetronic.Invoice.Sdk.Api;
using Invoicetronic.Invoice.Sdk.Client;
using Invoicetronic.Invoice.Sdk.Model;

namespace Example
{
    public class InvoiceV1SendXmlPostExample
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
            var validate = false;  // bool? | Validate the document first, and reject it on failure. (optional)  (default to false)

            try
            {
                // Add an invoice by xml
                Send result = apiInstance.InvoiceV1SendXmlPost(fatturaOrdinaria, validate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SendApi.InvoiceV1SendXmlPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InvoiceV1SendXmlPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add an invoice by xml
    ApiResponse<Send> response = apiInstance.InvoiceV1SendXmlPostWithHttpInfo(fatturaOrdinaria, validate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SendApi.InvoiceV1SendXmlPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fatturaOrdinaria** | [**FatturaOrdinaria**](FatturaOrdinaria.md) |  |  |
| **validate** | **bool?** | Validate the document first, and reject it on failure. | [optional] [default to false] |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

