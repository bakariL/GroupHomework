using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwww
{
   public class Person
    {
        //fiedlds
        private string eyecolor; 
        
        //properties

            public string EyeColor { get; set; }

        //constructor
        public Person()
        {
            //default
        }
        public Person(string eyeColor)
        {
            this.EyeColor = eyeColor; 
        }
        //method

        public virtual string UserEyeColor()
        {
            //method that takes in eye color from user
            Console.WriteLine("What is your eye color?");
            Console.WriteLine("\n");
            Console.WriteLine("1. blue");
            Console.WriteLine("2. green");
            Console.WriteLine("3. brown");
            int choice = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (choice)
            {
                case 1:
                    this.EyeColor = "blue";
                    break;
                case 2:
                    this.EyeColor = "green";
                    break;
                case 3:
                    this.EyeColor = "brown";
                    break;
                default:
                    this.EyeColor = "you need contact";
                    break;

            }
            Console.Clear();
            return EyeColor;

        }




    }
}
