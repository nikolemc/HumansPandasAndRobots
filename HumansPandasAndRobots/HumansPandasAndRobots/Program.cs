using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumansPandasAndRobots
{
    class Program
    {
        static void Main(string[] args)
        {
            var ZiggyBot = new Robot("ZiggyBot");
            ZiggyBot.StartUp();
            ZiggyBot.ShutDown();

            var Terminator = new Robot("Terminator");
            Terminator.StartUp();
            Terminator.ShutDown();

            var BoBo = new Panda("BoBo");
            BoBo.Food = "Bamboo";
            BoBo.Eat();           

            var Nikole = new Human("Nikole");
        }




    }
}
