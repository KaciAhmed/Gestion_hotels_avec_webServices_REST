using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Agence
{
    public enum httpVerbs
    {
        GET,
        POST,
        PUT,
        DELETE
    }
    class ClientRest
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
    }
}
