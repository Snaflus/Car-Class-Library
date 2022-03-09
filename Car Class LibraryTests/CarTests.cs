using Microsoft.VisualStudio.TestTools.UnitTesting;
using Car_Class_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Car_Class_Library.Car;

namespace Car_Class_Library.Tests
{
    [TestClass()]
    public class CarTests
    {
        private Car _car;
        [TestInitialize]
        public void SetUp()
        {
            _car = new Car(1, "F150", 20000, "123ABC4");
        }

        [TestMethod()]
        public void TestCarConstructor()
        {
            Car car2 = new Car(2, "F200", 30000, "ABC123D");
            Assert.AreEqual(2, car2.Id);
            Assert.AreEqual("F200", car2.Model);
            Assert.AreEqual(30000, car2.Price);
            Assert.AreEqual("ABC123D", car2.License);
        }
        [TestMethod()]
        public void TestCarModel()
        {
            _car.Model = "F150";
            Assert.AreEqual("F150", _car.Model);
            Assert.ThrowsException<ArgumentNullException>(() => _car.Model = null);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _car.Model = "F15");
        }

        [TestMethod()]
        public void TestCarPrice()
        {
            _car.Price = 20000;
            Assert.AreEqual(20000, _car.Price);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _car.Price = 0);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _car.Price = -1);
        }
        [TestMethod()]
        public void TestCarLicense()
        {
            _car.License = "123ABC4";
            Assert.AreEqual("123ABC4", _car.License);
            Assert.ThrowsException<ArgumentNullException>(() => _car.License = null);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _car.License = "123ABC45"); 
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _car.License = "1"); 
        }

    }
}