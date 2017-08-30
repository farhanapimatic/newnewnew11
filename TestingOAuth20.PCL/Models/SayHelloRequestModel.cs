/*
 * TestingOAuth20.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using TestingOAuth20.PCL;
using TestingOAuth20.PCL.Utilities;


namespace TestingOAuth20.PCL.Models
{
    public class SayHelloRequestModel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string firstName;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("firstName")]
        public string FirstName 
        { 
            get 
            {
                return this.firstName; 
            } 
            set 
            {
                this.firstName = value;
                onPropertyChanged("FirstName");
            }
        }
    }
} 