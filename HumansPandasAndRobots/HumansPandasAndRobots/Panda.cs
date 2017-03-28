using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumansPandasAndRobots
{
    class Panda
    {
        public string Name { get; set; }

        public void DisplayName()
        {
            Console.WriteLine($"Hello, my name is : {this.Name}");
        }

        public void DisplayGreeting()
        {
            Console.WriteLine($"I am a: {Panda}");
        }
    }

}
