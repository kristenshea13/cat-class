﻿using System;

namespace class_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new cat from Cat class

            Console.Write("What is your cat's fur color? ");
            string catFur = Console.ReadLine().ToUpper();
            Console.Write("Is your cat small, medium, or large sized? ");
            string catSize = Console.ReadLine().ToUpper();
            Console.Write("What is the length of your cat's fur? Is it short, medium, or long? ");
            string catfurLength = Console.ReadLine().ToUpper();
            Console.Write("How old (in years) is your cat? ");
            int catAge = int.Parse(Console.ReadLine());

            Cat myCat = new Cat();
            {
                myCat.FurColor = catFur;
                myCat.BodySize = catSize;
                myCat.FurLength = catfurLength;
                myCat.Age = catAge;
            };


            
        
            
            
            

            //format return from method as currency

            
            string adoptionfee = $"{myCat.AdoptPrice:C}";
            
            //print adoption fee as currency to console
            Console.WriteLine("I adopted him for {0}", adoptionfee);




            Console.ReadLine();
        }
      



    }
    

}
