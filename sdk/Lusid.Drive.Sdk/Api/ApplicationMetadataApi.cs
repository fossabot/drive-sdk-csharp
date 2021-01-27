/* 
 * FINBOURNE Drive API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.1.174
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp.Portable;
using Lusid.Drive.Sdk.Client;
using Lusid.Drive.Sdk.Model;

namespace Lusid.Drive.Sdk.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IApplicationMetadataApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// [EARLY ACCESS] Get resources available for access control
        /// </summary>
        /// <remarks>
        /// Get the comprehensive set of resources that are available for access control
        /// </remarks>
        /// <exception cref="Lusid.Drive.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ResourceListOfAccessControlledResource</returns>
        ResourceListOfAccessControlledResource ListAccessControlledResources ();

        /// <summary>
        /// [EARLY ACCESS] Get resources available for access control
        /// </summary>
        /// <remarks>
        /// Get the comprehensive set of resources that are available for access control
        /// </remarks>
        /// <exception cref="Lusid.Drive.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ResourceListOfAccessControlledResource</returns>
        ApiResponse<ResourceListOfAccessControlledResource> ListAccessControlledResourcesWithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// [EARLY ACCESS] Get resources available for access control
        /// </summary>
        /// <remarks>
        /// Get the comprehensive set of resources that are available for access control
        /// </remarks>
        /// <exception cref="Lusid.Drive.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ResourceListOfAccessControlledResource</returns>
        System.Threading.Tasks.Task<ResourceListOfAccessControlledResource> ListAccessControlledResourcesAsync ();

        /// <summary>
        /// [EARLY ACCESS] Get resources available for access control
        /// </summary>
        /// <remarks>
        /// Get the comprehensive set of resources that are available for access control
        /// </remarks>
        /// <exception cref="Lusid.Drive.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ResourceListOfAccessControlledResource)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResourceListOfAccessControlledResource>> ListAccessControlledResourcesAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ApplicationMetadataApi : IApplicationMetadataApi
    {
        private Lusid.Drive.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationMetadataApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ApplicationMetadataApi(String basePath)
        {
            this.Configuration = new Lusid.Drive.Sdk.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Lusid.Drive.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationMetadataApi"/> class
        /// </summary>
        /// <returns></returns>
        public ApplicationMetadataApi()
        {
            this.Configuration = Lusid.Drive.Sdk.Client.Configuration.Default;

            ExceptionFactory = Lusid.Drive.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationMetadataApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ApplicationMetadataApi(Lusid.Drive.Sdk.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Lusid.Drive.Sdk.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Lusid.Drive.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Lusid.Drive.Sdk.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Lusid.Drive.Sdk.Client.ExceptionFactory ExceptionFactory
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
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// [EARLY ACCESS] Get resources available for access control Get the comprehensive set of resources that are available for access control
        /// </summary>
        /// <exception cref="Lusid.Drive.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ResourceListOfAccessControlledResource</returns>
        public ResourceListOfAccessControlledResource ListAccessControlledResources ()
        {
             ApiResponse<ResourceListOfAccessControlledResource> localVarResponse = ListAccessControlledResourcesWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] Get resources available for access control Get the comprehensive set of resources that are available for access control
        /// </summary>
        /// <exception cref="Lusid.Drive.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ResourceListOfAccessControlledResource</returns>
        public ApiResponse< ResourceListOfAccessControlledResource > ListAccessControlledResourcesWithHttpInfo ()
        {

            var localVarPath = "./api/metadata/access/resources";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-SDK-Language"] = "C#";
            localVarHeaderParams["X-LUSID-SDK-Version"] = "0.1.174";

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ListAccessControlledResources", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ResourceListOfAccessControlledResource>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (ResourceListOfAccessControlledResource) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResourceListOfAccessControlledResource)));
        }

        /// <summary>
        /// [EARLY ACCESS] Get resources available for access control Get the comprehensive set of resources that are available for access control
        /// </summary>
        /// <exception cref="Lusid.Drive.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ResourceListOfAccessControlledResource</returns>
        public async System.Threading.Tasks.Task<ResourceListOfAccessControlledResource> ListAccessControlledResourcesAsync ()
        {
             ApiResponse<ResourceListOfAccessControlledResource> localVarResponse = await ListAccessControlledResourcesAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// [EARLY ACCESS] Get resources available for access control Get the comprehensive set of resources that are available for access control
        /// </summary>
        /// <exception cref="Lusid.Drive.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ResourceListOfAccessControlledResource)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ResourceListOfAccessControlledResource>> ListAccessControlledResourcesAsyncWithHttpInfo ()
        {

            var localVarPath = "./api/metadata/access/resources";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-Sdk-Language"] = "C#";
            localVarHeaderParams["X-LUSID-Sdk-Version"] = "0.1.174";

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ListAccessControlledResources", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ResourceListOfAccessControlledResource>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (ResourceListOfAccessControlledResource) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResourceListOfAccessControlledResource)));
        }

    }
}