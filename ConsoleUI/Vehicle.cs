using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string Make { get; set; } = "Default Make";

        public string Model { get; set; } = "Default Model";

        public string Year { get; set; } = "2019";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual() 
        {
            Console.WriteLine("My virital method for vehicle class...");
        
        
        }
     
      
      





    }
}
