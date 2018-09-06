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
            string adoptionfee = $"{AdoptPrice(myCat.FurLength, myCat.Age):C}";
            
            //print adoption fee as currency to console
            Console.WriteLine("I adopted him for {0}", adoptionfee);




            Console.ReadLine();
        }
        private static decimal AdoptPrice(string FurLength, int Age)
        {
            //declare fee as decimal type
            decimal fee;

            //if/else if/else statements to determine adoption fee of cat based on two variables
            if (FurLength == "Long" && Age <= 5)
                fee = 125;
            else if (FurLength == "Short" && Age <= 5)
                fee = 100;
            else if (FurLength == "Medium" && Age <= 5)
                fee = 75.25M;
            else
                fee = 55.50M;

            //return specified adoption fee
            return fee;

        }



    }
    

}
