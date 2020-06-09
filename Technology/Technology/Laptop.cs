using System;
using System.Collections.Generic;
using System.Text;


namespace Technology
{
   public class Laptop  : Computer
    {
        

        public string Brand { get; }
        public int BatteryLifeinHours { get; set; }

        private int ID { get; set; }
        public Laptop()
        {
            Brand = "Dell";
        }
        public void Upgrade()
        {
            if (Brand != "Mac")
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
