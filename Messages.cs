using System;

namespace Messages
{
    
    class Message
    {
        public void Welcome()
        {
            Console.WriteLine("Welomce To My Toolbox");
            Console.WriteLine("Here You Can Inventory Your Tools");
        }


        public void Goodbye()
        { 
                Console.WriteLine("Thank you for your Patience :)");
                Console.WriteLine("Goodbye!");
        }
    }
}