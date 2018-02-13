using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwww
{
    class Program
    {
        static void Main(string[] args)
        {
            Person personTravling = new Person();
            Travel travelPlace = new Travel();
            string userInput;
            do
            {
                Console.WriteLine("type 'exit' to quit at any time");
                Console.WriteLine("PUSH ENTER to begin");
                userInput =Console.ReadLine();
                string s = personTravling.UserEyeColor();
                travelPlace.TravelPlace(s);

            } while (userInput != "exit");
            
        }
    }
}
