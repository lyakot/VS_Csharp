using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Writing
{
    internal class GET_currency
    {

        HttpWebRequest _request; 
        string _currency;

        public string Response { get; set; }


        public GET_currency(string currency)
        {
            _currency = currency;
        }

        public void Run()
        {
            _request = (HttpWebRequest)WebRequest.Create(_currency);
            _request.Method = "GET";

            try
            {
                HttpWebResponse response = (HttpWebResponse)_request.GetResponse();
                var stream = response.GetResponseStream();
                if (stream != null) Response = new StreamReader(stream).ReadToEnd();

            }

            catch (Exception)
            {

            }
            
        }

    } 
}
