using Moq;
using MURP_Lib.Logic;
using MURP_Lib.Models;
using NUnit.Framework;
using System.Collections.Generic;

namespace MURP_Lib_Tests
{
    public class Car_Tests
    {
        Mock<Validators> _validator;

        [SetUp]
        public void Setup()
        {
            _validator = new Mock<Validators>();

            CarManagment.Cars = new List<Car>();
            CarManagment.Cars.Add(new Car("Fiat", "Panda", "KR abc"));
        }

        [Test]
        [TestCase("Fiat","Ducato","KR 123")]
        public void CreateNewCar_NoException(string brand, string model, string registrationNumber)
        {
            Car newcar = new Car(brand,model, registrationNumber);
            CarManagment.CreateCar(newcar);

            Assert.AreEqual(newcar.Registration_Number, CarManagment.Cars[CarManagment.Cars.Count-1].Registration_Number);
        }

        [Test]
        [TestCase("Fiat", "Ducato", "KR 123")]
        public void FindByRegistrationNumber_ReturnsCar(string brand, string model, string registrationNumber)
        {
            Car newcar = new Car(brand, model, registrationNumber);
            CarManagment.CreateCar(newcar);

            Car result = CarManagment.FindByRegistrationNumber(registrationNumber);
            Assert.AreEqual(newcar.Registration_Number, result.Registration_Number);
        }

        [Test]
        [TestCase("Fiat", "Ducato", "KR 123")]
        public void FindByRegistrationNumber_ReturnsNull(string brand, string model, string registrationNumber)
        {
            Car newcar = new Car(brand, model, registrationNumber);
            CarManagment.CreateCar(newcar);

            Car result = CarManagment.FindByRegistrationNumber(null);
            Assert.AreEqual(null, result);
        }

        [Test]
        [TestCase("Fiat", "Ducato", null)]
        public void CreateNewCar_ThrowsArgumentNullException(string brand, string model, string registrationNumber)
        {
            Car newcar = new Car(brand, model, null);

            Assert.That(() => CarManagment.CreateCar(newcar), Throws.ArgumentNullException);
        }

        [Test]
        [TestCase("Fiat", "Ducato", "KWA123")]
        public void CreateNewCar_ThrowsFormatException(string brand, string model, string registrationNumber)
        {
            Car newcar = new Car(brand, model, registrationNumber);

            Assert.That(() => CarManagment.CreateCar(newcar), Throws.Exception);
        }
    }
}