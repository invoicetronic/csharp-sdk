# Invoicetronic.InvoiceApi.Api.CompanyApi

All URIs are relative to *api.invoicetronic.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**InvoiceV1CompanyGet**](CompanyApi.md#invoicev1companyget) | **GET** /invoice/v1/company | List companies |
| [**InvoiceV1CompanyIdDelete**](CompanyApi.md#invoicev1companyiddelete) | **DELETE** /invoice/v1/company/{id} | Delete a company |
| [**InvoiceV1CompanyIdGet**](CompanyApi.md#invoicev1companyidget) | **GET** /invoice/v1/company/{id} | Get a company by id |
| [**InvoiceV1CompanyPost**](CompanyApi.md#invoicev1companypost) | **POST** /invoice/v1/company | Add a company |
| [**InvoiceV1CompanyPut**](CompanyApi.md#invoicev1companyput) | **PUT** /invoice/v1/company | Update a company |

<a id="invoicev1companyget"></a>
# **InvoiceV1CompanyGet**
> List&lt;Company&gt; InvoiceV1CompanyGet (int? page = null, int? pageSize = null)

List companies

Companies are the entities that send and receive invoices. At least one company is required in order to send and receive invoices.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Invoicetronic.InvoiceApi.Api;
using Invoicetronic.InvoiceApi.Client;
using Invoicetronic.InvoiceApi.Model;

namespace Example
{
    public class InvoiceV1CompanyGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "api.invoicetronic.com";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new CompanyApi(config);
            var page = 1;  // int? | Page number. (optional)  (default to 1)
            var pageSize = 100;  // int? | Items per page. (optional)  (default to 100)

            try
            {
                // List companies
                List<Company> result = apiInstance.InvoiceV1CompanyGet(page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CompanyApi.InvoiceV1CompanyGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InvoiceV1CompanyGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List companies
    ApiResponse<List<Company>> response = apiInstance.InvoiceV1CompanyGetWithHttpInfo(page, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CompanyApi.InvoiceV1CompanyGetWithHttpInfo: " + e.Message);
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

[**List&lt;Company&gt;**](Company.md)

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

<a id="invoicev1companyiddelete"></a>
# **InvoiceV1CompanyIdDelete**
> Company InvoiceV1CompanyIdDelete (int id)

Delete a company

Companies are the entities that send and receive invoices. At least one company is required in order to send and receive invoices.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Invoicetronic.InvoiceApi.Api;
using Invoicetronic.InvoiceApi.Client;
using Invoicetronic.InvoiceApi.Model;

namespace Example
{
    public class InvoiceV1CompanyIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "api.invoicetronic.com";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new CompanyApi(config);
            var id = 56;  // int | Item id.

            try
            {
                // Delete a company
                Company result = apiInstance.InvoiceV1CompanyIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CompanyApi.InvoiceV1CompanyIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InvoiceV1CompanyIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a company
    ApiResponse<Company> response = apiInstance.InvoiceV1CompanyIdDeleteWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CompanyApi.InvoiceV1CompanyIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Item id. |  |

### Return type

[**Company**](Company.md)

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

<a id="invoicev1companyidget"></a>
# **InvoiceV1CompanyIdGet**
> Company InvoiceV1CompanyIdGet (int id)

Get a company by id

Companies are the entities that send and receive invoices. At least one company is required in order to send and receive invoices.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Invoicetronic.InvoiceApi.Api;
using Invoicetronic.InvoiceApi.Client;
using Invoicetronic.InvoiceApi.Model;

namespace Example
{
    public class InvoiceV1CompanyIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "api.invoicetronic.com";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new CompanyApi(config);
            var id = 56;  // int | Item id.

            try
            {
                // Get a company by id
                Company result = apiInstance.InvoiceV1CompanyIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CompanyApi.InvoiceV1CompanyIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InvoiceV1CompanyIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a company by id
    ApiResponse<Company> response = apiInstance.InvoiceV1CompanyIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CompanyApi.InvoiceV1CompanyIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Item id. |  |

### Return type

[**Company**](Company.md)

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

<a id="invoicev1companypost"></a>
# **InvoiceV1CompanyPost**
> Company InvoiceV1CompanyPost (Company company)

Add a company

Companies are the entities that send and receive invoices. At least one company is required in order to send and receive invoices.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Invoicetronic.InvoiceApi.Api;
using Invoicetronic.InvoiceApi.Client;
using Invoicetronic.InvoiceApi.Model;

namespace Example
{
    public class InvoiceV1CompanyPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "api.invoicetronic.com";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new CompanyApi(config);
            var company = new Company(); // Company | 

            try
            {
                // Add a company
                Company result = apiInstance.InvoiceV1CompanyPost(company);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CompanyApi.InvoiceV1CompanyPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InvoiceV1CompanyPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add a company
    ApiResponse<Company> response = apiInstance.InvoiceV1CompanyPostWithHttpInfo(company);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CompanyApi.InvoiceV1CompanyPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **company** | [**Company**](Company.md) |  |  |

### Return type

[**Company**](Company.md)

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

<a id="invoicev1companyput"></a>
# **InvoiceV1CompanyPut**
> Company InvoiceV1CompanyPut (Company company)

Update a company

Companies are the entities that send and receive invoices. At least one company is required in order to send and receive invoices.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Invoicetronic.InvoiceApi.Api;
using Invoicetronic.InvoiceApi.Client;
using Invoicetronic.InvoiceApi.Model;

namespace Example
{
    public class InvoiceV1CompanyPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "api.invoicetronic.com";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new CompanyApi(config);
            var company = new Company(); // Company | 

            try
            {
                // Update a company
                Company result = apiInstance.InvoiceV1CompanyPut(company);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CompanyApi.InvoiceV1CompanyPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InvoiceV1CompanyPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a company
    ApiResponse<Company> response = apiInstance.InvoiceV1CompanyPutWithHttpInfo(company);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CompanyApi.InvoiceV1CompanyPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **company** | [**Company**](Company.md) |  |  |

### Return type

[**Company**](Company.md)

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

