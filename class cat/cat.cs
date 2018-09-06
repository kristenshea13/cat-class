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

        public decimal AdoptPrice
        {
            
            
        get 
            {
            
            //if/else if/else statements to determine adoption fee of cat based on two variables
            if (FurLength == "Long" && Age <= 5)
                return 125;
            else if (FurLength == "Short" && Age <= 5)
                return 100;
            else if (FurLength == "Medium" && Age <= 5)
                return 75.25M;
            else
               return 55.50M;

            //return specified adoption fee
            
            }

        }

        //public int PointValue
        //{
        //    get
        //    {
        //        if (FaceValue == "Ace") return 11;
        //        else if (FaceValue == "King" || FaceValue == "Queen" || FaceValue == "Jack") return 10;
        //        else return int.Parse(FaceValue);
        //    }
        //}


    }
}
