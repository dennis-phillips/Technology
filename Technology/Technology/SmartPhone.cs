using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class SmartPhone : Computer
    {
       

        public string Brand { get; set; }
        public string Model { get; set; }
        private static string Carrier { get; set; }

        private int ID { get; set; }

        public SmartPhone(string brand)
        {
            Brand = brand;
        }
        public void Replace()
        {
            if (Brand != "Mac" || Model != "Iphone")
            {
                Console.WriteLine("Congratulations on not drinking the Koolaid!");
            }
            else
            {
                Console.WriteLine("Koolaid Drinker!");
            }
        }

    }
}
