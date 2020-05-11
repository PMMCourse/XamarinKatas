using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace XamarinFormsKatas.Katas_Logic.Kata_LB
{
    public class LB
    {
        public List<User> Posts { get; set; }
        public async void A()
        {
            var resultFromAPI = await new HttpClient().GetStringAsync("https://jsonplaceholder.typicode.com/posts");
            Posts = JsonConvert.DeserializeObject<List<User>>(resultFromAPI);
        }
    }
}
