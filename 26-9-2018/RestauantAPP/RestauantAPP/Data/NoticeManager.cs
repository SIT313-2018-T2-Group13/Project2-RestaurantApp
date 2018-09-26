using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using RestauantAPP.Model;
using Newtonsoft.Json;

namespace RestauantAPP.Data
{
    public class NoticeManager
    {
        HttpClient client = new HttpClient();
        List<Notice> ConferenceSessions = null;
        public async Task<List<Notice>> FetchSessionsAsync()

        {
            string url = "http://10.140.42.175:8080/api/conferencesessions/";
            try
            {

                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    ConferenceSessions = JsonConvert.DeserializeObject<List<Notice>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"       ERROR{0}", ex.Message);
            }
            return ConferenceSessions;
        }
    }
}
