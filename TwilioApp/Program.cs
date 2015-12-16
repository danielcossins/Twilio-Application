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
            string AccountSid = "AC5528716f7e3eb23a55f0b602dc41a47e";
            string AuthToken = "c42dd2fb8db6dcad7e429f7c4a04b5e6";
            var twilio = new TwilioRestClient(AccountSid, AuthToken);

            //var message = twilio.SendMessage("+18017841260", "9132169521", "asdfsadfasdf", "");
            //Console.WriteLine(message.Sid);
            Console.WriteLine("Welcome to the text Daniel Application!");
            Console.WriteLine("Enter the message for the text.");
            string prompt = "--> ";
            Console.Write(prompt);
            string input = Console.ReadLine();

            Console.WriteLine("Enter the number of times you want to send the text.");
            Console.Write(prompt);
            int number = int.Parse(Console.ReadLine());
            for (int i=0; i< number; i++)
            {
                var message = twilio.SendMessage("+19137035630", "9137082434", input, "");
                Console.WriteLine(i + 1 + " messages sent");
            }
            Console.WriteLine("Press any key to exit . . .");
            Console.ReadKey();
        }
    }
}
