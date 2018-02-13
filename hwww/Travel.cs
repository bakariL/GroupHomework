using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwww
{
    public class Travel : Person
    {

        //properties 
        public string Destination { get; set; }

        //constructors
        public Travel( )
        {
            this.Destination = Destination;
            //default
            
        }

        //methods
        public string TravelPlace(string eyecolor)
        {
            switch (eyecolor)
            {
                case "blue":
                    Destination = "Hawaii beach";
                    break;

                case "green":
                    Destination = "Laguna Beach";
                    break;

                case "brown":
                    Destination = "Siesta Key Beach";
                    break;
                default:
                    Destination = "Lake erie beach :( ";
                        break;
            }
            Console.WriteLine("Your beach is: " + Destination);
            return Destination;
        }
    }
}
