using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using WHOMicroservice.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Cors;
using WHOMicroservice.Services;

namespace WHOMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class CountriesController : ControllerBase
    {
        private readonly ICountryService _countryService;

        public  CountriesController() {
            _countryService = new CountryService();
        }

        // GET: api/Countries
        [HttpGet]
        [EnableCors("Cors")]
        public async Task<IActionResult> GetCountries()
        {
            var result = await _countryService.GetAllCountriesData();
            if (result != null) {
                return Ok(result);
            }
            else
            {
                return BadRequest("Internal Server Error");
            }
        }
       
    }
}
