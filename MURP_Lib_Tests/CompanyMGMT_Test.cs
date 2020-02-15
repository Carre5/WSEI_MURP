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
        public void FindByEmail_ReturnsCompany(string name, string address, string email, string tin)
        {
            Company newcompany = new Company(name, address, email, tin);
            CompanyManagment.Companies.Add(newcompany);

            var result = CompanyManagment.FindByEmail(email);

            Assert.AreEqual(email,result.Email_Address);
        }

        [Test]
        public void FindByEmail_ReturnsNull()
        {
            CompanyManagment.Companies = new List<Company>();
            
            string email = "text@text.pl";
            var result = CompanyManagment.FindByEmail(email);

            Assert.AreEqual(null, result);
        }

        [Test]
        [TestCase("NotMine", "NotHere", "nothere@nothere.com", "10987654321")]
        public void HandleRating_returnsTrue(string name, string address, string email, string tin)
        {
            Company newcompany = new Company(name, address, email, tin);
            CompanyManagment.Companies.Add(newcompany);

            var result = CompanyManagment.HandleRating(newcompany,Order_Rating.Very_Bad);

            Assert.AreEqual(result,true);
        }

        [Test]
        public void HandleRating_returnsFalse()
        {
            Company newcompany = new Company("NotMine", "NotHere", "nothere@nothere.com", "10987654321");
            CompanyManagment.Companies = new List<Company>();

            var result = CompanyManagment.HandleRating(newcompany, Order_Rating.Very_Bad);

            Assert.AreEqual(result, false);
        }
    }
}