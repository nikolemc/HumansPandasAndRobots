﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumansPandasAndRobots
{
    class Human : MovingObject, Eatingcs, Living
    {
        //classes should have a "DisplayName()" and a "DisplayGreeting()" method. 
        //The "DisplayName()" function should return the value held in the property "Name".
        //public string Name { get; set; }
        public bool IsASleep { get; set; }
        public string Food { get; set; }
        public bool Living { get; set; }

        public Human(string name)
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
            Console.WriteLine("I am a Human");
        }
        public void GoToSleep()
        {
            IsASleep = true;
            Console.WriteLine("Time for Bed, Cheerio");
        }

        public void WakeUp()
        {
            IsASleep = false;
            Console.WriteLine("Hello, I am awake");
        }

        public void Eat()
        {
            Console.WriteLine($"I love to eat {this.Food}");
        }

        public void Alive()
        {
            Living = true;
            Console.WriteLine($"I am alive");
        }
    }
}
