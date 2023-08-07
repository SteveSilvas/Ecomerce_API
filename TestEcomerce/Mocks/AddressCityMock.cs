using Ecomerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEcomerce.Mocks
{
    public static class AddressCityMock
    {
        static readonly List<AddressCity> _cities = new List<AddressCity>();
        static AddressCityMock()
        {
            BuildCitites();
        }
        private static void BuildCitites()
        {
            string[] citiesNames = { "Cotia", "Itapevi", "Jandira", "Barueri", "Osasco" };
            for (int i = 0; i < citiesNames.Length; i++)
            {
                _cities.Add(new AddressCity(i + 1, citiesNames[i]));
            }
        }
        public static IEnumerable<AddressCity> GetCities()
        {
            return _cities;
        }

        public static AddressCity GetCity(int id)
        {
            return _cities.Find(c => c.Id.Equals(id));
        }
    }
}
