using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace RestaurantAppDesktop
{
    static class RequestHelper
    {
        public static string MakeGetRequest(string url)
        {
            string stringResponse = string.Empty;
           
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception(response.StatusCode.ToString());
                }

                using (Stream responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            stringResponse = reader.ReadToEnd();
                        }
                    }
                }
            }

            return stringResponse;
        }

        public static void MakePostRequest(string url, object obj)
        {
            ASCIIEncoding encoding = new ASCIIEncoding();

            string postData = JsonConvert.SerializeObject(obj);

            byte[] data = encoding.GetBytes(postData);

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "POST";
                request.ContentType = "application/json";
                request.ContentLength = data.Length;

                Stream stream = request.GetRequestStream();
                stream.Write(data, 0, data.Length);
                stream.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception: {ex.Message}");
            }
        }

        public static void MakeDeleteRequest(string url, int id)
        {
            string deleteUrl = url + "/" + id;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(deleteUrl);
            request.Method = "DELETE";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        }

        public static void MakePutRequest(string url, object obj)
        {
            ASCIIEncoding encoding = new ASCIIEncoding();

            string postData = JsonConvert.SerializeObject(obj);

            byte[] data = encoding.GetBytes(postData);

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "PUT";
                request.ContentType = "application/json";
                request.ContentLength = data.Length;

                Stream stream = request.GetRequestStream();
                stream.Write(data, 0, data.Length);
                stream.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception: {ex.Message}");
            }
        }
    }
}
