using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web;

/// <summary>
/// Descrição resumida de JsonHelper
/// </summary>
public static class JSONHelper
{
    public static string GetJSONString(string url)
    {
        HttpWebRequest request =
            (HttpWebRequest)WebRequest.Create(url);
        WebResponse response = request.GetResponse();

        using (Stream stream = response.GetResponseStream())
        {
            StreamReader reader = new StreamReader(
                stream, Encoding.UTF8);
            return reader.ReadToEnd();
        }
    }
}