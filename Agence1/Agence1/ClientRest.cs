using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Agence1
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
        public string EndPointReq { get; set; }
        public httpVerbs HttpMethod { get; set; }

        public ClientRest()
        {
            EndPointReq = string.Empty;
            HttpMethod = httpVerbs.GET;
        }
        public string makeRequest()
        {
            string strResponseValue = string.Empty;

            HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create(EndPointReq);
            myReq.Method = HttpMethod.ToString();

            using (HttpWebResponse myRep = (HttpWebResponse)myReq.GetResponse())
            {
                if (myRep.StatusCode != HttpStatusCode.OK)
                {
                    throw new ApplicationException("error code : " + myRep.StatusCode);
                }
                using (Stream responseStream = myRep.GetResponseStream())
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
