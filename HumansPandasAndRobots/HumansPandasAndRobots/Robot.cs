using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumansPandasAndRobots
{
    class Robot
    {

        //classes should have a "DisplayName()" and a "DisplayGreeting()" method. 
        //The "DisplayName()" function should return the value held in the property "Name".
        public string Name { get; set; }
        

        public Robot(string name)
        {
            this.Name = name;
            this.DisplayName();
            this.DisplayGreeting();
        }

        public void DisplayName()
        {
            Console.WriteLine($"Hello, my name is: {this.Name}");
        }

        public void DisplayGreeting()
        {
            Console.WriteLine("I am a Robot");
        }

        //Robots should have a "StartUp()" and "ShutDown()" method.
        //They should output to the console "Started..." and "Shutdown..." respectively.

        public void StartUp()
        {
            Console.WriteLine("1,2,3 Robot has Started!");
        }

        public void ShutDown()
        {
            Console.WriteLine("Bye, Robot is shutting down in 3,2,1");
        }

        //A Robot should have a method called 'IsTerminator()' which returns if that robot is a terminator
        public bool IsTerminator()
        {
            return (this.Name == "Terminator"); //this checks if the name is "Terminator" if it is, this rule is true.
           
        }
    }

}
