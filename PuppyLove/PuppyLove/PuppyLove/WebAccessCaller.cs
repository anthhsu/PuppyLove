using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace PuppyLove
{
    class WebAccessCaller
    {
        public async Task<string> GetAsync()
        {
            using(var client = new HttpClient())
            {
                var result = await client.GetAsync("http://www.facebook.com/");
                return await result.Content.ReadAsStringAsync();
            }
        }
    }
}

