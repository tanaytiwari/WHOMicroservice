using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WHOMicroServiceApiServerless.Models
{
    public class CountryModel
    {
        public string country { get; set; }
        public string cases { get; set; }
        public CountryInfo countryInfo { get; set; }
        public string todayCases { get; set; }
        public string deaths { get; set; }
        public string todayDeaths { get; set; }
        public string recovered { get; set; }
        public string active { get; set; }
        public string critical { get; set; }
        public string casesPerOneMillion { get; set; }
        public string deathsPerOneMillion { get; set; }
        public string updated { get; set; }
    }
    public class CountryInfo
    {
        public string _id { get; set; }
        public string iso2 { get; set; }
        public string iso3 { get; set; }
        public string lat { get; set; }

        public string flag { get; set; }

    }
}
