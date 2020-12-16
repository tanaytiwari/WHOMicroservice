using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WHOMicroservice.Models;

namespace WHOMicroservice.Services
{
    public class CountryService: ICountryService
    {
        public async Task<IEnumerable<CountryModel>> GetAllCountriesData()
        {
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
            task.Wait();
            return model;
        }

    }
}
