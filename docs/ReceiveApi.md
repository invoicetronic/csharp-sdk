# Invoicetronic.InvoiceApi.Api.ReceiveApi

All URIs are relative to *api.invoicetronic.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**InvoiceV1ReceiveGet**](ReceiveApi.md#invoicev1receiveget) | **GET** /invoice/v1/receive | List incoming invoices |
| [**InvoiceV1ReceiveIdDelete**](ReceiveApi.md#invoicev1receiveiddelete) | **DELETE** /invoice/v1/receive/{id} | Delete an incoming invoice by id |
| [**InvoiceV1ReceiveIdGet**](ReceiveApi.md#invoicev1receiveidget) | **GET** /invoice/v1/receive/{id} | Get an incoming invoice by id |

<a id="invoicev1receiveget"></a>
# **InvoiceV1ReceiveGet**
> List&lt;Receive&gt; InvoiceV1ReceiveGet (int? companyId = null, string identifier = null, bool? unread = null, string committente = null, string prestatore = null, string fileName = null, DateTime? lastUpdateFrom = null, DateTime? lastUpdateTo = null, DateTime? dateSentFrom = null, DateTime? dateSentTo = null, DateTime? documentDateFrom = null, DateTime? documentDateTo = null, string documentNumber = null, int? page = null, int? pageSize = null)

List incoming invoices

Receive invoices are the invoices that are received from other companies.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Invoicetronic.InvoiceApi.Api;
using Invoicetronic.InvoiceApi.Client;
using Invoicetronic.InvoiceApi.Model;

namespace Example
{
    public class InvoiceV1ReceiveGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "api.invoicetronic.com";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ReceiveApi(config);
            var companyId = 56;  // int? | Company id. (optional) 
            var identifier = "identifier_example";  // string | SDI identifier. (optional) 
            var unread = true;  // bool? | Unread items only. (optional) 
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
                // List incoming invoices
                List<Receive> result = apiInstance.InvoiceV1ReceiveGet(companyId, identifier, unread, committente, prestatore, fileName, lastUpdateFrom, lastUpdateTo, dateSentFrom, dateSentTo, documentDateFrom, documentDateTo, documentNumber, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReceiveApi.InvoiceV1ReceiveGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InvoiceV1ReceiveGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List incoming invoices
    ApiResponse<List<Receive>> response = apiInstance.InvoiceV1ReceiveGetWithHttpInfo(companyId, identifier, unread, committente, prestatore, fileName, lastUpdateFrom, lastUpdateTo, dateSentFrom, dateSentTo, documentDateFrom, documentDateTo, documentNumber, page, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReceiveApi.InvoiceV1ReceiveGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int?** | Company id. | [optional]  |
| **identifier** | **string** | SDI identifier. | [optional]  |
| **unread** | **bool?** | Unread items only. | [optional]  |
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

[**List&lt;Receive&gt;**](Receive.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="invoicev1receiveiddelete"></a>
# **InvoiceV1ReceiveIdDelete**
> Receive InvoiceV1ReceiveIdDelete (int id)

Delete an incoming invoice by id

Receive invoices are the invoices that are received from other companies.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Invoicetronic.InvoiceApi.Api;
using Invoicetronic.InvoiceApi.Client;
using Invoicetronic.InvoiceApi.Model;

namespace Example
{
    public class InvoiceV1ReceiveIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "api.invoicetronic.com";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ReceiveApi(config);
            var id = 56;  // int | Item id.

            try
            {
                // Delete an incoming invoice by id
                Receive result = apiInstance.InvoiceV1ReceiveIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReceiveApi.InvoiceV1ReceiveIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InvoiceV1ReceiveIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an incoming invoice by id
    ApiResponse<Receive> response = apiInstance.InvoiceV1ReceiveIdDeleteWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReceiveApi.InvoiceV1ReceiveIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Item id. |  |

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

<a id="invoicev1receiveidget"></a>
# **InvoiceV1ReceiveIdGet**
> Receive InvoiceV1ReceiveIdGet (int id)

Get an incoming invoice by id

Receive invoices are the invoices that are received from other companies.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Invoicetronic.InvoiceApi.Api;
using Invoicetronic.InvoiceApi.Client;
using Invoicetronic.InvoiceApi.Model;

namespace Example
{
    public class InvoiceV1ReceiveIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "api.invoicetronic.com";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ReceiveApi(config);
            var id = 56;  // int | Item id.

            try
            {
                // Get an incoming invoice by id
                Receive result = apiInstance.InvoiceV1ReceiveIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReceiveApi.InvoiceV1ReceiveIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InvoiceV1ReceiveIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get an incoming invoice by id
    ApiResponse<Receive> response = apiInstance.InvoiceV1ReceiveIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReceiveApi.InvoiceV1ReceiveIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Item id. |  |

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

