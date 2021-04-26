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

        internal string makeRequestPostReservation(string baseAddress, string endpointAddress)
        {
            var request = (HttpWebRequest)WebRequest.Create(baseAddress + endpointAddress);

            request.Method = "GET";
            request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;

            var content = string.Empty;
            using (var response = (HttpWebResponse)request.GetResponse())
            {
                using (var stream = response.GetResponseStream())
                {
                    using (var sr = new StreamReader(stream))
                    {
                        content = sr.ReadToEnd();
                    }
                }
            }

            String resultat = content.ToString();
            return resultat;
        }
    }
}
