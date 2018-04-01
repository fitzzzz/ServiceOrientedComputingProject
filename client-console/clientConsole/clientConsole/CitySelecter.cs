using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clientConsole
{
    class CitySelecter
    {
        private List<String> cities = new List<string>();

        public CitySelecter()
        {   
            cities.Add("Amiens");
            cities.Add("Besancon");
            cities.Add("Cergy-Pontoise");
            cities.Add("Cretail");
            cities.Add("Lyon");
            cities.Add("Marseille");
            cities.Add("Mulhouse");
            cities.Add("Nancy");
            cities.Add("Nantes");
        }

        public void DisplayCities()
        {
            Console.WriteLine("Voicie les différentes villes disponnibles");
            foreach (String city in cities)
            {
                Console.WriteLine(city);
            }
        }

        public string SelectCity()
        {
            String choice = null;

            while (choice == null || !cities.Contains(choice))
            {
                Console.Write("Veuillez choisir une ville : ");
                choice = Console.ReadLine();
            }
            return choice;
        }

    }
}
