using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace BbVpnApi
{
    public class BbVpn
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl = "https://bbvpn.avdev.site";
        public BbVpn()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("Dalvik/2.1.0 (Linux; U; Android 9; RMX3551 Build/PQ3A.190705.003)");
            httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<string> GetServers(string token)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/api.php?token={token}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetApiParameters(string token)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/apiParams.php?token={token}&v=v38");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}
