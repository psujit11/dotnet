using System.Collections.Generic;
using System.Linq;


namespace LearnCollection
{

    public class Collection
    {
        void LearnLists()
        {
            List<byte> ages = new List<byte>();
            // can be intialized as List<byte> ages = new List <byte> {1,20,255};
            ages.Add(1);
            ages.Add(10);
            ages.Add(255);
            ages.Add(100);

            List<Country> countries = new List<Country>();
            countries.Add(new Country());
        }

         internal void LearnDictionary()
        {
            Dictionary<string,string> countryCapitals = new Dictionary<string,string>()    
            {
                ["Nepal"] = "Kathmandu",
                ["India"] = "Delhi",
                ["China"] = "Beijing"
            };
            /*  even agadi ko dictionary part ko satta var mtra use garna nih milxa as new Dictioanry ley define garxa dictioanry bhanera.
            mathi ko way pialai thaha huda mtra ho yedi thaxaian bhane tala ko jasto use gareney
             Dictionary<string,string> countryCapitals = new Dictionary<string,string>();
            // countryCapitals.Add("Nepal","Kathmandu");
            // countryCapitals.Add("Inida","Delhi");
            // countryCapitals.Add("China","Beingin");*/
            foreach (var country in countryCapitals)
            {
                Console.WriteLine($"Country : {country.Key} Capital city {country.Value}");
            }
        }
    }

    public class Country
    {
        public string Name { get; set;}
    }
        
}