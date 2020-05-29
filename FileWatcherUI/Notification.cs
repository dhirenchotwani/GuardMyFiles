using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Web;

namespace FileWatcherUI
{
    class Notification
    {
        public Notification()
        {
            Console.WriteLine("Bas aise hi daala");
        }

        public void SendMessage(string number, string msg)
        {
            string authKey = "YOUR AUTH KEY HERE!";

            string message = HttpUtility.UrlEncode(msg);

            //Prepare you post parameters
            StringBuilder sbPostData = new StringBuilder();
            sbPostData.AppendFormat("authkey={0}", authKey);
            sbPostData.AppendFormat("&mobiles={0}", number);
            sbPostData.AppendFormat("&message={0}", message);


            try
            {
                //Call Send SMS API
                string sendSMSUri = "http://api.msg91.com/api/sendhttp.php?country=91&sender=MSGIND&route=4";
                //Create HTTPWebrequest
                HttpWebRequest httpWReq = (HttpWebRequest)WebRequest.Create(sendSMSUri);
                //Prepare and Add URL Encoded data
                UTF8Encoding encoding = new UTF8Encoding();
                byte[] data = encoding.GetBytes(sbPostData.ToString());
                //Specify post method
                httpWReq.Method = "POST";
                httpWReq.ContentType = "application/x-www-form-urlencoded";
                httpWReq.ContentLength = data.Length;
                using (Stream stream = httpWReq.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }
                //Get the response
                HttpWebResponse response = (HttpWebResponse)httpWReq.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string responseString = reader.ReadToEnd();
                Console.WriteLine($"Response is {responseString}");
                //Close the response
                reader.Close();
                response.Close();
            }
            catch (SystemException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
    }
}
