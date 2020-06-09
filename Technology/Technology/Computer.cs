using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class Computer : AbstractEntity
    {
        public string OperatingSystem { get; set; }
        public string ConnectionType { get; set; }
        public int Ram { get; set; }
        public int StorageGB { get; set; }

        private int ID { get; set; }

        public Computer(string OperatingSystem, string ConnectionType, int Ram, int StorageGB)
        {
            this.OperatingSystem = OperatingSystem;
            this.ConnectionType = ConnectionType;
            this.Ram = Ram;
            this.StorageGB = StorageGB;
        }

        public Computer()
        {
            ConnectionType = "wireless";
        }

        public void AddRam(int size)
        {
            this.Ram += size;
        }
        public void AddStorage(int size)
        {
            this.StorageGB += size;
        }
        public override void CreateID()
        {
            Random newRandom = new Random();
            this.ID = newRandom.Next(1,500);
            this.ID += newRandom.Next(1, 500);
        }


    }
    
}
