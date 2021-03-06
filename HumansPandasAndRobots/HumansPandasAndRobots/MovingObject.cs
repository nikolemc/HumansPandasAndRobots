﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumansPandasAndRobots
{
    abstract class MovingObject
    {
        public string Name { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string MovingObjectType { get; set; }


        //Add a new Method on the Parent Class called "DisplayType()". 
        //This should display the type of the current object (hint: use reflection)
        public void DisplayType()
        {
            Console.WriteLine(GetType().Name);
                
        }
        
       
    }
}
