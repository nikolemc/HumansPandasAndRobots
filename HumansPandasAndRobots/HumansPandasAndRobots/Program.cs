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
            ZiggyBot.DisplayType();

            var Terminator = new Robot("Terminator");
            Terminator.StartUp();
            Terminator.ShutDown();

            var BoBo = new Panda("BoBo");
            BoBo.Food = "Bamboo";
            BoBo.Eat();           

            var Nikole = new Human("Nikole");
            Nikole.Food = "Sticky Toffee Pudding";
            Nikole.Eat();
            Nikole.Height = "5.4";


            //create a list that contains humans, robots, and pandas
            var AllFriends = new List<MovingObject>
            {
                  Nikole, BoBo, ZiggyBot, Terminator
            };


            //Create a list that can hold humans and pandas in them
            var HumanPandaFriends = new List<Living>
            {
                  Nikole, BoBo
            };


        }




    }
}
