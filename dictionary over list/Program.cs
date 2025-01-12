using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
namespace Demo
{
    public class Program
    {
        public static void Main()
        {
            Country country1 = new Country()
            {
                Code = "AUS",
                Name = "AUSTRALIA",
                Capital = "Canberra"
            };
            Country country2 = new Country()
            {
                Code = "IND",
                Name = "INDIA",
                Capital = "New Delhi"
            };
            Country country3 = new Country()
            {
                Code = "USA",
                Name = "UNITED STATES",
                Capital = "Washington D.C"
            };
            Country country4 = new Country()
            {
                Code = "GBR",
                Name = "UNITED KINGDOM",
                Capital = "London"
            };
            Country country5 = new Country()
            {
                Code = "CAN",
                Name = "CANADA",
                Capital = "Ottawa"
            };
            Dictionary<String, Country>DictionaryCountries = new Dictionary<string, Country>();
            DictionaryCountries.Add(country1.Code,country1);
            DictionaryCountries.Add(country2.Code,
                
                
                country2);
            DictionaryCountries.Add(country3.Code, country3);
            DictionaryCountries.Add(country4.Code, country4);
            DictionaryCountries.Add(country5.Code, country5);
            Console.WriteLine("Enter country code");
            string Countrycode = Console.ReadLine().ToUpper();
            Country resultcountry = DictionaryCountries.ContainsKey(Countrycode) ? DictionaryCountries[Countrycode]: null;
            if (resultcountry == null)
            {
                Console.WriteLine("invalid");
            }
            else
            {
                Console.WriteLine("Name ={0}, Capital={1}", resultcountry.Name, resultcountry.Capital);
            }
        }
    }


    public class Country
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public  string Capital { get; set; }
    }
}

