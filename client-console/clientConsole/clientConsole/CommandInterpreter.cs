using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clientConsole
{
    class CommandInterpreter
    {

        private cityCommand    cityCommand    = new cityCommand();
        private StationCommand stationCommand = new StationCommand();
        private String         currentCity    = "Lyon";

        private string getFirstWord(string command)
        {
            int indexOfFirstSpace = command.IndexOf(' ');

            return (indexOfFirstSpace == -1) ? command : command.Substring(indexOfFirstSpace);
        }

        public void run(string command)
        {

            string firstWord = getFirstWord(command);
            switch (firstWord)
            {
                case "city":
                    currentCity = (String) cityCommand.run();
                    break;
                case "station":
                    stationCommand.run(currentCity);
                    break;
                case "exit":
                    Console.WriteLine("Bye bye");
                    break;
                default:
                    Console.WriteLine("Commande inexistante");
                    break;
            }
        }
    }
}
