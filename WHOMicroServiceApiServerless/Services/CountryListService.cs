using Newtonsoft.Json;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WHOMicroServiceApiServerless.Models;

namespace WHOMicroServiceApiServerless.Services
{
    public class CountryListService:ICountryListService
    {
        public async Task<IEnumerable<CountryModel>> GetAsyncCountryData() {
            List<CountryModel> model = null;
            var client = new HttpClient();
            var task = client.GetAsync("https://corona.lmao.ninja/countries?sort=country")
              .ContinueWith((taskwithresponse) =>
              {
                  var response = taskwithresponse.Result;
                  var jsonString = response.Content.ReadAsStringAsync();
                  jsonString.Wait();
                  model = JsonConvert.DeserializeObject<List<CountryModel>>(jsonString.Result);

              });
            await task;

            return model;
        }
    }
}
