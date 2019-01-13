using System;
using System.Collections.Generic;
using System.Text;

namespace Tools
{
    class ToolBox
    {
        public string Name
        { get; set; }
       
        public void Add()
        {
            Console.Write("Enter Tool Name: ");
            Name = Console.ReadLine();
            Console.WriteLine($"You just added {Name}");
        }


        
    }
}
