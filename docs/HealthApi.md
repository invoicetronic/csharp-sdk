# Invoicetronic.Sdk.Api.HealthApi

All URIs are relative to *https://api.invoicetronic.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HealthGet**](HealthApi.md#healthget) | **GET** /health | Health check |

<a id="healthget"></a>
# **HealthGet**
> void HealthGet ()

Health check

Returns the health status of the API and its dependencies. No authentication required. Rate limited to 12 requests per minute.

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
    public class HealthGetExample
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
            var apiInstance = new HealthApi(httpClient, config, httpClientHandler);

            try
            {
                // Health check
                apiInstance.HealthGet();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HealthApi.HealthGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HealthGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Health check
    apiInstance.HealthGetWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HealthApi.HealthGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **429** | Too Many Requests |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

