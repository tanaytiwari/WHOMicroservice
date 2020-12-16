using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;
using WHOMicroservice.Models;
using WHOMicroservice.Services;

namespace WhoMicroserviceUITest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestServiceMethod()
        {
          //  var mockRepo = new Mock<ICountryService>();

          //  var ListCountriesData = new List<CountryModel>() { };
          //  CountryModel o1 = new CountryModel();
          //  o1.country = "India";
          //  o1.cases = "1";
          //  ListCountriesData.Add(o1);

          ////  mockRepo.Setup(p => p.GetAllCountriesData()).Returns(ListCountriesData);
           

        }

        [TestMethod]
         public void TestNewMethod()
        {
            string[] array1  = new string[] { "Forces", "Mango", "Apple","Flower" };
            string[] array2 = new string[] { "Force", "Mango", "Apple" };
            bool checkVal;
            foreach (var item in array1) {
              checkVal  = false;
                foreach (var inneritem in array2) {
                    checkVal = item == inneritem ? true : false;
                        if (checkVal) break;
                }
            }
        }
    }
}
