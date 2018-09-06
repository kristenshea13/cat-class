using System;

namespace class_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new cat from Cat class
            Cat myCat = new Cat();
            {
                myCat.FurColor = "Black";
                myCat.BodySize = "Medium";
                myCat.FurLength = "Short";
                myCat.Age = 4;
            };
            
            //print properties to console in descriptive sentence.
            Console.WriteLine($"My cat is a {myCat.BodySize}-sized cat, with {myCat.FurColor}-colored fur. " +
                $"My cat's fur is {myCat.FurLength}. My cat is {myCat.Age} years old.");

            //format return from method below as currency

            
            string adoptionfee = $"{myCat.AdoptPrice:C}";
            
            //print adoption fee as currency to console
            Console.WriteLine("I adopted him for {0}", adoptionfee);




            Console.ReadLine();
        }
      



    }
    

}
