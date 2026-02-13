# Invoicetronic.Sdk.Api.ExportApi

All URIs are relative to *https://api.invoicetronic.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ExportGet**](ExportApi.md#exportget) | **GET** /export | Export invoices as a ZIP archive |

<a id="exportget"></a>
# **ExportGet**
> void ExportGet (string type = null, int? companyId = null, int? year = null, int? month = null, int? quarter = null, DateTime? documentDateFrom = null, DateTime? documentDateTo = null)

Export invoices as a ZIP archive

Export invoices as a ZIP archive of FatturaPA XML files, suitable for import into accounting software (TeamSystem, Zucchetti, etc.).  **Sent invoices** are only included when they have reached a definitive state (e.g., `Consegnato` for private recipients, `AccettatoDalDestinatario`, `DecorrenzaTermini`, etc.). Invoices still being processed by SDI are excluded.  **Received invoices** are always included. Unread invoices are automatically marked as read and counted as operations.  ### Period filters  You can filter by period using either: - `year` + `month` (e.g., `year=2026&month=3` for March 2026) - `year` + `quarter` (e.g., `year=2026&quarter=1` for Q1 Jan-Mar) - `document_date_from` / `document_date_to` for a custom date range  These options are mutually exclusive. The `year` parameter alone is not valid and requires either `month` or `quarter`.  ### Response  Returns `200` with a ZIP archive, or `204 No Content` if no invoices match the given filters. Files in the archive are organized by company VAT number (`{vat}/send/`, `{vat}/receive/`).  ### Rate limiting  This endpoint has a dedicated rate limit: only one export request per user can be processed at a time. Concurrent requests will receive a `429 Too Many Requests` response.

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
    public class ExportGetExample
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
            var apiInstance = new ExportApi(httpClient, config, httpClientHandler);
            var type = "Send";  // string |  (optional)  (default to Both)
            var companyId = 56;  // int? | Company id (optional) 
            var year = 56;  // int? |  (optional) 
            var month = 56;  // int? |  (optional) 
            var quarter = 56;  // int? |  (optional) 
            var documentDateFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | UTC ISO 8601 (2024-11-29T12:34:56Z) (optional) 
            var documentDateTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | UTC ISO 8601 (2024-11-29T12:34:56Z) (optional) 

            try
            {
                // Export invoices as a ZIP archive
                apiInstance.ExportGet(type, companyId, year, month, quarter, documentDateFrom, documentDateTo);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExportApi.ExportGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExportGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Export invoices as a ZIP archive
    apiInstance.ExportGetWithHttpInfo(type, companyId, year, month, quarter, documentDateFrom, documentDateTo);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExportApi.ExportGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **type** | **string** |  | [optional] [default to Both] |
| **companyId** | **int?** | Company id | [optional]  |
| **year** | **int?** |  | [optional]  |
| **month** | **int?** |  | [optional]  |
| **quarter** | **int?** |  | [optional]  |
| **documentDateFrom** | **DateTime?** | UTC ISO 8601 (2024-11-29T12:34:56Z) | [optional]  |
| **documentDateTo** | **DateTime?** | UTC ISO 8601 (2024-11-29T12:34:56Z) | [optional]  |

### Return type

void (empty response body)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **204** | No Content |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

