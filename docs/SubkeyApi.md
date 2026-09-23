# Invoicetronic.Sdk.Api.SubkeyApi

All URIs are relative to *https://api.invoicetronic.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SubkeyGet**](SubkeyApi.md#subkeyget) | **GET** /subkey | List restricted keys |
| [**SubkeyIdDelete**](SubkeyApi.md#subkeyiddelete) | **DELETE** /subkey/{id} | Delete a restricted key |
| [**SubkeyIdGet**](SubkeyApi.md#subkeyidget) | **GET** /subkey/{id} | Get a restricted key by id |
| [**SubkeyIdRollPost**](SubkeyApi.md#subkeyidrollpost) | **POST** /subkey/{id}/roll | Roll the secrets of a restricted key |
| [**SubkeyPost**](SubkeyApi.md#subkeypost) | **POST** /subkey | Add a restricted key |
| [**SubkeyPut**](SubkeyApi.md#subkeyput) | **PUT** /subkey | Update a restricted key |

<a id="subkeyget"></a>
# **SubkeyGet**
> List&lt;SubKey&gt; SubkeyGet (int? page = null, int? pageSize = null, int? companyId = null, bool? active = null, string q = null)

List restricted keys

Retrieve a paginated list of the restricted keys of the calling main key. Secrets are never included.  **Restricted keys** are API keys created under your main key, with the permissions and companies you choose. Use them to give each of your customers, integrations or collaborators only the access they need: a restricted key limited to one company sees only that company's invoices, updates, webhooks and events.  Only a main key can manage restricted keys: a restricted key calling these endpoints gets `403 Forbidden` with `code` = `subkey_not_allowed`.  **Onboarding a company in two calls.** Create the company with `POST /company`, then create a restricted key limited to it with `POST /subkey` and `company_ids` = `[<company id>]`. Hand the key to your customer: it can operate only on that company.  **Secrets are shown once.** `test_key` and `live_key` are returned only when a key is created or rolled, never by reads. Store them safely. If a secret is lost or exposed, roll the key with `POST /subkey/{id}/roll`: its id, permissions, companies and CORS origins stay the same. Pass `expires_in_hours` (up to 168) to keep the replaced secrets working while you migrate; without it they stop working at once.  **Permissions** are set per resource. `company`, `send`, `receive` and `webhook` accept `Read` or `Write`; `update`, `log`, `webhookhistory`, `export` and `status` accept only `Read`. A missing resource means no access. Each permission cannot exceed the one of your main key (`400`, `code` = `permission_exceeds_parent`). On creation, omitted or empty `permissions` copy those of your main key at that moment.  | Resource | `Read` | `Write` | |- --|- --|- --| | `company` | list and read companies | also create, update and delete them | | `send` | list and read outgoing invoices | also send and validate invoices | | `receive` | list and read incoming invoices | also delete them | | `webhook` | list and read webhooks | also create, update and delete them | | `update`, `log`, `webhookhistory`, `export`, `status` | read | — |  **Companies.** Omitted or empty `company_ids` give access to all the companies of your account, including the ones created later. Every id must belong to your account (`400`, `code` = `company_not_found`). A restricted key limited to some companies cannot see the companies it creates: use your main key for onboarding.  **Limits.** An account can hold up to 1,000 restricted keys (`400`, `code` = `subkey_limit_reached`). Operations performed with restricted keys use the credits of your account. 

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
    public class SubkeyGetExample
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
            var apiInstance = new SubkeyApi(httpClient, config, httpClientHandler);
            var page = 1;  // int? | Page number. (optional)  (default to 1)
            var pageSize = 100;  // int? | Items per page. Cannot be greater than 200. (optional)  (default to 100)
            var companyId = 56;  // int? | Company id (optional) 
            var active = true;  // bool? | Active keys only (true) or inactive only (false). (optional) 
            var q = "q_example";  // string | Human-readable label: free-text search. (optional) 

            try
            {
                // List restricted keys
                List<SubKey> result = apiInstance.SubkeyGet(page, pageSize, companyId, active, q);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubkeyApi.SubkeyGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubkeyGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List restricted keys
    ApiResponse<List<SubKey>> response = apiInstance.SubkeyGetWithHttpInfo(page, pageSize, companyId, active, q);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubkeyApi.SubkeyGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | Page number. | [optional] [default to 1] |
| **pageSize** | **int?** | Items per page. Cannot be greater than 200. | [optional] [default to 100] |
| **companyId** | **int?** | Company id | [optional]  |
| **active** | **bool?** | Active keys only (true) or inactive only (false). | [optional]  |
| **q** | **string** | Human-readable label: free-text search. | [optional]  |

### Return type

[**List&lt;SubKey&gt;**](SubKey.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="subkeyiddelete"></a>
# **SubkeyIdDelete**
> SubKey SubkeyIdDelete (int id)

Delete a restricted key

Delete a restricted key of the calling main key. It stops authenticating at once.  **Restricted keys** are API keys created under your main key, with the permissions and companies you choose. Use them to give each of your customers, integrations or collaborators only the access they need: a restricted key limited to one company sees only that company's invoices, updates, webhooks and events.  Only a main key can manage restricted keys: a restricted key calling these endpoints gets `403 Forbidden` with `code` = `subkey_not_allowed`.  **Onboarding a company in two calls.** Create the company with `POST /company`, then create a restricted key limited to it with `POST /subkey` and `company_ids` = `[<company id>]`. Hand the key to your customer: it can operate only on that company.  **Secrets are shown once.** `test_key` and `live_key` are returned only when a key is created or rolled, never by reads. Store them safely. If a secret is lost or exposed, roll the key with `POST /subkey/{id}/roll`: its id, permissions, companies and CORS origins stay the same. Pass `expires_in_hours` (up to 168) to keep the replaced secrets working while you migrate; without it they stop working at once.  **Permissions** are set per resource. `company`, `send`, `receive` and `webhook` accept `Read` or `Write`; `update`, `log`, `webhookhistory`, `export` and `status` accept only `Read`. A missing resource means no access. Each permission cannot exceed the one of your main key (`400`, `code` = `permission_exceeds_parent`). On creation, omitted or empty `permissions` copy those of your main key at that moment.  | Resource | `Read` | `Write` | |- --|- --|- --| | `company` | list and read companies | also create, update and delete them | | `send` | list and read outgoing invoices | also send and validate invoices | | `receive` | list and read incoming invoices | also delete them | | `webhook` | list and read webhooks | also create, update and delete them | | `update`, `log`, `webhookhistory`, `export`, `status` | read | — |  **Companies.** Omitted or empty `company_ids` give access to all the companies of your account, including the ones created later. Every id must belong to your account (`400`, `code` = `company_not_found`). A restricted key limited to some companies cannot see the companies it creates: use your main key for onboarding.  **Limits.** An account can hold up to 1,000 restricted keys (`400`, `code` = `subkey_limit_reached`). Operations performed with restricted keys use the credits of your account. 

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
    public class SubkeyIdDeleteExample
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
            var apiInstance = new SubkeyApi(httpClient, config, httpClientHandler);
            var id = 56;  // int | Item id

            try
            {
                // Delete a restricted key
                SubKey result = apiInstance.SubkeyIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubkeyApi.SubkeyIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubkeyIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a restricted key
    ApiResponse<SubKey> response = apiInstance.SubkeyIdDeleteWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubkeyApi.SubkeyIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Item id |  |

### Return type

[**SubKey**](SubKey.md)

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
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="subkeyidget"></a>
# **SubkeyIdGet**
> SubKey SubkeyIdGet (int id)

Get a restricted key by id

Retrieve a restricted key of the calling main key. Secrets are never included.  **Restricted keys** are API keys created under your main key, with the permissions and companies you choose. Use them to give each of your customers, integrations or collaborators only the access they need: a restricted key limited to one company sees only that company's invoices, updates, webhooks and events.  Only a main key can manage restricted keys: a restricted key calling these endpoints gets `403 Forbidden` with `code` = `subkey_not_allowed`.  **Onboarding a company in two calls.** Create the company with `POST /company`, then create a restricted key limited to it with `POST /subkey` and `company_ids` = `[<company id>]`. Hand the key to your customer: it can operate only on that company.  **Secrets are shown once.** `test_key` and `live_key` are returned only when a key is created or rolled, never by reads. Store them safely. If a secret is lost or exposed, roll the key with `POST /subkey/{id}/roll`: its id, permissions, companies and CORS origins stay the same. Pass `expires_in_hours` (up to 168) to keep the replaced secrets working while you migrate; without it they stop working at once.  **Permissions** are set per resource. `company`, `send`, `receive` and `webhook` accept `Read` or `Write`; `update`, `log`, `webhookhistory`, `export` and `status` accept only `Read`. A missing resource means no access. Each permission cannot exceed the one of your main key (`400`, `code` = `permission_exceeds_parent`). On creation, omitted or empty `permissions` copy those of your main key at that moment.  | Resource | `Read` | `Write` | |- --|- --|- --| | `company` | list and read companies | also create, update and delete them | | `send` | list and read outgoing invoices | also send and validate invoices | | `receive` | list and read incoming invoices | also delete them | | `webhook` | list and read webhooks | also create, update and delete them | | `update`, `log`, `webhookhistory`, `export`, `status` | read | — |  **Companies.** Omitted or empty `company_ids` give access to all the companies of your account, including the ones created later. Every id must belong to your account (`400`, `code` = `company_not_found`). A restricted key limited to some companies cannot see the companies it creates: use your main key for onboarding.  **Limits.** An account can hold up to 1,000 restricted keys (`400`, `code` = `subkey_limit_reached`). Operations performed with restricted keys use the credits of your account. 

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
    public class SubkeyIdGetExample
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
            var apiInstance = new SubkeyApi(httpClient, config, httpClientHandler);
            var id = 56;  // int | Item id

            try
            {
                // Get a restricted key by id
                SubKey result = apiInstance.SubkeyIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubkeyApi.SubkeyIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubkeyIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a restricted key by id
    ApiResponse<SubKey> response = apiInstance.SubkeyIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubkeyApi.SubkeyIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Item id |  |

### Return type

[**SubKey**](SubKey.md)

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
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="subkeyidrollpost"></a>
# **SubkeyIdRollPost**
> SubKeyWithSecrets SubkeyIdRollPost (int id, int? expiresInHours = null)

Roll the secrets of a restricted key

Generate new `test_key` and `live_key` for a restricted key, keeping its id, permissions, companies and CORS origins. The replaced secrets stop working at once, or after `expires_in_hours` to migrate without downtime. The response carries the new secrets: store them safely.  **Restricted keys** are API keys created under your main key, with the permissions and companies you choose. Use them to give each of your customers, integrations or collaborators only the access they need: a restricted key limited to one company sees only that company's invoices, updates, webhooks and events.  Only a main key can manage restricted keys: a restricted key calling these endpoints gets `403 Forbidden` with `code` = `subkey_not_allowed`.  **Onboarding a company in two calls.** Create the company with `POST /company`, then create a restricted key limited to it with `POST /subkey` and `company_ids` = `[<company id>]`. Hand the key to your customer: it can operate only on that company.  **Secrets are shown once.** `test_key` and `live_key` are returned only when a key is created or rolled, never by reads. Store them safely. If a secret is lost or exposed, roll the key with `POST /subkey/{id}/roll`: its id, permissions, companies and CORS origins stay the same. Pass `expires_in_hours` (up to 168) to keep the replaced secrets working while you migrate; without it they stop working at once.  **Permissions** are set per resource. `company`, `send`, `receive` and `webhook` accept `Read` or `Write`; `update`, `log`, `webhookhistory`, `export` and `status` accept only `Read`. A missing resource means no access. Each permission cannot exceed the one of your main key (`400`, `code` = `permission_exceeds_parent`). On creation, omitted or empty `permissions` copy those of your main key at that moment.  | Resource | `Read` | `Write` | |- --|- --|- --| | `company` | list and read companies | also create, update and delete them | | `send` | list and read outgoing invoices | also send and validate invoices | | `receive` | list and read incoming invoices | also delete them | | `webhook` | list and read webhooks | also create, update and delete them | | `update`, `log`, `webhookhistory`, `export`, `status` | read | — |  **Companies.** Omitted or empty `company_ids` give access to all the companies of your account, including the ones created later. Every id must belong to your account (`400`, `code` = `company_not_found`). A restricted key limited to some companies cannot see the companies it creates: use your main key for onboarding.  **Limits.** An account can hold up to 1,000 restricted keys (`400`, `code` = `subkey_limit_reached`). Operations performed with restricted keys use the credits of your account. 

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
    public class SubkeyIdRollPostExample
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
            var apiInstance = new SubkeyApi(httpClient, config, httpClientHandler);
            var id = 56;  // int | Item id
            var expiresInHours = 56;  // int? | Hours the replaced secrets keep working, from 1 to 168. When omitted, they stop working at once. (optional) 

            try
            {
                // Roll the secrets of a restricted key
                SubKeyWithSecrets result = apiInstance.SubkeyIdRollPost(id, expiresInHours);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubkeyApi.SubkeyIdRollPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubkeyIdRollPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Roll the secrets of a restricted key
    ApiResponse<SubKeyWithSecrets> response = apiInstance.SubkeyIdRollPostWithHttpInfo(id, expiresInHours);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubkeyApi.SubkeyIdRollPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Item id |  |
| **expiresInHours** | **int?** | Hours the replaced secrets keep working, from 1 to 168. When omitted, they stop working at once. | [optional]  |

### Return type

[**SubKeyWithSecrets**](SubKeyWithSecrets.md)

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
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="subkeypost"></a>
# **SubkeyPost**
> SubKeyWithSecrets SubkeyPost (SubKeyRequest subKeyRequest)

Add a restricted key

Create a restricted key under the calling main key. The response is the only one carrying `test_key` and `live_key`, together with the one of a roll: store them safely.  **Restricted keys** are API keys created under your main key, with the permissions and companies you choose. Use them to give each of your customers, integrations or collaborators only the access they need: a restricted key limited to one company sees only that company's invoices, updates, webhooks and events.  Only a main key can manage restricted keys: a restricted key calling these endpoints gets `403 Forbidden` with `code` = `subkey_not_allowed`.  **Onboarding a company in two calls.** Create the company with `POST /company`, then create a restricted key limited to it with `POST /subkey` and `company_ids` = `[<company id>]`. Hand the key to your customer: it can operate only on that company.  **Secrets are shown once.** `test_key` and `live_key` are returned only when a key is created or rolled, never by reads. Store them safely. If a secret is lost or exposed, roll the key with `POST /subkey/{id}/roll`: its id, permissions, companies and CORS origins stay the same. Pass `expires_in_hours` (up to 168) to keep the replaced secrets working while you migrate; without it they stop working at once.  **Permissions** are set per resource. `company`, `send`, `receive` and `webhook` accept `Read` or `Write`; `update`, `log`, `webhookhistory`, `export` and `status` accept only `Read`. A missing resource means no access. Each permission cannot exceed the one of your main key (`400`, `code` = `permission_exceeds_parent`). On creation, omitted or empty `permissions` copy those of your main key at that moment.  | Resource | `Read` | `Write` | |- --|- --|- --| | `company` | list and read companies | also create, update and delete them | | `send` | list and read outgoing invoices | also send and validate invoices | | `receive` | list and read incoming invoices | also delete them | | `webhook` | list and read webhooks | also create, update and delete them | | `update`, `log`, `webhookhistory`, `export`, `status` | read | — |  **Companies.** Omitted or empty `company_ids` give access to all the companies of your account, including the ones created later. Every id must belong to your account (`400`, `code` = `company_not_found`). A restricted key limited to some companies cannot see the companies it creates: use your main key for onboarding.  **Limits.** An account can hold up to 1,000 restricted keys (`400`, `code` = `subkey_limit_reached`). Operations performed with restricted keys use the credits of your account. 

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
    public class SubkeyPostExample
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
            var apiInstance = new SubkeyApi(httpClient, config, httpClientHandler);
            var subKeyRequest = new SubKeyRequest(); // SubKeyRequest | 

            try
            {
                // Add a restricted key
                SubKeyWithSecrets result = apiInstance.SubkeyPost(subKeyRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubkeyApi.SubkeyPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubkeyPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add a restricted key
    ApiResponse<SubKeyWithSecrets> response = apiInstance.SubkeyPostWithHttpInfo(subKeyRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubkeyApi.SubkeyPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subKeyRequest** | [**SubKeyRequest**](SubKeyRequest.md) |  |  |

### Return type

[**SubKeyWithSecrets**](SubKeyWithSecrets.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="subkeyput"></a>
# **SubkeyPut**
> SubKey SubkeyPut (SubKeyUpdate subKeyUpdate)

Update a restricted key

Replace the description, active flag, permissions, companies and CORS origins of a restricted key. Omitted `permissions`, `company_ids` or `cors_origins` mean none. A stale `version` fails with `422`.  **Restricted keys** are API keys created under your main key, with the permissions and companies you choose. Use them to give each of your customers, integrations or collaborators only the access they need: a restricted key limited to one company sees only that company's invoices, updates, webhooks and events.  Only a main key can manage restricted keys: a restricted key calling these endpoints gets `403 Forbidden` with `code` = `subkey_not_allowed`.  **Onboarding a company in two calls.** Create the company with `POST /company`, then create a restricted key limited to it with `POST /subkey` and `company_ids` = `[<company id>]`. Hand the key to your customer: it can operate only on that company.  **Secrets are shown once.** `test_key` and `live_key` are returned only when a key is created or rolled, never by reads. Store them safely. If a secret is lost or exposed, roll the key with `POST /subkey/{id}/roll`: its id, permissions, companies and CORS origins stay the same. Pass `expires_in_hours` (up to 168) to keep the replaced secrets working while you migrate; without it they stop working at once.  **Permissions** are set per resource. `company`, `send`, `receive` and `webhook` accept `Read` or `Write`; `update`, `log`, `webhookhistory`, `export` and `status` accept only `Read`. A missing resource means no access. Each permission cannot exceed the one of your main key (`400`, `code` = `permission_exceeds_parent`). On creation, omitted or empty `permissions` copy those of your main key at that moment.  | Resource | `Read` | `Write` | |- --|- --|- --| | `company` | list and read companies | also create, update and delete them | | `send` | list and read outgoing invoices | also send and validate invoices | | `receive` | list and read incoming invoices | also delete them | | `webhook` | list and read webhooks | also create, update and delete them | | `update`, `log`, `webhookhistory`, `export`, `status` | read | — |  **Companies.** Omitted or empty `company_ids` give access to all the companies of your account, including the ones created later. Every id must belong to your account (`400`, `code` = `company_not_found`). A restricted key limited to some companies cannot see the companies it creates: use your main key for onboarding.  **Limits.** An account can hold up to 1,000 restricted keys (`400`, `code` = `subkey_limit_reached`). Operations performed with restricted keys use the credits of your account. 

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
    public class SubkeyPutExample
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
            var apiInstance = new SubkeyApi(httpClient, config, httpClientHandler);
            var subKeyUpdate = new SubKeyUpdate(); // SubKeyUpdate | 

            try
            {
                // Update a restricted key
                SubKey result = apiInstance.SubkeyPut(subKeyUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubkeyApi.SubkeyPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubkeyPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a restricted key
    ApiResponse<SubKey> response = apiInstance.SubkeyPutWithHttpInfo(subKeyUpdate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubkeyApi.SubkeyPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subKeyUpdate** | [**SubKeyUpdate**](SubKeyUpdate.md) |  |  |

### Return type

[**SubKey**](SubKey.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Content |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

