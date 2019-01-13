using System;
using System.Collections.Generic;
using System.Text;
using Tools;


namespace ConBox
{
    class Choices
    {
        public int Pick
        { get; set; }

        public void Decision(ToolBox ex)
        {
            Console.WriteLine("Make a pick:\n1. Add\nPress any other key to exit...\n");
            Console.Write("Make your selection: ");
            try
            {
                Pick = int.Parse(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                return;
                
            } 
            if (Pick == 1)
            {
                ex.Add();
            }
            else
            {
                return;
            }
        }

    }
}
