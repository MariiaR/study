using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TeaMysteryBot
{
    public class Program
    {
        private const string c_prefix = @"https://api.telegram.org/bot231400223:AAG1ygDP63lohqrywx8BYRFwYuwYmh32Dv0/";

        public static void Main(string[] args)
        {
            WebClient client = new WebClient();
            long lastUpdateId = 0;

            while (true)
            {
                string result = client.DownloadString(string.Format("{0}{1}?offset={2}", c_prefix, "getUpdates", lastUpdateId));
                JObject jResult = JObject.Parse(result);

                if (jResult["ok"].Value<bool>())
                {
                    long maxUpdateId = 0;
                    foreach(JObject jUpdate in jResult["result"])
                    {
                        Console.WriteLine(jUpdate);
                        maxUpdateId = Math.Max(maxUpdateId, jUpdate["update_id"].Value<long>());

                        long chatId = jUpdate["message"]["chat"]["id"].Value<long>();
                        client.DownloadString(string.Format("{0}{1}?chat_id={2}&text={3}", c_prefix, "sendMessage", chatId, "Hello"));
                    }
                    lastUpdateId = Math.Max(lastUpdateId, maxUpdateId + 1);
                }
                
                Thread.Sleep(5000);
            }

            client.Dispose();
        }
    }
}
