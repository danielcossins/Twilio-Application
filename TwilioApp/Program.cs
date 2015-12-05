using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;

namespace TwilioApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find your Account Sid and Auth Token at twilio.com/user/account 
            string AccountSid = "AC85f12f79e35f3ea3f1fb985df2ee99a9";
            string AuthToken = "ef3e7e352e393b144f8b74a2ed6c24af";
            var twilio = new TwilioRestClient(AccountSid, AuthToken);

            //var message = twilio.SendMessage("+18017841260", "9132169521", "asdfsadfasdf", "");
            //Console.WriteLine(message.Sid);
            Console.WriteLine("Welcome to the text Daniel Application!");
            Console.WriteLine("Enter [exit] at anytime to end the program.");
            string prompt = "--> ";
            Console.Write(prompt);
            string input = Console.ReadLine();
            while (true)
            {
                if (input != "exit")
                {
                    var message = twilio.SendMessage("+18017841260", "9132169521", input, "");
                    //Console.WriteLine(message.Sid);
                    Console.WriteLine("Enter another message");
                    Console.Write(prompt);
                    input = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
        }
    }
}
