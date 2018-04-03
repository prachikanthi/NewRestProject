using RestSharp;
//using RestSharp.Deserializers;
using System.Linq;
using RestSharp.Deserializers;
using System;
using Newtonsoft.Json;
using System.IO;

namespace RestBasicProject
{
    /// <summary>
    /// This is support class contains execute method 
    /// </summary>
    public class SupportClass
    {
       
        /// <summary>
        /// This method executes request also desrializes the response
        /// </summary>
        /// <typeparam name="T">RestSharp parameters</typeparam>
        /// <param name="request">Rest Client</param>
        /// <param name="client">Rest Request</param>
        /// <returns>Returns Response of request if passes the request</returns>
        public T Execute<T>(RestRequest request, RestClient client) where T : new()
        {
            
            IRestResponse response = client.Execute<T>(request);
            var responseData = new T();

            if (request.Parameters.Any(str=>str.Value.Equals("application/json")))
            {
                JsonDeserializer jsonDeserializer = new JsonDeserializer();
               responseData  = JsonConvert.DeserializeObject<T>(response.Content);
             //responseData = jsonDeserializer.Deserialize<T>(response);
            }
            else
            {
               
                // System.Xml.Serialization.XmlSerializer xmlserializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
                // responseData = (T)xmlserializer.Deserialize(new StringReader(response.Content));
                XmlDeserializer xml = new XmlDeserializer();
                responseData = xml.Deserialize<T>(new RestResponse { Content = response.Content });
            }

            if (response.ErrorException != null)
            {
                const string message = "Error retrieving response.  Check inner details for more info.";
                var twilioException = new ApplicationException(message, response.ErrorException);
                throw twilioException;
            }
            return responseData;

        }
    }
}
