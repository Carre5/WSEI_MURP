using Moq;
using MURP_Lib.Logic;
using MURP_Lib.Models;
using NUnit.Framework;
using System.Collections.Generic;

namespace MURP_Lib_Tests
{
    public class Order_Tests
    {
        Mock<Validators> _validator;
        User modelUser;

        [SetUp]
        public void Setup()
        {
            _validator = new Mock<Validators>();

            modelUser = new User()
            {
                Id = 1,
                First_Name = "Marcin",
                Last_Name = "Pyjos",
                Home_Address = "Kraków",
                Phone_Number = 123456789,
                Email = "marcin.pyjos@wsei.pl"
            };

            OrderManagment.Orders = new List<Order>();
            OrderManagment.Orders.Add(new Order()); ;
        }

        [Test]
        [TestCase("company@test.com","KWA ABC")]
        [TestCase("company1@test.com", "KMI ABC")]
        [TestCase("company2@test.com", "KMY ABC")]
        public void CreateOrder_ThrowsException(string companyEmail, string carRegistrationNumber)
        {
            Assert.That(() => OrderManagment.CreateOrder(companyEmail, carRegistrationNumber), Throws.Exception);
        }

        [Test]
        [TestCase(null, null)]
        [TestCase("",null)]
        [TestCase(null,"")]
        public void saveOrder_ThrowsException(string ord, string usr)
        {
            Order order;
            User user;

            if (ord == "")
                order = new Order();
            else
                order = null;
            if (usr == "")
                user = new User();
            else
                user = null;

            Assert.That(() => OrderManagment.SaveOrder(order, user), Throws.Exception);
        }

        [Test]
        [TestCase(null, 5)]
        public void ResolveOrder_ThrowsException(string ord, int rating)
        {
            Order order;
            Order_Rating r;

            if (ord == "")
                order = new Order();
            else
                order = null;

            r = Order_Rating.Average;
            if(rating == 5)
                r = Order_Rating.Very_Good;

            Assert.That(() => OrderManagment.ResolveOrder(order, r), Throws.Exception);
        }
    }
}