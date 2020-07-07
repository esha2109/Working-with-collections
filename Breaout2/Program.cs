using System;
using System.Collections.Generic;

namespace Breaout2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, City> capital = new Dictionary<string, City>();

            HashSet<string> myHashSetA;

            capital.Add("Toronto", new City(200000, "ONTARIO"));
            capital.Add("Montreal", new City(200000, "Quebec"));
            capital.Add("Winnipeg", new City(200000, "Manitoba"));
            capital.Add("Halifax", new City(200000, "Novascotia"));
            capital.Add("Victoria", new City(200000, "BC"));

            foreach (KeyValuePair<string, City> kv in capital)
            {
                Console.WriteLine("{0} is a city in {1}", kv.Key, kv.Value.Provience);
            }

            HashSet<string> TopCities = new HashSet<string>();
            TopCities.Add("NewYork");
            TopCities.Add("Toronto");
            TopCities.Add("bOSTON");
            
            myHashSetA = new HashSet<string>(capital.Keys);
            myHashSetA.IntersectWith(TopCities);
            foreach (string s in myHashSetA)
            {
                Console.WriteLine("{0} is in Canada and also in the top 10 largest cities in North America.", s);
            }
        }
    }

    class City
    {
        public City( int population, string provience)
        {
            this.Population = population;
            this.Provience = provience;
        }
        public int Population { get; set; }
        public string Provience { get; set; }
    }
}
