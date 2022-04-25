using System;


// -------------------------------------------------------------------------
// if using .NET Framework
// https://docs.microsoft.com/en-us/dotnet/api/system.web.script.serialization.javascriptserializer?view=netframework-4.8
// This requires including the reference to System.Web.Extensions in your project
using System.Web.Script.Serialization;
// -------------------------------------------------------------------------
// if using .Net Core
// https://docs.microsoft.com/en-us/dotnet/api/system.text.json?view=net-5.0
using System.Net;
using Newtonsoft.Json;
// -------------------------------------------------------------------------

namespace MiniProjekatHCI.Podaci
{
    public class APIData
    {
        public DataClass1 generateData(string dataType)
        {
            string QUERY_URL;
            switch (dataType)
            {
                case "Inflacija":
                    QUERY_URL = "https://www.alphavantage.co/query?function=CPI&interval=monthly&apikey=PFPTBJPSW5EO3D8A";
                    break;
                case "Zarada":
                    QUERY_URL = "https://www.alphavantage.co/query?function=INFLATION&apikey=PFPTBJPSW5EO3D8A";
                    break;
                default:
                    QUERY_URL = "https://www.alphavantage.co/query?function=RETAIL_SALES&apikey=PFPTBJPSW5EO3D8A";
                    break;
            }
            // replace the "demo" apikey below with your own key from https://www.alphavantage.co/support/#api-key     
            Uri queryUri = new Uri(QUERY_URL);

            using (WebClient client = new WebClient())
            {
                // -------------------------------------------------------------------------
                // if using .NET Framework (System.Web.Script.Serialization)

                JavaScriptSerializer js = new JavaScriptSerializer();
                Console.WriteLine(client.DownloadString(queryUri));
                DataClass1 json_data = (DataClass1)js.Deserialize(client.DownloadString(queryUri), typeof(DataClass1));
                Console.WriteLine(json_data.name);
                /*
                foreach (Value1 v1 in json_data.data) {
                    Console.WriteLine("fafafa");
                        }
                */
                return json_data;
                
            }
        }
    }
}
