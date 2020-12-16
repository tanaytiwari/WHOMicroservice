using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WHOMicroservice.Models;

namespace WHOMicroservice.Services
{
    public interface ICountryService
    {
        public  Task<IEnumerable<CountryModel>> GetAllCountriesData();
    }
        
}
