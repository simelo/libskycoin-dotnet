# Skyapi.Api.DefaultApi

All URIs are relative to *http://127.0.0.1:6420*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddressCount**](DefaultApi.md#addresscount) | **GET** /api/v1/addresscount | Returns the total number of unique address that have coins.
[**AddressUxouts**](DefaultApi.md#addressuxouts) | **GET** /api/v1/address_uxouts | 
[**BalanceGet**](DefaultApi.md#balanceget) | **GET** /api/v1/balance | Returns the balance of one or more addresses, both confirmed and predicted. The predicted balance is the confirmed balance minus the pending spends.
[**BalancePost**](DefaultApi.md#balancepost) | **POST** /api/v1/balance | Returns the balance of one or more addresses, both confirmed and predicted. The predicted balance is the confirmed balance minus the pending spends.
[**Block**](DefaultApi.md#block) | **GET** /api/v1/block | 
[**BlockchainMetadata**](DefaultApi.md#blockchainmetadata) | **GET** /api/v1/blockchain/metadata | Returns the blockchain metadata.
[**BlockchainProgress**](DefaultApi.md#blockchainprogress) | **GET** /api/v1/blockchain/progress | Returns the blockchain sync progress.
[**BlocksGet**](DefaultApi.md#blocksget) | **GET** /api/v1/blocks | blocksHandler returns blocks between a start and end point,
[**BlocksPost**](DefaultApi.md#blockspost) | **POST** /api/v1/blocks | blocksHandler returns blocks between a start and end point,
[**CoinSupply**](DefaultApi.md#coinsupply) | **GET** /api/v1/coinSupply | 
[**Csrf**](DefaultApi.md#csrf) | **GET** /api/v1/csrf | Creates a new CSRF token. Previous CSRF tokens are invalidated by this call.
[**DefaultConnections**](DefaultApi.md#defaultconnections) | **GET** /api/v1/network/defaultConnections | defaultConnectionsHandler returns the list of default hardcoded bootstrap addresses.\\n They are not necessarily connected to.
[**ExplorerAddress**](DefaultApi.md#exploreraddress) | **GET** /api/v1/explorer/address | 
[**Health**](DefaultApi.md#health) | **GET** /api/v1/health | Returns node health data.
[**LastBlocks**](DefaultApi.md#lastblocks) | **GET** /api/v1/last_blocks | 
[**NetworkConnection**](DefaultApi.md#networkconnection) | **GET** /api/v1/network/connection | This endpoint returns a specific connection.
[**NetworkConnections**](DefaultApi.md#networkconnections) | **GET** /api/v1/network/connections | This endpoint returns all outgoings connections.
[**NetworkConnectionsDisconnect**](DefaultApi.md#networkconnectionsdisconnect) | **POST** /api/v1/network/connection/disconnect | 
[**NetworkConnectionsExchange**](DefaultApi.md#networkconnectionsexchange) | **GET** /api/v1/network/connections/exchange | 
[**NetworkConnectionsTrust**](DefaultApi.md#networkconnectionstrust) | **GET** /api/v1/network/connections/trust | trustConnectionsHandler returns all trusted connections.\\n They are not necessarily connected to. In the default configuration, these will be a subset of the default hardcoded bootstrap addresses.
[**OutputsGet**](DefaultApi.md#outputsget) | **GET** /api/v1/outputs | If neither addrs nor hashes are specificed, return all unspent outputs. If only one filter is specified, then return outputs match the filter. Both filters cannot be specified.
[**OutputsPost**](DefaultApi.md#outputspost) | **POST** /api/v1/outputs | If neither addrs nor hashes are specificed, return all unspent outputs. If only one filter is specified, then return outputs match the filter. Both filters cannot be specified.
[**PendingTxs**](DefaultApi.md#pendingtxs) | **GET** /api/v1/pendingTxs | 
[**ResendUnconfirmedTxns**](DefaultApi.md#resendunconfirmedtxns) | **POST** /api/v1/resendUnconfirmedTxns | 
[**Richlist**](DefaultApi.md#richlist) | **GET** /api/v1/richlist | Returns the top skycoin holders.
[**Transaction**](DefaultApi.md#transaction) | **GET** /api/v1/transaction | 
[**TransactionInject**](DefaultApi.md#transactioninject) | **POST** /api/v2/transaction/inject | Broadcast a hex-encoded, serialized transaction to the network.
[**TransactionRaw**](DefaultApi.md#transactionraw) | **GET** /api/v2/transaction/raw | Returns the hex-encoded byte serialization of a transaction. The transaction may be confirmed or unconfirmed.
[**TransactionVerify**](DefaultApi.md#transactionverify) | **POST** /api/v2/transaction/verify | 
[**TransactionsGet**](DefaultApi.md#transactionsget) | **GET** /api/v1/transactions | Returns transactions that match the filters.
[**TransactionsPost**](DefaultApi.md#transactionspost) | **POST** /api/v1/transactions | Returns transactions that match the filters.
[**Uxout**](DefaultApi.md#uxout) | **GET** /api/v1/uxout | Returns an unspent output by ID.
[**VerifyAddress**](DefaultApi.md#verifyaddress) | **POST** /api/v2/address/verify | Verifies a Skycoin address.
[**Version**](DefaultApi.md#version) | **GET** /api/v1/version | 
[**Wallet**](DefaultApi.md#wallet) | **GET** /api/v1/wallet | Returns a wallet by id.
[**WalletBalance**](DefaultApi.md#walletbalance) | **GET** /api/v1/wallet/balance | Returns the wallet&#39;s balance, both confirmed and predicted.  The predicted balance is the confirmed balance minus the pending spends.
[**WalletCreate**](DefaultApi.md#walletcreate) | **POST** /api/v1/wallet/create | 
[**WalletDecrypt**](DefaultApi.md#walletdecrypt) | **POST** /api/v1/wallet/decrypt | Decrypts wallet.
[**WalletEncrypt**](DefaultApi.md#walletencrypt) | **POST** /api/v1/wallet/encrypt | Encrypt wallet.
[**WalletFolder**](DefaultApi.md#walletfolder) | **GET** /api/v1/wallets/folderName | 
[**WalletNewAddress**](DefaultApi.md#walletnewaddress) | **POST** /api/v1/wallet/newAddress | 
[**WalletNewSeed**](DefaultApi.md#walletnewseed) | **GET** /api/v1/wallet/newSeed | 
[**WalletRecover**](DefaultApi.md#walletrecover) | **POST** /api/v2/wallet/recover | Recovers an encrypted wallet by providing the seed. The first address will be generated from seed and compared to the first address of the specified wallet. If they match, the wallet will be regenerated with an optional password. If the wallet is not encrypted, an error is returned.
[**WalletSeed**](DefaultApi.md#walletseed) | **POST** /api/v1/wallet/seed | This endpoint only works for encrypted wallets. If the wallet is unencrypted, The seed will be not returned.
[**WalletSeedVerify**](DefaultApi.md#walletseedverify) | **POST** /api/v2/wallet/seed/verify | Verifies a wallet seed.
[**WalletSpent**](DefaultApi.md#walletspent) | **POST** /api/v1/wallet/spend | 
[**WalletTransaction**](DefaultApi.md#wallettransaction) | **POST** /api/v1/wallet/transaction | 
[**WalletTransactions**](DefaultApi.md#wallettransactions) | **GET** /api/v1/wallet/transactions | 
[**WalletUnload**](DefaultApi.md#walletunload) | **POST** /api/v1/wallet/unload | Unloads wallet from the wallet service.
[**WalletUpdate**](DefaultApi.md#walletupdate) | **POST** /api/v1/wallet/update | Update the wallet.
[**Wallets**](DefaultApi.md#wallets) | **GET** /api/v1/wallets | 



## AddressCount

> Object AddressCount ()

Returns the total number of unique address that have coins.

### Example

```csharp
using System.Diagnostics;
using Skyapi.Api;
using Skyapi.Client;
using Skyapi.Model;

namespace Example
{
    public class AddressCountExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://127.0.0.1:6420";
            var apiInstance = new DefaultApi(Configuration.Default);

            try
            {
                // Returns the total number of unique address that have coins.
                Object result = apiInstance.AddressCount();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.AddressCount: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AddressUxouts

> List<InlineResponse200> AddressUxouts (string address)



Returns the historical, spent outputs associated with an address

### Example

```csharp
using System.Diagnostics;
using Skyapi.Api;
using Skyapi.Client;
using Skyapi.Model;

namespace Example
{
    public class AddressUxoutsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://127.0.0.1:6420";
            var apiInstance = new DefaultApi(Configuration.Default);
            var address = address_example;  // string | address to filter by

            try
            {
                List&lt;InlineResponse200&gt; result = apiInstance.AddressUxouts(address);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.AddressUxouts: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| address to filter by | 

### Return type

[**List<InlineResponse200>**](InlineResponse200.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## BalanceGet

> Object BalanceGet (string addrs)

Returns the balance of one or more addresses, both confirmed and predicted. The predicted balance is the confirmed balance minus the pending spends.

### Example

```csharp
using System.Diagnostics;
using Skyapi.Api;
using Skyapi.Client;
using Skyapi.Model;

namespace Example
{
    public class BalanceGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://127.0.0.1:6420";
            var apiInstance = new DefaultApi(Configuration.Default);
            var addrs = addrs_example;  // string | command separated list of addresses

            try
            {
                // Returns the balance of one or more addresses, both confirmed and predicted. The predicted balance is the confirmed balance minus the pending spends.
                Object result = apiInstance.BalanceGet(addrs);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.BalanceGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **addrs** | **string**| command separated list of addresses | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## BalancePost

> Object BalancePost (string addrs)

Returns the balance of one or more addresses, both confirmed and predicted. The predicted balance is the confirmed balance minus the pending spends.

### Example

```csharp
using System.Diagnostics;
using Skyapi.Api;
using Skyapi.Client;
using Skyapi.Model;

namespace Example
{
    public class BalancePostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://127.0.0.1:6420";
            // Configure API key authorization: csrfAuth
            Configuration.Default.AddApiKey("X-CSRF-TOKEN", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-CSRF-TOKEN", "Bearer");

            var apiInstance = new DefaultApi(Configuration.Default);
            var addrs = addrs_example;  // string | command separated list of addresses

            try
            {
                // Returns the balance of one or more addresses, both confirmed and predicted. The predicted balance is the confirmed balance minus the pending spends.
                Object result = apiInstance.BalancePost(addrs);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.BalancePost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **addrs** | **string**| command separated list of addresses | 

### Return type

**Object**

### Authorization

[csrfAuth](../README.md#csrfAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Block

> Object Block (string hash = null, int? seq = null)



Returns a block by hash or seq. Note: only one of hash or seq is allowed

### Example

```csharp
using System.Diagnostics;
using Skyapi.Api;
using Skyapi.Client;
using Skyapi.Model;

namespace Example
{
    public class BlockExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://127.0.0.1:6420";
            var apiInstance = new DefaultApi(Configuration.Default);
            var hash = hash_example;  // string |  (optional) 
            var seq = 56;  // int? |  (optional) 

            try
            {
                Object result = apiInstance.Block(hash, seq);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.Block: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **hash** | **string**|  | [optional] 
 **seq** | **int?**|  | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## BlockchainMetadata

> Object BlockchainMetadata ()

Returns the blockchain metadata.

### Example

```csharp
using System.Diagnostics;
using Skyapi.Api;
using Skyapi.Client;
using Skyapi.Model;

namespace Example
{
    public class BlockchainMetadataExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://127.0.0.1:6420";
            var apiInstance = new DefaultApi(Configuration.Default);

            try
            {
                // Returns the blockchain metadata.
                Object result = apiInstance.BlockchainMetadata();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.BlockchainMetadata: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## BlockchainProgress

> Object BlockchainProgress ()

Returns the blockchain sync progress.

### Example

```csharp
using System.Diagnostics;
using Skyapi.Api;
using Skyapi.Client;
using Skyapi.Model;

namespace Example
{
    public class BlockchainProgressExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://127.0.0.1:6420";
            var apiInstance = new DefaultApi(Configuration.Default);

            try
            {
                // Returns the blockchain sync progress.
                Object result = apiInstance.BlockchainProgress();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.BlockchainProgress: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## BlocksGet

> Object BlocksGet (int? start = null, int? end = null, List<int?> seqs = null)

blocksHandler returns blocks between a start and end point,

or an explicit list of sequences. If using start and end, the block sequences include both the start and end point. Explicit sequences cannot be combined with start and end. Without verbose.

### Example

```csharp
using System.Diagnostics;
using Skyapi.Api;
using Skyapi.Client;
using Skyapi.Model;

namespace Example
{
    public class BlocksGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://127.0.0.1:6420";
            var apiInstance = new DefaultApi(Configuration.Default);
            var start = 56;  // int? |  (optional) 
            var end = 56;  // int? |  (optional) 
            var seqs = new List<int?>(); // List<int?> |  (optional) 

            try
            {
                // blocksHandler returns blocks between a start and end point,
                Object result = apiInstance.BlocksGet(start, end, seqs);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.BlocksGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **start** | **int?**|  | [optional] 
 **end** | **int?**|  | [optional] 
 **seqs** | [**List&lt;int?&gt;**](int?.md)|  | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## BlocksPost

> Object BlocksPost (int? start = null, int? end = null, List<int?> seqs = null)

blocksHandler returns blocks between a start and end point,

or an explicit list of sequences. If using start and end, the block sequences include both the start and end point. Explicit sequences cannot be combined with start and end. Without verbose

### Example

```csharp
using System.Diagnostics;
using Skyapi.Api;
using Skyapi.Client;
using Skyapi.Model;

namespace Example
{
    public class BlocksPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://127.0.0.1:6420";
            // Configure API key authorization: csrfAuth
            Configuration.Default.AddApiKey("X-CSRF-TOKEN", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-CSRF-TOKEN", "Bearer");

            var apiInstance = new DefaultApi(Configuration.Default);
            var start = 56;  // int? |  (optional) 
            var end = 56;  // int? |  (optional) 
            var seqs = new List<int?>(); // List<int?> |  (optional) 

            try
            {
                // blocksHandler returns blocks between a start and end point,
                Object result = apiInstance.BlocksPost(start, end, seqs);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.BlocksPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **start** | **int?**|  | [optional] 
 **end** | **int?**|  | [optional] 
 **seqs** | [**List&lt;int?&gt;**](int?.md)|  | [optional] 

### Return type

**Object**

### Authorization

[csrfAuth](../README.md#csrfAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CoinSupply

> Object CoinSupply ()



coinSupplyHandler returns coin distribution supply stats

### Example

```csharp
using System.Diagnostics;
using Skyapi.Api;
using Skyapi.Client;
using Skyapi.Model;

namespace Example
{
    public class CoinSupplyExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://127.0.0.1:6420";
            var apiInstance = new DefaultApi(Configuration.Default);

            try
            {
                Object result = apiInstance.CoinSupply();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.CoinSupply: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Csrf

> InlineResponse2001 Csrf ()

Creates a new CSRF token. Previous CSRF tokens are invalidated by this call.

### Example

```csharp
using System.Diagnostics;
using Skyapi.Api;
using Skyapi.Client;
using Skyapi.Model;

namespace Example
{
    public class CsrfExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://127.0.0.1:6420";
            var apiInstance = new DefaultApi(Configuration.Default);

            try
            {
                // Creates a new CSRF token. Previous CSRF tokens are invalidated by this call.
                InlineResponse2001 result = apiInstance.Csrf();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.Csrf: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DefaultConnections

> List<string> DefaultConnections ()

defaultConnectionsHandler returns the list of default hardcoded bootstrap addresses.\\n They are not necessarily connected to.

### Example

```csharp
using System.Diagnostics;
using Skyapi.Api;
using Skyapi.Client;
using Skyapi.Model;

namespace Example
{
    public class DefaultConnectionsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://127.0.0.1:6420";
            var apiInstance = new DefaultApi(Configuration.Default);

            try
            {
                // defaultConnectionsHandler returns the list of default hardcoded bootstrap addresses.\\n They are not necessarily connected to.
                List&lt;string&gt; result = apiInstance.DefaultConnections();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.DefaultConnections: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

**List<string>**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ExplorerAddress

> List<InlineResponse2002> ExplorerAddress (string address = null)



Returns all transactions (confirmed and unconfirmed) for an address

### Example

```csharp
using System.Diagnostics;
using Skyapi.Api;
using Skyapi.Client;
using Skyapi.Model;

namespace Example
{
    public class ExplorerAddressExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://127.0.0.1:6420";
            var apiInstance = new DefaultApi(Configuration.Default);
            var address = address_example;  // string | tags to filter by (optional) 

            try
            {
                List&lt;InlineResponse2002&gt; result = apiInstance.ExplorerAddress(address);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.ExplorerAddress: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| tags to filter by | [optional] 

### Return type

[**List<InlineResponse2002>**](InlineResponse2002.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Health

> Object Health ()

Returns node health data.

### Example

```csharp
using System.Diagnostics;
using Skyapi.Api;
using Skyapi.Client;
using Skyapi.Model;

namespace Example
{
    public class HealthExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://127.0.0.1:6420";
            var apiInstance = new DefaultApi(Configuration.Default);

            try
            {
                // Returns node health data.
                Object result = apiInstance.Health();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.Health: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## LastBlocks

> Object LastBlocks (int? num)



Returns the most recent N blocks on the blockchain

### Example

```csharp
using System.Diagnostics;
using Skyapi.Api;
using Skyapi.Client;
using Skyapi.Model;

namespace Example
{
    public class LastBlocksExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://127.0.0.1:6420";
            var apiInstance = new DefaultApi(Configuration.Default);
            var num = 56;  // int? | 

            try
            {
                Object result = apiInstance.LastBlocks(num);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.LastBlocks: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **num** | **int?**|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## NetworkConnection

> InlineResponse2003 NetworkConnection (string addr)

This endpoint returns a specific connection.

### Example

```csharp
using System.Diagnostics;
using Skyapi.Api;
using Skyapi.Client;
using Skyapi.Model;

namespace Example
{
    public class NetworkConnectionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://127.0.0.1:6420";
            var apiInstance = new DefaultApi(Configuration.Default);
            var addr = addr_example;  // string | Address port

            try
            {
                // This endpoint returns a specific connection.
                InlineResponse2003 result = apiInstance.NetworkConnection(addr);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.NetworkConnection: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **addr** | **string**| Address port | 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## NetworkConnections

> List<InlineResponse2003> NetworkConnections (string states = null, string direction = null)

This endpoint returns all outgoings connections.

### Example

```csharp
using System.Diagnostics;
using Skyapi.Api;
using Skyapi.Client;
using Skyapi.Model;

namespace Example
{
    public class NetworkConnectionsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://127.0.0.1:6420";
            // Configure API key authorization: csrfAuth
            Configuration.Default.AddApiKey("X-CSRF-TOKEN", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-CSRF-TOKEN", "Bearer");

            var apiInstance = new DefaultApi(Configuration.Default);
            var states = states_example;  // string | Connection status. (optional) 
            var direction = direction_example;  // string | Direction of the connection. (optional) 

            try
            {
                // This endpoint returns all outgoings connections.
                List&lt;InlineResponse2003&gt; result = apiInstance.NetworkConnections(states, direction);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.NetworkConnections: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **states** | **string**| Connection status. | [optional] 
 **direction** | **string**| Direction of the connection. | [optional] 

### Return type

[**List<InlineResponse2003>**](InlineResponse2003.md)

### Authorization

[csrfAuth](../README.md#csrfAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## NetworkConnectionsDisconnect

> void NetworkConnectionsDisconnect (string id)



This endpoint disconnects a connection by ID or address

### Example

```csharp
using System.Diagnostics;
using Skyapi.Api;
using Skyapi.Client;
using Skyapi.Model;

namespace Example
{
    public class NetworkConnectionsDisconnectExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://127.0.0.1:6420";
            // Configure API key authorization: csrfAuth
            Configuration.Default.AddApiKey("X-CSRF-TOKEN", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-CSRF-TOKEN", "Bearer");

            var apiInstance = new DefaultApi(Configuration.Default);
            var id = id_example;  // string | Address id.

            try
            {
                apiInstance.NetworkConnectionsDisconnect(id);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.NetworkConnectionsDisconnect: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Address id. | 

### Return type

void (empty response body)

### Authorization

[csrfAuth](../README.md#csrfAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## NetworkConnectionsExchange

> List<string> NetworkConnectionsExchange ()



This endpoint returns all connections found through peer exchange

### Example

```csharp
using System.Diagnostics;
using Skyapi.Api;
using Skyapi.Client;
using Skyapi.Model;

namespace Example
{
    public class NetworkConnectionsExchangeExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://127.0.0.1:6420";
            var apiInstance = new DefaultApi(Configuration.Default);

            try
            {
                List&lt;string&gt; result = apiInstance.NetworkConnectionsExchange();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.NetworkConnectionsExchange: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

**List<string>**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## NetworkConnectionsTrust

> List<string> NetworkConnectionsTrust ()

trustConnectionsHandler returns all trusted connections.\\n They are not necessarily connected to. In the default configuration, these will be a subset of the default hardcoded bootstrap addresses.

### Example

```csharp
using System.Diagnostics;
using Skyapi.Api;
using Skyapi.Client;
using Skyapi.Model;

namespace Example
{
    public class NetworkConnectionsTrustExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://127.0.0.1:6420";
            // Configure API key authorization: csrfAuth
            Configuration.Default.AddApiKey("X-CSRF-TOKEN", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-CSRF-TOKEN", "Bearer");

            var apiInstance = new DefaultApi(Configuration.Default);

            try
            {
                // trustConnectionsHandler returns all trusted connections.\\n They are not necessarily connected to. In the default configuration, these will be a subset of the default hardcoded bootstrap addresses.
                List&lt;string&gt; result = apiInstance.NetworkConnectionsTrust();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.NetworkConnectionsTrust: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

**List<string>**

### Authorization

[csrfAuth](../README.md#csrfAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## OutputsGet

> Object OutputsGet (List<string> address = null, List<string> hash = null)

If neither addrs nor hashes are specificed, return all unspent outputs. If only one filter is specified, then return outputs match the filter. Both filters cannot be specified.

### Example

```csharp
using System.Diagnostics;
using Skyapi.Api;
using Skyapi.Client;
using Skyapi.Model;

namespace Example
{
    public class OutputsGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://127.0.0.1:6420";
            var apiInstance = new DefaultApi(Configuration.Default);
            var address = new List<string>(); // List<string> |  (optional) 
            var hash = new List<string>(); // List<string> |  (optional) 

            try
            {
                // If neither addrs nor hashes are specificed, return all unspent outputs. If only one filter is specified, then return outputs match the filter. Both filters cannot be specified.
                Object result = apiInstance.OutputsGet(address, hash);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.OutputsGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **hash** | [**List&lt;string&gt;**](string.md)|  | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## OutputsPost

> Object OutputsPost (string address = null, string hash = null)

If neither addrs nor hashes are specificed, return all unspent outputs. If only one filter is specified, then return outputs match the filter. Both filters cannot be specified.

### Example

```csharp
using System.Diagnostics;
using Skyapi.Api;
using Skyapi.Client;
using Skyapi.Model;

namespace Example
{
    public class OutputsPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://127.0.0.1:6420";
            // Configure API key authorization: csrfAuth
            Configuration.Default.AddApiKey("X-CSRF-TOKEN", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-CSRF-TOKEN", "Bearer");

            var apiInstance = new DefaultApi(Configuration.Default);
            var address = address_example;  // string |  (optional) 
            var hash = hash_example;  // string |  (optional) 

            try
            {
                // If neither addrs nor hashes are specificed, return all unspent outputs. If only one filter is specified, then return outputs match the filter. Both filters cannot be specified.
                Object result = apiInstance.OutputsPost(address, hash);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.OutputsPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**|  | [optional] 
 **hash** | **string**|  | [optional] 

### Return type

**Object**

### Authorization

[csrfAuth](../README.md#csrfAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PendingTxs

> List<InlineResponse2004> PendingTxs ()



Returns pending (unconfirmed) transactions without verbose

### Example

```csharp
using System.Diagnostics;
using Skyapi.Api;
using Skyapi.Client;
using Skyapi.Model;

namespace Example
{
    public class PendingTxsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://127.0.0.1:6420";
            var apiInstance = new DefaultApi(Configuration.Default);

            try
            {
                List&lt;InlineResponse2004&gt; result = apiInstance.PendingTxs();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.PendingTxs: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**List<InlineResponse2004>**](InlineResponse2004.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ResendUnconfirmedTxns

> void ResendUnconfirmedTxns ()



Broadcasts all unconfirmed transactions from the unconfirmed transaction pool

### Example

```csharp
using System.Diagnostics;
using Skyapi.Api;
using Skyapi.Client;
using Skyapi.Model;

namespace Example
{
    public class ResendUnconfirmedTxnsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://127.0.0.1:6420";
            // Configure API key authorization: csrfAuth
            Configuration.Default.AddApiKey("X-CSRF-TOKEN", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-CSRF-TOKEN", "Bearer");

            var apiInstance = new DefaultApi(Configuration.Default);

            try
            {
                apiInstance.ResendUnconfirmedTxns();
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.ResendUnconfirmedTxns: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[csrfAuth](../README.md#csrfAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Richlist

> Object Richlist (bool? includeDistribution = null, string n = null)

Returns the top skycoin holders.

### Example

```csharp
using System.Diagnostics;
using Skyapi.Api;
using Skyapi.Client;
using Skyapi.Model;

namespace Example
{
    public class RichlistExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://127.0.0.1:6420";
            var apiInstance = new DefaultApi(Configuration.Default);
            var includeDistribution = true;  // bool? | include distribution addresses or not, default value false (optional) 
            var n = n_example;  // string | include distribution addresses or not, default value false (optional) 

            try
            {
                // Returns the top skycoin holders.
                Object result = apiInstance.Richlist(includeDistribution, n);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.Richlist: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **includeDistribution** | **bool?**| include distribution addresses or not, default value false | [optional] 
 **n** | **string**| include distribution addresses or not, default value false | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Transaction

> Object Transaction (string txid, bool? encoded = null)



Returns a transaction identi`fied by its txid hash with just id

### Example

```csharp
using System.Diagnostics;
using Skyapi.Api;
using Skyapi.Client;
using Skyapi.Model;

namespace Example
{
    public class TransactionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://127.0.0.1:6420";
            var apiInstance = new DefaultApi(Configuration.Default);
            var txid = txid_example;  // string | transaction hash
            var encoded = true;  // bool? | return as a raw encoded transaction. (optional) 

            try
            {
                Object result = apiInstance.Transaction(txid, encoded);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.Transaction: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **txid** | **string**| transaction hash | 
 **encoded** | **bool?**| return as a raw encoded transaction. | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## TransactionInject

> Object TransactionInject (string rawtx)

Broadcast a hex-encoded, serialized transaction to the network.

### Example

```csharp
using System.Diagnostics;
using Skyapi.Api;
using Skyapi.Client;
using Skyapi.Model;

namespace Example
{
    public class TransactionInjectExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://127.0.0.1:6420";
            // Configure API key authorization: csrfAuth
            Configuration.Default.AddApiKey("X-CSRF-TOKEN", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-CSRF-TOKEN", "Bearer");

            var apiInstance = new DefaultApi(Configuration.Default);
            var rawtx = rawtx_example;  // string | hex-encoded serialized transaction string.

            try
            {
                // Broadcast a hex-encoded, serialized transaction to the network.
                Object result = apiInstance.TransactionInject(rawtx);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.TransactionInject: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rawtx** | **string**| hex-encoded serialized transaction string. | 

### Return type

**Object**

### Authorization

[csrfAuth](../README.md#csrfAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## TransactionRaw

> Object TransactionRaw (string txid = null)

Returns the hex-encoded byte serialization of a transaction. The transaction may be confirmed or unconfirmed.

### Example

```csharp
using System.Diagnostics;
using Skyapi.Api;
using Skyapi.Client;
using Skyapi.Model;

namespace Example
{
    public class TransactionRawExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://127.0.0.1:6420";
            var apiInstance = new DefaultApi(Configuration.Default);
            var txid = txid_example;  // string | Transaction id hash (optional) 

            try
            {
                // Returns the hex-encoded byte serialization of a transaction. The transaction may be confirmed or unconfirmed.
                Object result = apiInstance.TransactionRaw(txid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.TransactionRaw: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **txid** | **string**| Transaction id hash | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## TransactionVerify

> Object TransactionVerify ()



Decode and verify an encoded transaction

### Example

```csharp
using System.Diagnostics;
using Skyapi.Api;
using Skyapi.Client;
using Skyapi.Model;

namespace Example
{
    public class TransactionVerifyExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://127.0.0.1:6420";
            // Configure API key authorization: csrfAuth
            Configuration.Default.AddApiKey("X-CSRF-TOKEN", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-CSRF-TOKEN", "Bearer");

            var apiInstance = new DefaultApi(Configuration.Default);

            try
            {
                Object result = apiInstance.TransactionVerify();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.TransactionVerify: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

**Object**

### Authorization

[csrfAuth](../README.md#csrfAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## TransactionsGet

> Object TransactionsGet (string addrs = null, string confirmed = null)

Returns transactions that match the filters.

### Example

```csharp
using System.Diagnostics;
using Skyapi.Api;
using Skyapi.Client;
using Skyapi.Model;

namespace Example
{
    public class TransactionsGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://127.0.0.1:6420";
            var apiInstance = new DefaultApi(Configuration.Default);
            var addrs = addrs_example;  // string | command separated list of addresses (optional) 
            var confirmed = confirmed_example;  // string | Whether the transactions should be confirmed [optional, must be 0 or 1; if not provided, returns all] (optional) 

            try
            {
                // Returns transactions that match the filters.
                Object result = apiInstance.TransactionsGet(addrs, confirmed);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.TransactionsGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **addrs** | **string**| command separated list of addresses | [optional] 
 **confirmed** | **string**| Whether the transactions should be confirmed [optional, must be 0 or 1; if not provided, returns all] | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## TransactionsPost

> Object TransactionsPost (string addrs = null, string confirmed = null)

Returns transactions that match the filters.

### Example

```csharp
using System.Diagnostics;
using Skyapi.Api;
using Skyapi.Client;
using Skyapi.Model;

namespace Example
{
    public class TransactionsPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://127.0.0.1:6420";
            // Configure API key authorization: csrfAuth
            Configuration.Default.AddApiKey("X-CSRF-TOKEN", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-CSRF-TOKEN", "Bearer");

            var apiInstance = new DefaultApi(Configuration.Default);
            var addrs = addrs_example;  // string | command separated list of addresses (optional) 
            var confirmed = confirmed_example;  // string | Whether the transactions should be confirmed [optional, must be 0 or 1; if not provided, returns all] (optional) 

            try
            {
                // Returns transactions that match the filters.
                Object result = apiInstance.TransactionsPost(addrs, confirmed);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.TransactionsPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **addrs** | **string**| command separated list of addresses | [optional] 
 **confirmed** | **string**| Whether the transactions should be confirmed [optional, must be 0 or 1; if not provided, returns all] | [optional] 

### Return type

**Object**

### Authorization

[csrfAuth](../README.md#csrfAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Uxout

> Object Uxout (string uxid = null)

Returns an unspent output by ID.

### Example

```csharp
using System.Diagnostics;
using Skyapi.Api;
using Skyapi.Client;
using Skyapi.Model;

namespace Example
{
    public class UxoutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://127.0.0.1:6420";
            var apiInstance = new DefaultApi(Configuration.Default);
            var uxid = uxid_example;  // string | uxid to filter by (optional) 

            try
            {
                // Returns an unspent output by ID.
                Object result = apiInstance.Uxout(uxid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.Uxout: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uxid** | **string**| uxid to filter by | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## VerifyAddress

> InlineResponse2007 VerifyAddress (string address)

Verifies a Skycoin address.

### Example

```csharp
using System.Diagnostics;
using Skyapi.Api;
using Skyapi.Client;
using Skyapi.Model;

namespace Example
{
    public class VerifyAddressExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://127.0.0.1:6420";
            // Configure API key authorization: csrfAuth
            Configuration.Default.AddApiKey("X-CSRF-TOKEN", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-CSRF-TOKEN", "Bearer");

            var apiInstance = new DefaultApi(Configuration.Default);
            var address = address_example;  // string | Address id.

            try
            {
                // Verifies a Skycoin address.
                InlineResponse2007 result = apiInstance.VerifyAddress(address);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.VerifyAddress: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| Address id. | 

### Return type

[**InlineResponse2007**](InlineResponse2007.md)

### Authorization

[csrfAuth](../README.md#csrfAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Version

> Object Version ()



versionHandler returns the application version info

### Example

```csharp
using System.Diagnostics;
using Skyapi.Api;
using Skyapi.Client;
using Skyapi.Model;

namespace Example
{
    public class VersionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://127.0.0.1:6420";
            var apiInstance = new DefaultApi(Configuration.Default);

            try
            {
                Object result = apiInstance.Version();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.Version: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Wallet

> Object Wallet (string id)

Returns a wallet by id.

### Example

```csharp
using System.Diagnostics;
using Skyapi.Api;
using Skyapi.Client;
using Skyapi.Model;

namespace Example
{
    public class WalletExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://127.0.0.1:6420";
            var apiInstance = new DefaultApi(Configuration.Default);
            var id = id_example;  // string | tags to filter by

            try
            {
                // Returns a wallet by id.
                Object result = apiInstance.Wallet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.Wallet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| tags to filter by | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## WalletBalance

> Object WalletBalance (string id)

Returns the wallet's balance, both confirmed and predicted.  The predicted balance is the confirmed balance minus the pending spends.

### Example

```csharp
using System.Diagnostics;
using Skyapi.Api;
using Skyapi.Client;
using Skyapi.Model;

namespace Example
{
    public class WalletBalanceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://127.0.0.1:6420";
            var apiInstance = new DefaultApi(Configuration.Default);
            var id = id_example;  // string | tags to filter by

            try
            {
                // Returns the wallet's balance, both confirmed and predicted.  The predicted balance is the confirmed balance minus the pending spends.
                Object result = apiInstance.WalletBalance(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.WalletBalance: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| tags to filter by | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## WalletCreate

> Object WalletCreate (string seed, string label, int? scan = null, bool? encrypt = null, string password = null)



Loads wallet from seed, will scan ahead N address and load addresses till the last one that have coins.

### Example

```csharp
using System.Diagnostics;
using Skyapi.Api;
using Skyapi.Client;
using Skyapi.Model;

namespace Example
{
    public class WalletCreateExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://127.0.0.1:6420";
            // Configure API key authorization: csrfAuth
            Configuration.Default.AddApiKey("X-CSRF-TOKEN", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-CSRF-TOKEN", "Bearer");

            var apiInstance = new DefaultApi(Configuration.Default);
            var seed = seed_example;  // string | Wallet seed.
            var label = label_example;  // string | Wallet label.
            var scan = 56;  // int? | The number of addresses to scan ahead for balances. (optional) 
            var encrypt = true;  // bool? | Encrypt wallet. (optional) 
            var password = password_example;  // string | Wallet Password (optional) 

            try
            {
                Object result = apiInstance.WalletCreate(seed, label, scan, encrypt, password);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.WalletCreate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **seed** | **string**| Wallet seed. | 
 **label** | **string**| Wallet label. | 
 **scan** | **int?**| The number of addresses to scan ahead for balances. | [optional] 
 **encrypt** | **bool?**| Encrypt wallet. | [optional] 
 **password** | **string**| Wallet Password | [optional] 

### Return type

**Object**

### Authorization

[csrfAuth](../README.md#csrfAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## WalletDecrypt

> Object WalletDecrypt (string id, string password)

Decrypts wallet.

### Example

```csharp
using System.Diagnostics;
using Skyapi.Api;
using Skyapi.Client;
using Skyapi.Model;

namespace Example
{
    public class WalletDecryptExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://127.0.0.1:6420";
            // Configure API key authorization: csrfAuth
            Configuration.Default.AddApiKey("X-CSRF-TOKEN", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-CSRF-TOKEN", "Bearer");

            var apiInstance = new DefaultApi(Configuration.Default);
            var id = id_example;  // string | Wallet id.
            var password = password_example;  // string | Wallet password.

            try
            {
                // Decrypts wallet.
                Object result = apiInstance.WalletDecrypt(id, password);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.WalletDecrypt: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Wallet id. | 
 **password** | **string**| Wallet password. | 

### Return type

**Object**

### Authorization

[csrfAuth](../README.md#csrfAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## WalletEncrypt

> Object WalletEncrypt (string id, string password)

Encrypt wallet.

### Example

```csharp
using System.Diagnostics;
using Skyapi.Api;
using Skyapi.Client;
using Skyapi.Model;

namespace Example
{
    public class WalletEncryptExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://127.0.0.1:6420";
            // Configure API key authorization: csrfAuth
            Configuration.Default.AddApiKey("X-CSRF-TOKEN", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-CSRF-TOKEN", "Bearer");

            var apiInstance = new DefaultApi(Configuration.Default);
            var id = id_example;  // string | Wallet id.
            var password = password_example;  // string | Wallet password.

            try
            {
                // Encrypt wallet.
                Object result = apiInstance.WalletEncrypt(id, password);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.WalletEncrypt: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Wallet id. | 
 **password** | **string**| Wallet password. | 

### Return type

**Object**

### Authorization

[csrfAuth](../README.md#csrfAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## WalletFolder

> InlineResponse2006 WalletFolder (string addr)



Returns the wallet directory path

### Example

```csharp
using System.Diagnostics;
using Skyapi.Api;
using Skyapi.Client;
using Skyapi.Model;

namespace Example
{
    public class WalletFolderExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://127.0.0.1:6420";
            var apiInstance = new DefaultApi(Configuration.Default);
            var addr = addr_example;  // string | Address port

            try
            {
                InlineResponse2006 result = apiInstance.WalletFolder(addr);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.WalletFolder: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **addr** | **string**| Address port | 

### Return type

[**InlineResponse2006**](InlineResponse2006.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## WalletNewAddress

> Object WalletNewAddress (string id, string num = null, string password = null)



Generates new addresses

### Example

```csharp
using System.Diagnostics;
using Skyapi.Api;
using Skyapi.Client;
using Skyapi.Model;

namespace Example
{
    public class WalletNewAddressExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://127.0.0.1:6420";
            // Configure API key authorization: csrfAuth
            Configuration.Default.AddApiKey("X-CSRF-TOKEN", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-CSRF-TOKEN", "Bearer");

            var apiInstance = new DefaultApi(Configuration.Default);
            var id = id_example;  // string | Wallet Id
            var num = num_example;  // string | The number you want to generate (optional) 
            var password = password_example;  // string | Wallet Password (optional) 

            try
            {
                Object result = apiInstance.WalletNewAddress(id, num, password);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.WalletNewAddress: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Wallet Id | 
 **num** | **string**| The number you want to generate | [optional] 
 **password** | **string**| Wallet Password | [optional] 

### Return type

**Object**

### Authorization

[csrfAuth](../README.md#csrfAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## WalletNewSeed

> Object WalletNewSeed (string entropy = null)



Returns the wallet directory path

### Example

```csharp
using System.Diagnostics;
using Skyapi.Api;
using Skyapi.Client;
using Skyapi.Model;

namespace Example
{
    public class WalletNewSeedExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://127.0.0.1:6420";
            var apiInstance = new DefaultApi(Configuration.Default);
            var entropy = entropy_example;  // string | Entropy bitSize. (optional) 

            try
            {
                Object result = apiInstance.WalletNewSeed(entropy);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.WalletNewSeed: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **entropy** | **string**| Entropy bitSize. | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## WalletRecover

> Object WalletRecover (string id, string seed, string password = null)

Recovers an encrypted wallet by providing the seed. The first address will be generated from seed and compared to the first address of the specified wallet. If they match, the wallet will be regenerated with an optional password. If the wallet is not encrypted, an error is returned.

### Example

```csharp
using System.Diagnostics;
using Skyapi.Api;
using Skyapi.Client;
using Skyapi.Model;

namespace Example
{
    public class WalletRecoverExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://127.0.0.1:6420";
            // Configure API key authorization: csrfAuth
            Configuration.Default.AddApiKey("X-CSRF-TOKEN", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-CSRF-TOKEN", "Bearer");

            var apiInstance = new DefaultApi(Configuration.Default);
            var id = id_example;  // string | Wallet id.
            var seed = seed_example;  // string | Wallet seed.
            var password = password_example;  // string | Wallet password. (optional) 

            try
            {
                // Recovers an encrypted wallet by providing the seed. The first address will be generated from seed and compared to the first address of the specified wallet. If they match, the wallet will be regenerated with an optional password. If the wallet is not encrypted, an error is returned.
                Object result = apiInstance.WalletRecover(id, seed, password);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.WalletRecover: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Wallet id. | 
 **seed** | **string**| Wallet seed. | 
 **password** | **string**| Wallet password. | [optional] 

### Return type

**Object**

### Authorization

[csrfAuth](../README.md#csrfAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## WalletSeed

> Object WalletSeed (string id, string password)

This endpoint only works for encrypted wallets. If the wallet is unencrypted, The seed will be not returned.

### Example

```csharp
using System.Diagnostics;
using Skyapi.Api;
using Skyapi.Client;
using Skyapi.Model;

namespace Example
{
    public class WalletSeedExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://127.0.0.1:6420";
            // Configure API key authorization: csrfAuth
            Configuration.Default.AddApiKey("X-CSRF-TOKEN", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-CSRF-TOKEN", "Bearer");

            var apiInstance = new DefaultApi(Configuration.Default);
            var id = id_example;  // string | Wallet Id.
            var password = password_example;  // string | Wallet password.

            try
            {
                // This endpoint only works for encrypted wallets. If the wallet is unencrypted, The seed will be not returned.
                Object result = apiInstance.WalletSeed(id, password);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.WalletSeed: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Wallet Id. | 
 **password** | **string**| Wallet password. | 

### Return type

**Object**

### Authorization

[csrfAuth](../README.md#csrfAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## WalletSeedVerify

> Object WalletSeedVerify (string seed = null)

Verifies a wallet seed.

### Example

```csharp
using System.Diagnostics;
using Skyapi.Api;
using Skyapi.Client;
using Skyapi.Model;

namespace Example
{
    public class WalletSeedVerifyExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://127.0.0.1:6420";
            // Configure API key authorization: csrfAuth
            Configuration.Default.AddApiKey("X-CSRF-TOKEN", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-CSRF-TOKEN", "Bearer");

            var apiInstance = new DefaultApi(Configuration.Default);
            var seed = seed_example;  // string | Seed to be verified. (optional) 

            try
            {
                // Verifies a wallet seed.
                Object result = apiInstance.WalletSeedVerify(seed);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.WalletSeedVerify: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **seed** | **string**| Seed to be verified. | [optional] 

### Return type

**Object**

### Authorization

[csrfAuth](../README.md#csrfAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## WalletSpent

> Object WalletSpent (string id, string dst, string coins, string password)



Creates and broadcasts a transaction sending money from one of our wallets to destination address.

### Example

```csharp
using System.Diagnostics;
using Skyapi.Api;
using Skyapi.Client;
using Skyapi.Model;

namespace Example
{
    public class WalletSpentExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://127.0.0.1:6420";
            // Configure API key authorization: csrfAuth
            Configuration.Default.AddApiKey("X-CSRF-TOKEN", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-CSRF-TOKEN", "Bearer");

            var apiInstance = new DefaultApi(Configuration.Default);
            var id = id_example;  // string | Wallet id
            var dst = dst_example;  // string | Recipient address
            var coins = coins_example;  // string | Number of coins to spend, in droplets. 1 coin equals 1e6 droplets.
            var password = password_example;  // string | Wallet password.

            try
            {
                Object result = apiInstance.WalletSpent(id, dst, coins, password);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.WalletSpent: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Wallet id | 
 **dst** | **string**| Recipient address | 
 **coins** | **string**| Number of coins to spend, in droplets. 1 coin equals 1e6 droplets. | 
 **password** | **string**| Wallet password. | 

### Return type

**Object**

### Authorization

[csrfAuth](../README.md#csrfAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## WalletTransaction

> Object WalletTransaction (InlineObject body)



Creates a signed transaction

### Example

```csharp
using System.Diagnostics;
using Skyapi.Api;
using Skyapi.Client;
using Skyapi.Model;

namespace Example
{
    public class WalletTransactionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://127.0.0.1:6420";
            // Configure API key authorization: csrfAuth
            Configuration.Default.AddApiKey("X-CSRF-TOKEN", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-CSRF-TOKEN", "Bearer");

            var apiInstance = new DefaultApi(Configuration.Default);
            var body = new InlineObject(); // InlineObject | 

            try
            {
                Object result = apiInstance.WalletTransaction(body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.WalletTransaction: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InlineObject**](InlineObject.md)|  | 

### Return type

**Object**

### Authorization

[csrfAuth](../README.md#csrfAuth)

### HTTP request headers

- **Content-Type**: application/json, application/xml
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## WalletTransactions

> Object WalletTransactions (string id)



Returns returns all unconfirmed transactions for all addresses in a given wallet verbose

### Example

```csharp
using System.Diagnostics;
using Skyapi.Api;
using Skyapi.Client;
using Skyapi.Model;

namespace Example
{
    public class WalletTransactionsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://127.0.0.1:6420";
            var apiInstance = new DefaultApi(Configuration.Default);
            var id = id_example;  // string | Wallet id.

            try
            {
                Object result = apiInstance.WalletTransactions(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.WalletTransactions: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Wallet id. | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## WalletUnload

> void WalletUnload (string id)

Unloads wallet from the wallet service.

### Example

```csharp
using System.Diagnostics;
using Skyapi.Api;
using Skyapi.Client;
using Skyapi.Model;

namespace Example
{
    public class WalletUnloadExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://127.0.0.1:6420";
            // Configure API key authorization: csrfAuth
            Configuration.Default.AddApiKey("X-CSRF-TOKEN", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-CSRF-TOKEN", "Bearer");

            var apiInstance = new DefaultApi(Configuration.Default);
            var id = id_example;  // string | Wallet Id.

            try
            {
                // Unloads wallet from the wallet service.
                apiInstance.WalletUnload(id);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.WalletUnload: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Wallet Id. | 

### Return type

void (empty response body)

### Authorization

[csrfAuth](../README.md#csrfAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## WalletUpdate

> void WalletUpdate (string id, string label)

Update the wallet.

### Example

```csharp
using System.Diagnostics;
using Skyapi.Api;
using Skyapi.Client;
using Skyapi.Model;

namespace Example
{
    public class WalletUpdateExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://127.0.0.1:6420";
            // Configure API key authorization: csrfAuth
            Configuration.Default.AddApiKey("X-CSRF-TOKEN", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-CSRF-TOKEN", "Bearer");

            var apiInstance = new DefaultApi(Configuration.Default);
            var id = id_example;  // string | Wallet Id.
            var label = label_example;  // string | The label the wallet will be updated to.

            try
            {
                // Update the wallet.
                apiInstance.WalletUpdate(id, label);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.WalletUpdate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Wallet Id. | 
 **label** | **string**| The label the wallet will be updated to. | 

### Return type

void (empty response body)

### Authorization

[csrfAuth](../README.md#csrfAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Wallets

> List<InlineResponse2005> Wallets ()



Returns all loaded wallets

### Example

```csharp
using System.Diagnostics;
using Skyapi.Api;
using Skyapi.Client;
using Skyapi.Model;

namespace Example
{
    public class WalletsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://127.0.0.1:6420";
            var apiInstance = new DefaultApi(Configuration.Default);

            try
            {
                List&lt;InlineResponse2005&gt; result = apiInstance.Wallets();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.Wallets: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**List<InlineResponse2005>**](InlineResponse2005.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)
