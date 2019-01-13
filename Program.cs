using System;
using Messages;
using Tools;

namespace ConBox
{
    class Program
    {
        static void Main(string[] args)
        {
            var message = new Message();
            message.Welcome();

            var tools = new ToolBox();
            ToolBox ex = tools;

            var choice = new Choices();
            choice.Decision(tools);

            message.Goodbye();
        }




    }
}
