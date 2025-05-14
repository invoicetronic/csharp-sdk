# Invoicetronic.Sdk.Api.CompanyApi

All URIs are relative to *https://api.invoicetronic.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CompanyGet**](CompanyApi.md#companyget) | **GET** /company | List companies |
| [**CompanyIdDelete**](CompanyApi.md#companyiddelete) | **DELETE** /company/{id} | Delete a company |
| [**CompanyIdGet**](CompanyApi.md#companyidget) | **GET** /company/{id} | Get a company by id |
| [**CompanyPost**](CompanyApi.md#companypost) | **POST** /company | Add a company |
| [**CompanyPut**](CompanyApi.md#companyput) | **PUT** /company | Update a company |

<a id="companyget"></a>
# **CompanyGet**
> List&lt;Company&gt; CompanyGet (int? page = null, int? pageSize = null, string sort = null)

List companies

Companies are the entities that send and receive invoices. As you send invoices, companies are added as needed (company details are extrapolated). **You can only receive invoices for existing companies, so ensure they exist**.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Invoicetronic.Sdk.Api;
using Invoicetronic.Sdk.Client;
using Invoicetronic.Sdk.Model;

namespace Example
{
    public class CompanyGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.invoicetronic.com";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new CompanyApi(config);
            var page = 1;  // int? | Page number. Defaults to 1. (optional)  (default to 1)
            var pageSize = 100;  // int? | Items per page. Defaults to 50. Cannot be greater than 200. (optional)  (default to 100)
            var sort = "sort_example";  // string | Sort by field. Prefix with '-' for descending order. (optional) 

            try
            {
                // List companies
                List<Company> result = apiInstance.CompanyGet(page, pageSize, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CompanyApi.CompanyGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CompanyGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List companies
    ApiResponse<List<Company>> response = apiInstance.CompanyGetWithHttpInfo(page, pageSize, sort);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CompanyApi.CompanyGetWithHttpInfo: " + e.Message);
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
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="companyiddelete"></a>
# **CompanyIdDelete**
> Company CompanyIdDelete (int id)

Delete a company

Companies are the entities that send and receive invoices. As you send invoices, companies are added as needed (company details are extrapolated). **You can only receive invoices for existing companies, so ensure they exist**.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Invoicetronic.Sdk.Api;
using Invoicetronic.Sdk.Client;
using Invoicetronic.Sdk.Model;

namespace Example
{
    public class CompanyIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.invoicetronic.com";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new CompanyApi(config);
            var id = 56;  // int | Item id

            try
            {
                // Delete a company
                Company result = apiInstance.CompanyIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CompanyApi.CompanyIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CompanyIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a company
    ApiResponse<Company> response = apiInstance.CompanyIdDeleteWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CompanyApi.CompanyIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Item id |  |

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
| **422** | Unprocessable Content |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="companyidget"></a>
# **CompanyIdGet**
> Company CompanyIdGet (int id)

Get a company by id

Companies are the entities that send and receive invoices. As you send invoices, companies are added as needed (company details are extrapolated). **You can only receive invoices for existing companies, so ensure they exist**.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Invoicetronic.Sdk.Api;
using Invoicetronic.Sdk.Client;
using Invoicetronic.Sdk.Model;

namespace Example
{
    public class CompanyIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.invoicetronic.com";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new CompanyApi(config);
            var id = 56;  // int | Item id

            try
            {
                // Get a company by id
                Company result = apiInstance.CompanyIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CompanyApi.CompanyIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CompanyIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a company by id
    ApiResponse<Company> response = apiInstance.CompanyIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CompanyApi.CompanyIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Item id |  |

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

<a id="companypost"></a>
# **CompanyPost**
> Company CompanyPost (Company company)

Add a company

Companies are the entities that send and receive invoices. As you send invoices, companies are added as needed (company details are extrapolated). **You can only receive invoices for existing companies, so ensure they exist**.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Invoicetronic.Sdk.Api;
using Invoicetronic.Sdk.Client;
using Invoicetronic.Sdk.Model;

namespace Example
{
    public class CompanyPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.invoicetronic.com";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new CompanyApi(config);
            var company = new Company(); // Company | 

            try
            {
                // Add a company
                Company result = apiInstance.CompanyPost(company);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CompanyApi.CompanyPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CompanyPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add a company
    ApiResponse<Company> response = apiInstance.CompanyPostWithHttpInfo(company);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CompanyApi.CompanyPostWithHttpInfo: " + e.Message);
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
| **400** | Bad Request |  -  |
| **422** | Unprocessable Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="companyput"></a>
# **CompanyPut**
> Company CompanyPut (Company company)

Update a company

Companies are the entities that send and receive invoices. As you send invoices, companies are added as needed (company details are extrapolated). **You can only receive invoices for existing companies, so ensure they exist**.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Invoicetronic.Sdk.Api;
using Invoicetronic.Sdk.Client;
using Invoicetronic.Sdk.Model;

namespace Example
{
    public class CompanyPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.invoicetronic.com";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new CompanyApi(config);
            var company = new Company(); // Company | 

            try
            {
                // Update a company
                Company result = apiInstance.CompanyPut(company);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CompanyApi.CompanyPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CompanyPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a company
    ApiResponse<Company> response = apiInstance.CompanyPutWithHttpInfo(company);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CompanyApi.CompanyPutWithHttpInfo: " + e.Message);
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
| **422** | Unprocessable Content |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

