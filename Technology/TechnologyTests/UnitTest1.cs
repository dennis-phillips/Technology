using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;

namespace TechnologyTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckComputerConnectionValue()
        {
            Computer NewComputer = new Computer();
            Assert.AreEqual("wireless", NewComputer.ConnectionType);
        }
        [TestMethod]
        public void CheckComputerAddRamFunction()
        {
            Computer NewComputer = new Computer();
            NewComputer.AddRam(8);
            Assert.AreEqual(8, NewComputer.Ram);
        }
        [TestMethod]
        public void CheckComputerAddStorageFunction()
        {
            Computer NewComputer = new Computer();
            NewComputer.AddStorage(500);
            Assert.AreEqual(500, NewComputer.StorageGB);
        }
        [TestMethod]
        public void CheckLaptopConnectionValue()
        {
            Laptop NewLaptop = new Laptop();
            Assert.AreEqual("wireless", NewLaptop.ConnectionType);
        }
        [TestMethod]
        public void CheckLaptopAddStorageFunction()
        {
            Laptop NewLaptop = new Laptop();
            NewLaptop.AddStorage(500);
            Assert.AreEqual(500, NewLaptop.StorageGB);
        }
        [TestMethod]
        public void CheckLaptopAddRamFunction()
        {
            Laptop NewLaptop = new Laptop();
            NewLaptop.AddRam(8);
            Assert.AreEqual(8, NewLaptop.Ram);
        }
        [TestMethod]
        public void CheckSmartPhoneConnectionValue()
        {
            SmartPhone NewPhone = new SmartPhone("Apple");
            Assert.AreEqual("wireless", NewPhone.ConnectionType);
        }
        [TestMethod]
        public void CheckSmartPhoneAddStorageFunction()
        {
            SmartPhone NewPhone = new SmartPhone("Samsung");
            NewPhone.AddStorage(500);
            Assert.AreEqual(500, NewPhone.StorageGB);
        }
        [TestMethod]
        public void CheckSmartPhoneBrand()
        {
            SmartPhone NewPhone = new SmartPhone("Apple");
            
            Assert.AreEqual("Apple", NewPhone.Brand);
        }
    }
}
