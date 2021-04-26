using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;

namespace Agence
{
    public enum httpVerbs
    {
        GET,
        POST,
        PUT,
        DELETE
    }

    internal class ClientRest
    {

        public httpVerbs HttpMethod { get; set; }

        public ClientRest()
        {

        }
        public string makeRequestGET(string EndPointReq)
        {
            HttpMethod = httpVerbs.GET;
            string strResponseValue = string.Empty;

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(EndPointReq);
            req.Method = HttpMethod.ToString();

            using (HttpWebResponse rep = (HttpWebResponse)req.GetResponse())
            {
                if (rep.StatusCode != HttpStatusCode.OK)
                {
                    throw new ApplicationException("error code : " + rep.StatusCode);
                }
                using (Stream responseStream = rep.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            strResponseValue = reader.ReadToEnd();
                        }
                    }
                }
            }

            return strResponseValue;
        }
        public ICollection<Offre> makeRequestGetOffres(string baseAddress, string endpointAddress)
        {

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync(endpointAddress);
                responseTask.Wait();

                var result = responseTask.Result;

                if (result.IsSuccessStatusCode)
                {

                    var readTask = result.Content.ReadAsAsync<Offre[]>();
                    readTask.Wait();

                    var offres = readTask.Result;

                    foreach (var offre in offres)
                    {
                        Console.WriteLine(offre);
                    }
                    return offres;
                }
                else
                {
                    throw new ApplicationException("error code : " + result.StatusCode);
                }
            }

        }
    }
}
