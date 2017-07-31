using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tests
{
    public class HttpClientHelper
    {
        public static T PostJsonData<T>(string address, object postData)
        {

            string responseFromServer = "";
            StreamReader reader = null;
            Stream dataStream = null;
            WebResponse response = null;
            WebRequest request = null;

            //  JavaScriptSerializer serializer = new JavaScriptSerializer();
            string data = Newtonsoft.Json.JsonConvert.SerializeObject(postData);

            request = WebRequest.Create(address);

            string resultStatus = string.Empty;
            //try
            //{
            request.Method = "POST";
            request.Timeout = 300000000;
            byte[] byteArray = Encoding.UTF8.GetBytes(data);

            request.ContentType = "application/json";
            request.ContentLength = byteArray.Length;
            dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();


            response = request.GetResponse();
            dataStream = response.GetResponseStream();
            reader = new StreamReader(dataStream);

            responseFromServer = reader.ReadToEnd();

            reader.Close();
            dataStream.Close();
            response.Close();

            T _res = default(T);
            _res = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(responseFromServer);


            //}
            //catch (WebException e)
            //{
            //    //return "error in operation!! TIME OUT";
            //    error = e.Message;
            //    throw new Exception(e.Message);
            //}

            return _res;
        }
        public static string Get(string address, string baseAddress = null)
        {
            WebResponse response = null;
            Stream stream = null;
            string baseadd = baseAddress == null ? "" : baseAddress;

            WebRequest request = WebRequest.Create(baseAddress + address);
            request.Method = "GET";
            response = request.GetResponse();
            stream = response.GetResponseStream();
            StreamReader str = new StreamReader(stream);

            string jsonmessage = str.ReadToEnd();

            str.Close();
            response.Close();
            stream.Close();

            return jsonmessage;
        }
        public static object _monitorObject = new object();

        //public async static Task<T> GetJsonAsync<T>(string actionAddress, string serviceBaseAddress = null)
        //{
        //    using (HttpClient client = new HttpClient())
        //    {
        //        if (!string.IsNullOrEmpty(serviceBaseAddress))
        //            client.BaseAddress = new Uri(serviceBaseAddress);

        //        client.DefaultRequestHeaders.Accept.Add(
        //            new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

        //        HttpResponseMessage response = await client.PostAsync(actionAddress, new StringContent(""));
        //        if (response.IsSuccessStatusCode)
        //        {
        //            return await (Task<T>)response.Content.ReadAsAsync<T>();
        //        }
        //        else
        //            return default(T);
        //    }
        //}

        public static T GetJson<T>(string actionAddress, string serviceBaseAddress = null)
        {
            ExceptionDispatchInfo exDispatchInfo = null;
            T result = default(T);

            using (System.Net.WebClient client = new System.Net.WebClient())
            {
                if (!string.IsNullOrEmpty(serviceBaseAddress))
                    client.BaseAddress = serviceBaseAddress;

                //client.Headers[System.Net.HttpRequestHeader.ContentType] = "application/json";
                // Monitor.Enter(_monitorObject);

                try
                {
                    string strResult = (new System.Text.UTF8Encoding()).GetString(client.UploadValues(actionAddress, "POST", new System.Collections.Specialized.NameValueCollection()));
                    result = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(strResult);
                }
                catch (Exception ex)
                {
                    exDispatchInfo = ExceptionDispatchInfo.Capture(ex);
                }
                finally
                {
                    //Monitor.Exit(_monitorObject);
                }

                if (exDispatchInfo != null)
                    exDispatchInfo.Throw();

            }
            return result;
        }

        public async static Task PostJsonAsync(string actionAddress, string serviceBaseAddress = null)
        {
            using (HttpClient client = new HttpClient())
            {
                if (!string.IsNullOrEmpty(serviceBaseAddress))
                    client.BaseAddress = new Uri(serviceBaseAddress);

                client.DefaultRequestHeaders.Accept.Add(
                    new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.PostAsync(actionAddress, new StringContent(""));
                return;
            }
        }
        public static void PostJsonNotAsync(string actionAddress, string serviceBaseAddress = null)
        {
            using (HttpClient client = new HttpClient())
            {
                if (!string.IsNullOrEmpty(serviceBaseAddress))
                    client.BaseAddress = new Uri(serviceBaseAddress);

                client.DefaultRequestHeaders.Accept.Add(
                    new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded"));

                HttpResponseMessage response = client.PostAsync(actionAddress, new StringContent("")).Result;

                return;
            }
        }

        public static string PostJson(string actionAddress, string serviceBaseAddress = null)
        {
            ExceptionDispatchInfo exDispatchInfo = null;
            string result = "";
            using (System.Net.WebClient client = new System.Net.WebClient())
            {
                if (!string.IsNullOrEmpty(serviceBaseAddress))
                    client.BaseAddress = serviceBaseAddress;

                //   client.Headers[System.Net.HttpRequestHeader.ContentType] = "application/json";

                Monitor.Enter(_monitorObject);

                try
                {
                    byte[] response = client.UploadValues(actionAddress, "POST", new System.Collections.Specialized.NameValueCollection());

                    result = System.Text.Encoding.UTF8.GetString(response);
                }
                catch (Exception ex)
                {
                    exDispatchInfo = ExceptionDispatchInfo.Capture(ex);
                }
                finally
                {
                    Monitor.Exit(_monitorObject);
                }

                if (exDispatchInfo != null)
                    exDispatchInfo.Throw();
            }
            return result;
        }
        public static string PostRequest(string address, object postData)
        {
            bool result = false;
            string error = "";
            string responseFromServer = "";
            StreamReader reader = null;
            Stream dataStream = null;
            WebResponse response = null;
            WebRequest request = null;

            //  JavaScriptSerializer serializer = new JavaScriptSerializer();
            string data = Newtonsoft.Json.JsonConvert.SerializeObject(postData);

            request = WebRequest.Create(address);

            string resultStatus = string.Empty;
            //try
            //{
            request.Method = "POST";
            request.Timeout = 120000;
            byte[] byteArray = Encoding.UTF8.GetBytes(data);

            request.ContentType = "application/json";
            request.ContentLength = byteArray.Length;
            dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();


            response = request.GetResponse();
            dataStream = response.GetResponseStream();
            reader = new StreamReader(dataStream);
            responseFromServer = reader.ReadToEnd();

            reader.Close();
            dataStream.Close();
            response.Close();

            result = true;
            //}
            //catch (WebException e)
            //{
            //    //return "error in operation!! TIME OUT";
            //    error = e.Message;
            //    throw new Exception(e.Message);
            //}

            return responseFromServer;
        }

        public static void MainPost(string actionAddress, string serviceBaseAddress = null)
        {
            // Create a request for the URL. 
            WebRequest request = WebRequest.Create(
              actionAddress);
            // If required by the server, set the credentials.
            request.Credentials = CredentialCache.DefaultCredentials;
            // Get the response.
            WebResponse response = request.GetResponse();
            // Display the status.
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Display the content.
            Console.WriteLine(responseFromServer);
            // Clean up the streams and the response.
            reader.Close();
            response.Close();
        }
    }
}
