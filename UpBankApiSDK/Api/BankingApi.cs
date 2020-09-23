/* 
 * Up Bank API
 *
 * OpenAPI spec version
 *
 * Initial build - : 2020-09-20
 * 
 * Select Systems International : http://selectsystems.com.au
 * 
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using RestSharp;
using Newtonsoft.Json;

using UpBankApi.Client;
using UpBankApi.Model;

namespace UpBankApi.Api
{

    /// <summary>
    ///  Class for testing BankingApi
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// 
    public interface IBankingApi : IApiAccessor
    {

        #region Synchronous Operations

        /// <summary>
        /// Formats a Get Request with Http Information and Calls the Api
        /// </summary>
        ApiResponse<object> GetWithHttpInfo(string name, string localVarPath);

        /// <summary>
        /// Formats a Post Request with Http Information and Calls the Api
        /// </summary>
        ApiResponse<object> PostWithHttpInfo(string name, string localVarPath, object postData);

        /// <summary>
        /// Formats a Delete Request with Http Information and Calls the Api
        /// </summary>
        ApiResponse<object> DeleteWithHttpInfo(string name, string localVarPath, object deleteData);

        /// <summary>
        /// Formats a Put Request with Http Information and Calls the Api
        /// </summary>
        ApiResponse<object> PutWithHttpInfo(string name, string localVarPath, object putData);

        /// <summary>
        /// Formats a Put Request with Http Information and Calls the Api
        /// </summary>
        public ApiResponse<object> PatchWithHttpInfo(string name, string localVarPath, object patchData);

        #endregion Synchronous Operations

        #region Api

        /// <summary>
        /// Check Authentication using Utility Ping 
        /// </summary>
        Pingdata UtilityPing();

        /// <summary>
        /// Retrieves the details of an account by id
        /// </summary>
        Account AccountGet(string id = null);

        /// <summary>
        /// Returns a list of accounts
        /// </summary>
        AccountList AccountList(int pageSize = 0);

        /// <summary>
        /// Returns a transaction by id
        /// </summary>
        Transaction TransactionGet(string id = null);

        /// <summary>
        /// Adds a tag to a transaction id
        /// </summary>
        Transaction TransactionAddTag(string id = null, object tagInput = null);

        /// <summary>
        /// Deletes a tag from a transaction id
        /// </summary>
        Transaction TransactionDeleteTag(string id = null, object tagInput = null);

        /// <summary>
        /// Returns a list of all transactions
        /// </summary>
        TransactionList TransactionList(int pageSize = 0);

        /// <summary>
        /// Returns a list of all transactions for an account id
        /// </summary>
        TransactionList TransactionListForAccount(string id = null, int pageSize = 0);

        /// <summary>
        /// Returns a category by id
        /// </summary>
        Category CategoryGet(string id = null);

        /// <summary>
        /// Returns a list of all categories
        /// </summary>
        CategoryList CategoryList(int pageSize = 0);

        /// <summary>
        /// Returns a list of tags
        /// </summary>
        TagList TagList(int pageSize = 0);

        /// <summary>
        /// Returns a list of webhooks
        /// </summary>
        WebhookList WebhooksList(int pageSize = 0);

        /// <summary>
        /// Returns a webhhok by id
        /// </summary>
        Webhook WebhookGet(string id = null);

        /// <summary>
        /// Creates a webhook
        /// </summary>
        Webhook WebhookCreate(WebhookInputAttributes webhookInputAttributes);

        /// <summary>
        /// Deletes a webhook by id
        /// </summary>
        Webhook WebhookDelete(string id = null);

        /// <summary>
        /// Ping a webhook by id
        /// </summary>
        WebhookEvent WebhookPing(string id = null);

        /// <summary>
        /// Ping a webhook delivery log by webhook id
        /// </summary>
        WebhookDeliveryLog WebhookGetDeliveryLog(string id = null, int pageSize = 0);

	#endregion

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class BankingApi : IBankingApi
    {
        private UpBankApi.Client.ExceptionFactory _exceptionFactory = (name, response) => null;


        /// <summary>
        /// Initializes a new instance of the <see cref="BankingApi"/> class
        /// </summary>
        /// <returns></returns>
        public BankingApi(String basePath, String apiToken)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
            if (apiToken != null)
                this.Configuration.ApiToken = apiToken;

            ExceptionFactory = UpBankApi.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankingApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public BankingApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = UpBankApi.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions
        /// </summary>
        public UpBankApi.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Formats a Get Request with Http Information and Calls the Api
        /// </summary>
        /// <remarks>
        /// General routine called by all backing requests
        /// </remarks>
        /// <exception cref="UpBankApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the calling routine</param>
        /// <param name="localVarPath">The path endpoint for this call</param>
        /// <returns>object</returns>
        public ApiResponse<object> GetWithHttpInfo(string name, string localVarPath)
        {
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/javascript"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/javascript"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory(name, localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode, localVarResponse);
        }

        /// <summary>
        /// Formats a Post Request with Http Information and Calls the Api
        /// </summary>
        /// <remarks>
        /// General routine called by all backing requests
        /// </remarks>
        /// <exception cref="UpBankApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the calling routine</param>
        /// <param name="localVarPath">The path endpoint for this call</param>
        /// <param name="postData">The data object to post</param>
        /// <returns>object</returns>
        public ApiResponse<object> PostWithHttpInfo(string name, string localVarPath, object postData)
        {
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = postData;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] { "application/json" };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] { "application/javascript" };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

            localVarPathParams.Add("content-type", "application/json");

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory(name, localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode, localVarResponse);
        }

        /// <summary>
        /// Formats a Delete Request with Http Information and Calls the Api
        /// </summary>
        /// <remarks>
        /// General routine called by all backing requests
        /// </remarks>
        /// <exception cref="UpBankApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the calling routine</param>
        /// <param name="localVarPath">The path endpoint for this call</param>
        /// <param name="deleteData">The data object to delete</param>
        /// <returns>object</returns>
        public ApiResponse<object> DeleteWithHttpInfo(string name, string localVarPath, object deleteData)
        {
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = deleteData;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] { "application/json" };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] { "application/javascript" };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("content-type", "application/json");

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory(name, localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode, localVarResponse);
        }

        /// <summary>
        /// Formats a Put Request with Http Information and Calls the Api
        /// </summary>
        /// <remarks>
        /// General routine called by all backing requests
        /// </remarks>
        /// <exception cref="UpBankApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the calling routine</param>
        /// <param name="localVarPath">The path endpoint for this call</param>
        /// <param name="putData">The data object to put</param>
        /// <returns>object</returns>
        public ApiResponse<object> PutWithHttpInfo(string name, string localVarPath, object putData)
        {
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = putData;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] { "application/json" };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] { "application/javascript" };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

            localVarPathParams.Add("content-type", "application/json");

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory(name, localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode, localVarResponse);
        }

        /// <summary>
        /// Formats a Put Request with Http Information and Calls the Api
        /// </summary>
        /// <remarks>
        /// General routine called by all backing requests
        /// </remarks>
        /// <exception cref="UpBankApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the calling routine</param>
        /// <param name="localVarPath">The path endpoint for this call</param>
        /// <param name="patchData">The data object to put</param>
        /// <returns>object</returns>
        public ApiResponse<object> PatchWithHttpInfo(string name, string localVarPath, object patchData)
        {
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = patchData;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] { "application/json" };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] { "application/javascript" };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

            localVarPathParams.Add("content-type", "application/json");

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory(name, localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode, localVarResponse);
        }

        /// <summary>
        /// Check Authentication using Utility Ping 
        /// </summary>
        /// <exception cref="UpBankApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Pingdata</returns>
        public Pingdata UtilityPing()
        {
            string localVarPath = GetBasePath() + "/util/ping";
            this.Configuration.AddDefaultHeader("Authorization", "Bearer " + Configuration.ApiToken);
            ApiResponse<object>localVarResponse = GetWithHttpInfo("UtilityPing", localVarPath);

            return (Pingdata)this.Configuration.ApiClient.Deserialize((IRestResponse)localVarResponse.Data, typeof(Pingdata));
        }

        /// <summary>
        /// Retrieves the details of an account by id
        /// </summary>
        /// <exception cref="UpBankApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>Account</returns>
        public Account AccountGet(string id = null)
        {
            string localVarPath = GetBasePath() + "/accounts/" + id;
            this.Configuration.AddDefaultHeader("Authorization", "Bearer " + Configuration.ApiToken);
            ApiResponse<object> localVarResponse = GetWithHttpInfo("AccountGet", localVarPath);

            return (Account)this.Configuration.ApiClient.Deserialize((IRestResponse)localVarResponse.Data, typeof(Account));
        }

        /// <summary>
        /// Returns a list of accounts
        /// </summary>
        /// <exception cref="UpBankApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize"></param>
        /// <returns>AccountList</returns>
        public AccountList AccountList(int pageSize = 0)
        {
            string localVarPath = GetBasePath() + "/accounts";
            if (pageSize != 0)
                localVarPath += "?pageSize[size]=" + pageSize.ToString();

            this.Configuration.AddDefaultHeader("Authorization", "Bearer " + Configuration.ApiToken);
            ApiResponse<object> localVarResponse = GetWithHttpInfo("AccountList", localVarPath);

            return (AccountList)this.Configuration.ApiClient.Deserialize((IRestResponse)localVarResponse.Data, typeof(AccountList));
        }

        /// <summary>
        /// Returns a transaction by id
        /// </summary>
        /// <exception cref="UpBankApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>Transaction </returns>
        public Transaction TransactionGet(string id = null)
        {
            string localVarPath = GetBasePath() + "/transactions/" + id.ToString();

            this.Configuration.AddDefaultHeader("Authorization", "Bearer " + Configuration.ApiToken);
            ApiResponse<object> localVarResponse = GetWithHttpInfo("TransactionGet", localVarPath);

            return (Transaction)this.Configuration.ApiClient.Deserialize((IRestResponse)localVarResponse.Data, typeof(Transaction));
        }

        /// <summary>
        /// Adds a tag to a transaction id
        /// </summary>
        /// <exception cref="UpBankApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="tagInput"></param>
        /// <returns>Transaction</returns>
        public Transaction TransactionAddTag(string id = null, object tagInput = null)
        {
            string localVarPath = GetBasePath() + "/transactions/" + id.ToString() + "/relationships/tags";

            this.Configuration.AddDefaultHeader("Authorization", "Bearer " + Configuration.ApiToken);
            ApiResponse<object> localVarResponse = PostWithHttpInfo("TransactionGet", localVarPath, tagInput);

            return (Transaction)this.Configuration.ApiClient.Deserialize((IRestResponse)localVarResponse.Data, typeof(Transaction));
        }

        /// <summary>
        /// Deletes a tag from a transaction id
        /// </summary>
        /// <exception cref="UpBankApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns></returns>
        public Transaction TransactionDeleteTag(string id = null, object tagInput = null)
        {
            string localVarPath = GetBasePath() + "/transactions/" + id.ToString() + "/relationships/tags";

            this.Configuration.AddDefaultHeader("Authorization", "Bearer " + Configuration.ApiToken);
            ApiResponse<object> localVarResponse = DeleteWithHttpInfo("TransactionGet", localVarPath, tagInput);

            return (Transaction)this.Configuration.ApiClient.Deserialize((IRestResponse)localVarResponse.Data, typeof(Transaction));
        }

        /// <summary>
        /// Returns a list of all transactions
        /// </summary>
        /// <exception cref="UpBankApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize"></param>
        /// <returns>TransactionList</returns>
        public TransactionList TransactionList(int pageSize = 0)
        {
            string localVarPath = GetBasePath() + "/transactions";
            if (pageSize != 0)
                localVarPath += "?pageSize[size]=" + pageSize.ToString();

            this.Configuration.AddDefaultHeader("Authorization", "Bearer " + Configuration.ApiToken);
            ApiResponse<object> localVarResponse = GetWithHttpInfo("TransactionList", localVarPath);

            return (TransactionList)this.Configuration.ApiClient.Deserialize((IRestResponse)localVarResponse.Data, typeof(TransactionList));
        }

        /// <summary>
        /// Returns a list of all transactions for an account id
        /// </summary>
        /// <exception cref="UpBankApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param> 
        /// <param name="pageSize"></param>
        /// <returns>TransactionList</returns>
        public TransactionList TransactionListForAccount(string id = null, int pageSize = 0)
        {
            string localVarPath = GetBasePath() + "/accounts/" + id.ToString() + "/transactions";
            if (pageSize != 0)
                localVarPath += "?pageSize[size]=" + pageSize.ToString();

            this.Configuration.AddDefaultHeader("Authorization", "Bearer " + Configuration.ApiToken);
            ApiResponse<object> localVarResponse = GetWithHttpInfo("TransactionListForAccount", localVarPath);

            return (TransactionList)this.Configuration.ApiClient.Deserialize((IRestResponse)localVarResponse.Data, typeof(TransactionList));
        }

        /// <summary>
        /// Returns a category by id
        /// </summary>
        /// <exception cref="UpBankApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param> 
        /// <returns>Category</returns>
        public Category CategoryGet(string id = null)
        {
            string localVarPath = GetBasePath() + "/categories/" + id.ToString();

            this.Configuration.AddDefaultHeader("Authorization", "Bearer " + Configuration.ApiToken);
            ApiResponse<object> localVarResponse = GetWithHttpInfo("CategoryGet", localVarPath);

            return (Category)this.Configuration.ApiClient.Deserialize((IRestResponse)localVarResponse.Data, typeof(Category));
        }

        /// <summary>
        /// Returns a list of all categories
        /// </summary>
        /// <exception cref="UpBankApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize"></param>
        /// <returns>CategoryList</returns>
        public CategoryList CategoryList(int pageSize = 0)
        {
            string localVarPath = GetBasePath() + "/categories";
            if (pageSize != 0)
                localVarPath += "?pageSize[size]=" + pageSize.ToString();

            this.Configuration.AddDefaultHeader("Authorization", "Bearer " + Configuration.ApiToken);
            ApiResponse<object> localVarResponse = GetWithHttpInfo("CategoryList", localVarPath);

            return (CategoryList)this.Configuration.ApiClient.Deserialize((IRestResponse)localVarResponse.Data, typeof(CategoryList));
        }

        /// <summary>
        /// Returns a list of tags
        /// </summary>
        /// <exception cref="UpBankApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize"></param>
        /// <returns>TagList</returns>
        public TagList TagList(int pageSize = 0)
        {
            string localVarPath = GetBasePath() + "/tags";
            if (pageSize != 0)
                localVarPath += "?pageSize[size]=" + pageSize.ToString();

            this.Configuration.AddDefaultHeader("Authorization", "Bearer " + Configuration.ApiToken);
            ApiResponse<object> localVarResponse = GetWithHttpInfo("TagList", localVarPath);

            return (TagList)this.Configuration.ApiClient.Deserialize((IRestResponse)localVarResponse.Data, typeof(TagList));
        }

        /// <summary>
        /// Returns a list of webhooks
        /// </summary>
        /// <exception cref="UpBankApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize"></param>
        /// <returns>WebhookList</returns>
        public WebhookList WebhooksList(int pageSize = 0)
        {
            string localVarPath = GetBasePath() + "/webhooks";
            if (pageSize != 0)
                localVarPath += "?pageSize[size]=" + pageSize.ToString();

            this.Configuration.AddDefaultHeader("Authorization", "Bearer " + Configuration.ApiToken);
            ApiResponse<object> localVarResponse = GetWithHttpInfo("WebhooksList", localVarPath);

            return (WebhookList) this.Configuration.ApiClient.Deserialize((IRestResponse) localVarResponse.Data, typeof(WebhookList));
        }

        /// <summary>
        /// Returns a webhhok by id
        /// </summary>
        /// <exception cref="UpBankApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>Webhook</returns>
        public Webhook WebhookGet(string id = null)
        {
            string localVarPath = GetBasePath() + "/webhooks/" + id.ToString();

            this.Configuration.AddDefaultHeader("Authorization", "Bearer " + Configuration.ApiToken);
            ApiResponse<object> localVarResponse = GetWithHttpInfo("WebhookGet", localVarPath);

            return (Webhook)this.Configuration.ApiClient.Deserialize((IRestResponse)localVarResponse.Data, typeof(Webhook));
        }

        /// <summary>
        /// Creates a webhook
        /// </summary>
        /// <exception cref="UpBankApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webhookInputAttributes"></param>
        /// <returns>Webhook</returns>
        public Webhook WebhookCreate(WebhookInputAttributes webhookInputAttributes)
        {
            WebhookInputResource webhookInputResource = new WebhookInputResource(webhookInputAttributes);
            WebhookInput webhookInput = new WebhookInput(webhookInputResource);
            object data = webhookInput.ToJson();

            string localVarPath = GetBasePath() + "/webhooks";

            this.Configuration.AddDefaultHeader("Authorization", "Bearer " + Configuration.ApiToken);
            ApiResponse<object> localVarResponse = PostWithHttpInfo("WebhookCreate", localVarPath, data);

            return (Webhook)this.Configuration.ApiClient.Deserialize((IRestResponse)localVarResponse.Data, typeof(Webhook));
        }

        /// <summary>
        /// Deletes a webhook by id
        /// </summary>
        /// <exception cref="UpBankApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>Webhook</returns>
        public Webhook WebhookDelete(string id = null)
        {
            string localVarPath = GetBasePath() + "/webhooks/" + id.ToString();

            this.Configuration.AddDefaultHeader("Authorization", "Bearer " + Configuration.ApiToken);
            ApiResponse<object> localVarResponse = DeleteWithHttpInfo("WebhookDelete", localVarPath, null);

            return (Webhook)this.Configuration.ApiClient.Deserialize((IRestResponse)localVarResponse.Data, typeof(Webhook));
        }

        /// <summary>
        /// Ping a webhook by id
        /// </summary>
        /// <exception cref="UpBankApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>WebhookEvent</returns>
        public WebhookEvent WebhookPing(string id = null)
        {
            string localVarPath = GetBasePath() + "/webhooks/" + id.ToString() + "/ping";

            this.Configuration.AddDefaultHeader("Authorization", "Bearer " + Configuration.ApiToken);
            ApiResponse<object> localVarResponse = PostWithHttpInfo("WebhookPing", localVarPath, ' ');

            return (WebhookEvent)this.Configuration.ApiClient.Deserialize((IRestResponse)localVarResponse.Data, typeof(WebhookEvent));
        }

        /// <summary>
        /// Ping a webhook delivery log by webhook id
        /// </summary>
        /// <exception cref="UpBankApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="pageSize"></param>
        /// <returns>WebhookDeliveryLog</returns>
        public WebhookDeliveryLog WebhookGetDeliveryLog(string id = null, int pageSize = 0)
        {
            string localVarPath = GetBasePath() + "/webhooks/" + id.ToString() + "/logs";
            if (pageSize != 0)
                localVarPath += "?pageSize[size]=" + pageSize.ToString();

            this.Configuration.AddDefaultHeader("Authorization", "Bearer " + Configuration.ApiToken);
            ApiResponse<object> localVarResponse = GetWithHttpInfo("WebhookDeliveryLog", localVarPath);

            return (WebhookDeliveryLog)this.Configuration.ApiClient.Deserialize((IRestResponse)localVarResponse.Data, typeof(WebhookDeliveryLog));
        }

    }
}
