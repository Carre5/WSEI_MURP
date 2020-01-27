using NUnit.Framework;
using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

namespace SeleniumTests
{
    [TestFixture]
    public class FirstTests
    {
        IWebDriver _driver;
        [SetUp]
        public void StartBrowser()
        {
            _driver = new ChromeDriver(@"C:\drivers");

        }

        [Test]
        public void FindDataOnWiki()
        {
            var text = "Tadeusz Koœciuszko";
            _driver.Navigate().GoToUrl("https://pl.wikipedia.org/wiki/Wikipedia:Strona_g%C5%82%C3%B3wna");
            var searchTextBox = _driver.FindElement(By.CssSelector("#searchInput"));
            searchTextBox.SendKeys(text + Keys.Enter);
            new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            

            StringAssert.Contains(text, _driver.FindElement(By.CssSelector("#firstHeading")).Text);
        }

        [Test]
        public void RegisterTest()
        {
            string login = "test";
            string password = "PasswordVeryStrong";
            string email = "test@test.com";

            _driver.Navigate().GoToUrl("http://shop.demoqa.com/my-account/");

            var loginBox = _driver.FindElement(By.CssSelector("#reg_username"));
            loginBox.SendKeys(login);

            var emailBox = _driver.FindElement(By.CssSelector("#reg_email"));
            emailBox.SendKeys(email);

            var passwordBox = _driver.FindElement(By.CssSelector("#reg_password"));
            passwordBox.SendKeys(password + Keys.Enter);

            var register = _driver.FindElement(By.CssSelector("#customer_login > div.u-column2.col-2 > form > p.woocommerce-FormRow.form-row > button"));
            register.Click();

            new WebDriverWait(_driver, TimeSpan.FromSeconds(10));

            StringAssert.Contains("An account is already registered with your email address. Please log in.", _driver.FindElement(By.CssSelector("#post-8 > div > div > div.woocommerce-notices-wrapper > ul > li")).Text);
        }

        [Test]
        public void LoginTest()
        {
            string login = "test";
            string password = "password";

            _driver.Navigate().GoToUrl("http://shop.demoqa.com/my-account/");

            var loginBox = _driver.FindElement(By.Id("username"));
            loginBox.SendKeys(login);

            var passwordBox = _driver.FindElement(By.Id("password"));
            passwordBox.SendKeys(password + Keys.Enter);

            new WebDriverWait(_driver, TimeSpan.FromSeconds(10));

            StringAssert.Contains("The username or password you entered is incorrect",_driver.FindElement(By.CssSelector("#post-8 > div > div > div.woocommerce-notices-wrapper > ul > li")).Text);
        }

        [TearDown]
        public void CloseBrowser()
        {
            _driver.Close();
        }

    }
}