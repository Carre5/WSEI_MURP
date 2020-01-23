using Moq;
using MURP_Lib.Logic;
using MURP_Lib.Models;
using NUnit.Framework;
using System.Collections.Generic;

namespace MURP_Lib_Tests
{
    public class Company_Tests
    {
        Mock<Validators> _validator;

        [SetUp]
        public void Setup()
        {
            _validator = new Mock<Validators>();

            CompanyManagment.Companies = new List<Company>();
            CompanyManagment.Companies.Add(new Company("Mine","Here","here@here.com","12345678901"));
        }

        [Test]
        [TestCase("NotMine", "NotHere", "nothere@nothere.com", "10987654321")]
        public void FindByEmail(string name, string address, string email, string tin)
        {
            Company newcompany = new Company(name, address, email, tin);
            CompanyManagment.Companies.Add(newcompany);

            var result = CompanyManagment.FindByEmail(email);

            Assert.AreEqual(email,result.Email_Address);
        }
    }
}