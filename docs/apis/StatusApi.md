# Invoicetronic.Sdk.Api.StatusApi

All URIs are relative to *https://api.invoicetronic.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**StatusGet**](StatusApi.md#statusget) | **GET** /status | Account status |

<a id="statusget"></a>
# **StatusGet**
> Status StatusGet ()

Account status

This endpoint is used to know how many operations (invoices + validations) and signatures are left on your account.   When `signature_left` is 0, you will receive a `403 Forbidden` response if you try to sign an invoice. Likewise, if `operation_left` is 0, you will receive a `403 Forbidden` response when storing or validating an invoice.  You can raise the limits by purchasing operations and/or signatures from the [Dashboard](https://dashboard.invoicetronic.com).  __Please note__ that these values are not enforced if you are on the Sandbox. See the [API Keys & Sandbox](https://invoicetronic.com/apikeys/) documentation section to learn more about the Sandbox.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Invoicetronic.Sdk.Api;
using Invoicetronic.Sdk.Client;
using Invoicetronic.Sdk.Model;

namespace Example
{
    public class StatusGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.invoicetronic.com";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new StatusApi(config);

            try
            {
                // Account status
                Status result = apiInstance.StatusGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatusApi.StatusGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StatusGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Account status
    ApiResponse<Status> response = apiInstance.StatusGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StatusApi.StatusGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**Status**](Status.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

