using System;
using System.Web;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web.Configuration;

namespace BillSystem.ApiOperation
{

    public partial class ApiOperation
    {
        private HttpClient httpClient;

        public ApiOperation()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:49558"); //new Uri(WebConfigurationManager.AppSettings["PathForWebAPI"]); //new Uri("http://localhost:49558");//WebConfigurationManager.AppSettings["PathForWebAPI"]);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.Timeout = TimeSpan.FromMinutes(10);
            httpClient.MaxResponseContentBufferSize = 2147483647;
        }

        public object RunApiOperation(string baseUri, string actionUri, Dictionary<string, object> paramDictionary, Type type)
        {
            HttpResponseMessage response = httpClient.GetAsync(GetUriByDictionary(baseUri, actionUri, paramDictionary)).Result;

            if (response.IsSuccessStatusCode)
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(type);
                string jstr = response.Content.ReadAsStringAsync().Result;
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(type);
                MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(jstr));
                return ser.ReadObject(ms);
            }
            else
            {
                string jstr = response.Content.ReadAsStringAsync().Result;

                if (response.Content != null)
                {
                    throw new HttpException(jstr);
                }
                else
                    throw new HttpException("content was of type " + (response.Content).GetType());
            }
        }

        public string GetUriByDictionary(string baseUri, string actionUri, Dictionary<string, object> paramDictionary)
        {
            string uriAddr = baseUri + actionUri;
            if (paramDictionary != null)
            {
                uriAddr = uriAddr + "?";
                var first = paramDictionary.First();
                //uriAddr = uriAddr + first.Key + "=" + first.Value;

                if (first.Value != null && first.Value.GetType() == typeof(String))
                {
                    uriAddr = uriAddr + first.Key + "=" + HttpContext.Current.Server.UrlEncode(first.Value as String);
                }
                else
                {
                    uriAddr = uriAddr + first.Key + "=" + first.Value;
                }

                paramDictionary.Remove(paramDictionary.Keys.First());

                foreach (string key in paramDictionary.Keys)
                {
                    //uriAddr = uriAddr + "&" + key + "=" + paramDictionary[key];

                    if (paramDictionary[key] != null && paramDictionary[key].GetType() == typeof(String))
                    {
                        uriAddr = uriAddr + "&" + key + "=" + HttpContext.Current.Server.UrlEncode(paramDictionary[key] as String);
                    }
                    else
                    {
                        uriAddr = uriAddr + "&" + key + "=" + paramDictionary[key];
                    }

                }
            }

            return uriAddr;
        }
    }
}
