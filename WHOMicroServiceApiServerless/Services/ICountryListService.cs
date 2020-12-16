using System.Collections.Generic;
using System.Threading.Tasks;
using WHOMicroServiceApiServerless.Models;

namespace WHOMicroServiceApiServerless.Services
{
    public interface ICountryListService
    {
        public  Task<IEnumerable<CountryModel>> GetAsyncCountryData();
    }
}