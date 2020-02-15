using Moq;
using MURP_Lib.Logic;
using MURP_Lib.Models;
using NUnit.Framework;
using System.Collections.Generic;

namespace MURP_Lib_Tests
{
    public class Valiators_Tests
    {
        Validators v;

        [SetUp]
        public void Setup()
        {
            v = new Validators();
        }

        [Test]
        [TestCase("me@me.pl",true)]
        [TestCase("meme.pl", false)]
        [TestCase("me@mepl", false)]
        public void ValidateEmail_Works(string input, bool result)
        {
            Assert.AreEqual(result, v.EmailValid(input));
        }

        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void ValidateEmail_ThrowsException(string input)
        {
            Assert.That( () => v.EmailValid(input), Throws.ArgumentNullException);
        }
    }
}