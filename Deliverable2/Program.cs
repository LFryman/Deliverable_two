using System;
using System.IO;
using System.Net.Http;
using System.Text;

namespace Deliverable2
{
    class Program
    {
    
        static void Main(string[] args)
        {
            //gets user input and store in var string input. 
            Console.Write("What is your message? ");
            string input = Console.ReadLine();

            string message = "";
            int checksum = 0;
            
            // accessing individual characters and prints 
            for (int i = 0; i < input.Length; i++)
            {
                int unicodeval = char.ToUpper(input[i]);
                int numPlacement = unicodeval - 64;

                //finding checksum through our table 
                checksum = checksum + unicodeval;

                message = message + numPlacement.ToString() + "-";

            }

            Console.WriteLine("Your encoded message is " + message);
            Console.WriteLine("Message checksum is " + checksum);
            

        }
    }
}