
 export   class CountryInfo
    {
          _id :string;
          iso2 :string;
          iso3 :string;
          lat :string;
          flag :string;
 
    }

export class CountryModel
    {
          country:string;
          cases :string;
          countryInfo : CountryInfo [];
          todayCases :string;
          deaths :string;
          todayDeaths :string;
          recovered :string;
          active :string;
          critical :string;
          casesPerOneMillion :string;
          deathsPerOneMillion :string;
          updated :string;
    }
    export class CountryModelWithid
    {
          id:string;
          countryObj:CountryModel;
          
    }
   