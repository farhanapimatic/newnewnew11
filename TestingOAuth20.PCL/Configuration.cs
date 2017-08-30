using System.Collections.Generic;
using System.Text;
using TestingOAuth20.PCL.Utilities;
using TestingOAuth20.PCL.Models;
namespace TestingOAuth20.PCL
{
    public partial class Configuration
    {

        public enum Environments
        {
            PRODUCTION,
        }
        public enum Servers
        {
            HELLO_PORT,
        }

        //The current environment being used
        public static Environments Environment = Environments.PRODUCTION;

        //OAuth 2 Client ID
        //TODO: Replace the OAuthClientId with an appropriate value
        public static string OAuthClientId = "TODO: Replace";

        //OAuth 2 Redirection endpoint or Callback Uri
        //TODO: Replace the OAuthRedirectUri with an appropriate value
        public static string OAuthRedirectUri = "TODO: Replace";

        //A map of environments and their corresponding servers/baseurls
        public static Dictionary<Environments, Dictionary<Servers, string>> EnvironmentsMap =
            new Dictionary<Environments, Dictionary<Servers, string>>
            {
                { 
                    Environments.PRODUCTION,new Dictionary<Servers, string>
                    {
                        { Servers.HELLO_PORT,"http://www.examples.com/SayHello/" },
                    }
                },
            };

        /// <summary>
        /// Makes a list of the BaseURL parameters 
        /// </summary>
        /// <return>Returns the parameters list</return>
        internal static List<KeyValuePair<string, object>> GetBaseURIParameters()
        {
            List<KeyValuePair<string, object>> kvpList = new List<KeyValuePair<string, object>>()
            {
            };
            return kvpList; 
        }

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends it with template parameters
        /// </summary>
        /// <param name="alias">Default value:HELLO_PORT</param>
        /// <return>Returns the baseurl</return>
        internal static string GetBaseURI(Servers alias = Servers.HELLO_PORT)
        {
            StringBuilder Url =  new StringBuilder(EnvironmentsMap[Environment][alias]);
            APIHelper.AppendUrlWithTemplateParameters(Url, GetBaseURIParameters());
            return Url.ToString();        
        }
    }
}