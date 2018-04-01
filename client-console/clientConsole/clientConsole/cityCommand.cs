using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clientConsole
{
    class cityCommand
    {

        private CitySelecter citySelecter = new CitySelecter();

        public Object run()
        {
            citySelecter.DisplayCities();
            return citySelecter.SelectCity();
        }

    }
}
