
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using TestingOAuth20.PCL.Controllers;
using TestingOAuth20.PCL.Exceptions;
using TestingOAuth20.PCL.Models;

namespace TestingOAuth20.PCL.Utilities
{
    public class AuthManager
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static AuthManager instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static AuthManager Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new AuthManager();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern





        public string BuildAuthorizationUrl(string state,Dictionary<string,object> additionalParameters = null)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/authorize");

            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>
            {
                { "response_type", "code" },
                { "client_id" , Configuration.OAuthClientId},
                { "redirect_uri" , Configuration.OAuthRedirectUri},
                { "state" , state}
            });
            if(additionalParameters!=null)
                APIHelper.AppendUrlWithQueryParameters(_queryBuilder,additionalParameters);

            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            return _queryUrl;
        }
    }
}