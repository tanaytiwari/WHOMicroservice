using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WHOMicroServiceApiServerless.Models;
using WHOMicroServiceApiServerless.Services;

namespace WHOMicroServiceApiServerless.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {

        private ICountryListService countryListService ;

        public CountriesController(ICountryListService countryListService)
        {
            this.countryListService = countryListService;
        }


        [HttpGet]
        [EnableCors("Cors")]
        public IEnumerable<CountryModel> GetCountries()
        {
            return  countryListService.GetAsyncCountryData().Result;
     
        }

}
}