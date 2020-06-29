using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;


namespace BE
{
    class Request
    {
        public static string Get(string site)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            // Create a request for the URL.
            WebRequest request = WebRequest.Create(site);
            // If required by the server, set the credentials.
            request.Method = "GET";
            //request.UserAgent = "RequisiçãoWebDemo";
            request.Credentials = CredentialCache.DefaultCredentials;

            // Get the response.
            WebResponse response = request.GetResponse();
            // Display the status.
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);

            // Get the stream containing content returned by the server.
            // The using block ensures the stream is automatically closed.
            string responseFromServer = "";
            using (Stream dataStream = response.GetResponseStream())
            {
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                responseFromServer = reader.ReadToEnd();
                // Display the content.

            }

            // Close the response.
            response.Close();

            return responseFromServer;
        }
    }
}

