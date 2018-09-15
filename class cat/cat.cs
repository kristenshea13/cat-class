using System;
using System.Collections.Generic;
using System.Text;

namespace class_Cat
{
    public class Cat
    {
        public string FurColor { get; set; }
        public string BodySize { get; set; }
        public string FurLength { get; set; }
        public int Age { get; set; }


        //utilizing encapsulation in my class: kept the logic
        //behind how the property AdoptionPrice is determined as private, but
        //gave a public way to access what the logic behind the variable returns.
        public void AdoptPrice()
        {
            Console.WriteLine($"My cat's adoption fee was: {AdoptionPrice}");
        }

        private decimal AdoptionPrice
        {
             
        get 
            {
            
            //if/else if/else statements to determine adoption fee of cat based on two variables
            if (FurLength == "LONG" && Age <= 5)
                return 125;
            else if (FurLength == "SHORT" && Age <= 5)
                return 100;
            else if (FurLength == "MEDIUM" && Age <= 5)
                return 75.25M;
            else
               return 55.50M;

            //return specified adoption fee
            
            }
            

        }

        

    }
}
