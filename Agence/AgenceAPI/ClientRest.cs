using System;
using System.Collections.Generic;
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
        public ICollection<OffreComparateur> makeRequestGetOffresComparateur(string baseAddress, string endpointAddress)
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

                    var readTask = result.Content.ReadAsAsync<OffreComparateur[]>();
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
