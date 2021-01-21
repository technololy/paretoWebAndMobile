using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace ParetoWebAppBlazor.Services
{
    public class APIService
    {
        static string ipAcctOpen;
        private static HttpClient client = new HttpClient();



        public APIService()
        {
            ipAcctOpen = Settings.AppSettings.ParetoBaseURL;
            client = new HttpClient();
            //client.DefaultRequestHeaders.Add("ApiKey", Settings.AppSettings.CamsAccountOpeningKey);
            try
            {
                var guid = Guid.NewGuid().ToString("N");

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            client.MaxResponseContentBufferSize = 2147483647;

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue
                                                    ("application/json"));

        }
        public async Task<(bool isSuccess, T model)> Post<T>(object model, string endPoint, CancellationTokenSource cancellation = null, string contentType = "application/json", bool useParamaterBaseUrl = false)
        {
            try
            {
                string json = string.Empty;
                string url = "";




                url = $"{endPoint}";

                //if (client==null)
                //{
                //    client = new HttpClient();
                //}
                json = JsonConvert.SerializeObject(model);
                System.Diagnostics.Debug.WriteLine(json);
                var stringContent = new StringContent(json, Encoding.UTF8, contentType);


                if (cancellation == null)
                    cancellation = new CancellationTokenSource(Settings.AppSettings.MaximumConnection);
                var response = await client.PostAsync(url, stringContent);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    Debug.WriteLine("success>>>>>>>>>>>" + content);
                    return (true, JsonConvert.DeserializeObject<T>(content));
                }
                else
                {
                    var content = await response.Content.ReadAsStringAsync();
                    Debug.WriteLine("failure>>>>>>>>>>>" + content + response.StatusCode.ToString());

                    return (false, JsonConvert.DeserializeObject<T>(content));
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return default;
            }

        }






        internal async Task<T> Get<T>(string method, bool cacheData = false, int cacheDurationHours = 24, bool forceRefresh = false, CancellationTokenSource cancellation = null, string contentType = "application/json", bool useParamaterBaseUrl = false)
        {


            try
            {
                string url;

                if ((useParamaterBaseUrl)) url = method;


                else
                    url = Settings.AppSettings.ParetoBaseURL + method;


                var json = string.Empty;
                T deserialize = default(T);


                if (string.IsNullOrWhiteSpace(json))
                {
                    HttpResponseMessage res = new HttpResponseMessage();


                    res = await client.GetAsync(url).ConfigureAwait(false);
                    json = await res.Content.ReadAsStringAsync();
                    System.Diagnostics.Debug.WriteLine(json);



                    deserialize = JsonConvert.DeserializeObject<T>(json);
                }
                else
                {
                    deserialize = JsonConvert.DeserializeObject<T>(json);
                }

                return deserialize;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return default;


            }

        }


    }
}
