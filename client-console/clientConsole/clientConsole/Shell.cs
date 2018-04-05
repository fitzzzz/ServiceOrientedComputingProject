using clientConsole.VelibService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clientConsole
{
    class Shell
    {

        private CommandInterpreter interpreter;
        private VelibServiceClient client;

        public Shell(VelibServiceClient client)
        {
            this.client = client;
            this.interpreter =  new CommandInterpreter(client);
        }

        private void PrintPrompt()
        {
            Console.Write("VelibClient > ");
        }

        private void PrintCommandAvailable()
        {
            Console.WriteLine("Liste de commandes disponnibles : ");
            Console.WriteLine("\tcity : selection d'une ville");
            Console.WriteLine("\tstation : selection d'une station et affichage de ses informations");
            Console.WriteLine("\texit : quitter le programme");
        }

        public void Run()
        {
            string command = null;

            PrintCommandAvailable();
            while (command != "exit")
            {
                PrintPrompt();
                command = Console.ReadLine();
                interpreter.run(command);
            }
        }

    }
}

