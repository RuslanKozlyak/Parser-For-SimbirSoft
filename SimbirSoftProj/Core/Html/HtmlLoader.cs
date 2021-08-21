using SimbirSoftProj.Core.Log;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace SimbirSoftProj.Core
{
    public class HtmlLoader
    {
        HttpClient client;
        string url;

        public HtmlLoader(IParserSettings settings)
        {
            client = new HttpClient();
            url = settings.BaseUrl;
        }
        public async Task<string> GetSource()
        {
            string source = null;
            try
            {
                var response = await client.GetAsync(url);

                if (response != null && response.StatusCode == HttpStatusCode.OK)
                {
                    source = await response.Content.ReadAsStringAsync();
                    Logger.WriteLog($"Parser was connected to {url}. StatusCode = {response.StatusCode}");
                }
                else
                {
                    Logger.WriteLog($"Parser wasn't connected to {url}. StatusCode = {response.StatusCode}");
                }

            }
            catch (Exception ex)
            {
                Logger.WriteLog($"Parser wasn't connected to {url}. [{ex.Message}]");
            }

            return source;
        }
    }
}
