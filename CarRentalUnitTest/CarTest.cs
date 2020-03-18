using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarRental;
using System.Linq;

namespace CarRentalUnitTest
{
    [TestClass]
    public class CarTest
    {
        [TestMethod]
        public void Test_InitializeData()
        {
            MainForm mainForm = new MainForm();
            mainForm.InitializeData();
            Assert.IsTrue(mainForm.Cars.Count() == 4);
        }

        [TestMethod]
        public void Test_CalculateInitializeData()
        {
            MainForm mainForm = new MainForm();
            mainForm.InitializeData();
            double initializeRentValue = mainForm.CalculateRent();
            Assert.AreEqual(initializeRentValue, 0);
        }

        [TestMethod]
        public void Test_CalculateDataLessThan3Days()
        {
            MainForm mainForm = new MainForm();
            mainForm.InitializeData();
            mainForm.Cars[0].DayRent = 2;
            mainForm.Cars[0].Rent = 100000;
            double initializeRentValue = mainForm.CalculateRent();
            Assert.AreEqual(initializeRentValue, 200000);
        }

        [TestMethod]
        public void Test_CalculateDataMoreThan3Days()
        {
            MainForm mainForm = new MainForm();
            mainForm.InitializeData();
            mainForm.Cars[0].DayRent = 4;
            mainForm.Cars[0].Rent = 100000;
            double initializeRentValue = mainForm.CalculateRent();
            Assert.AreEqual(initializeRentValue, 380000);
        }

        [TestMethod]
        public void Test_CalculateRent2Cars()
        {
            MainForm mainForm = new MainForm();
            mainForm.InitializeData();
            mainForm.Cars[0].DayRent = 2;
            mainForm.Cars[0].Rent = 100000;
            mainForm.Cars[1].DayRent = 2;
            mainForm.Cars[1].Rent = 50000;
            double initializeRentValue = mainForm.CalculateRent();
            Assert.AreEqual(initializeRentValue, 270000);
        }

        [TestMethod]
        public void Test_CalculateRent2CarsWithOldCar()
        {
            MainForm mainForm = new MainForm();
            mainForm.InitializeData();
            mainForm.Cars[0].DayRent = 2;
            mainForm.Cars[0].Rent = 100000;
            mainForm.Cars[0].Year = 2005;
            mainForm.Cars[1].DayRent = 2;
            mainForm.Cars[1].Rent = 50000;
            double initializeRentValue = mainForm.CalculateRent();
            Assert.IsTrue(initializeRentValue < 270000);
        }
    }
}
