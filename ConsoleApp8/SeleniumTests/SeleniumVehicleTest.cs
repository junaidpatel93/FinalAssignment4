using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class SeleniumVehicleTest
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "https://www.katalon.com/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheValidateDataStorageTest()
        {
            driver.Navigate().GoToUrl("http://localhost/home.html");
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).Clear();
            driver.FindElement(By.Id("firstName")).SendKeys("Junaid");
            driver.FindElement(By.Id("lastName")).Clear();
            driver.FindElement(By.Id("lastName")).SendKeys("Patel");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("abc@abc.com");
            driver.FindElement(By.Id("phone")).Clear();
            driver.FindElement(By.Id("phone")).SendKeys("437-775-8003");
            driver.FindElement(By.Id("address")).Clear();
            driver.FindElement(By.Id("address")).SendKeys("Vanier");
            driver.FindElement(By.Id("city")).Clear();
            driver.FindElement(By.Id("city")).SendKeys("Waterloo");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Province'])[1]/following::select[1]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Province'])[1]/following::option[1]")).Click();
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).Clear();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2C 1J4");
            driver.FindElement(By.Id("make")).Clear();
            driver.FindElement(By.Id("make")).SendKeys("Ford");
            driver.FindElement(By.Id("model")).Clear();
            driver.FindElement(By.Id("model")).SendKeys("Mustang");
            driver.FindElement(By.Id("year")).Clear();
            driver.FindElement(By.Id("year")).SendKeys("2014");
            driver.FindElement(By.Id("btnclearstorage")).Click();
            driver.FindElement(By.Id("btnupload")).Click();
            Assert.AreEqual("Junaid", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='URL'])[1]/following::td[1]")).Text);
            Assert.AreEqual("Patel", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Junaid'])[1]/following::td[1]")).Text);
            Assert.AreEqual("abc@abc.com", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Patel'])[1]/following::td[1]")).Text);
            Assert.AreEqual("437-775-8003", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='abc@abc.com'])[1]/following::td[1]")).Text);
            Assert.AreEqual("Vanier", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='abc@abc.com'])[1]/following::td[2]")).Text);
            Assert.AreEqual("Waterloo", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Vanier'])[1]/following::td[1]")).Text);
            Assert.AreEqual("N2C 1J4", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Ontario'])[2]/following::td[1]")).Text);
            Assert.AreEqual("Ford", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='N2C 1J4'])[1]/following::td[1]")).Text);
            Assert.AreEqual("Mustang", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Ford'])[1]/following::td[1]")).Text);
            Assert.AreEqual("2014", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Mustang'])[1]/following::td[1]")).Text);
            Assert.AreEqual("http://www.jdpower.com/cars/Ford/Mustang/2014", driver.FindElement(By.LinkText("http://www.jdpower.com/cars/Ford/Mustang/2014")).Text);
        }

        [Test]
        public void TheValidatePhoneTest()
        {
            driver.Navigate().GoToUrl("http://localhost/home.html");
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).Clear();
            driver.FindElement(By.Id("firstName")).SendKeys("Junaid");
            driver.FindElement(By.Id("lastName")).Clear();
            driver.FindElement(By.Id("lastName")).SendKeys("Patel");
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("abc@abc.com");
            driver.FindElement(By.Id("phone")).Clear();
            driver.FindElement(By.Id("phone")).SendKeys("4377758003");
            driver.FindElement(By.Id("address")).Clear();
            driver.FindElement(By.Id("address")).SendKeys("qwerty");
            driver.FindElement(By.Id("city")).Clear();
            driver.FindElement(By.Id("city")).SendKeys("Waterloo");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Province'])[1]/following::select[1]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Province'])[1]/following::option[1]")).Click();
            driver.FindElement(By.Id("postalCode")).Clear();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2P 2N5");
            driver.FindElement(By.Id("make")).Clear();
            driver.FindElement(By.Id("make")).SendKeys("Ford");
            driver.FindElement(By.Id("model")).Clear();
            driver.FindElement(By.Id("model")).SendKeys("Mustang");
            driver.FindElement(By.Id("year")).Clear();
            driver.FindElement(By.Id("year")).SendKeys("2014");
            driver.FindElement(By.Id("btnupload")).Click();
            Assert.AreEqual("(Please enter correct phone number/format)", driver.FindElement(By.Id("phone-error")).Text);
        }

        [Test]
        public void TheValidateJDPowerURLTest()
        {
            driver.Navigate().GoToUrl("http://localhost/home.html");
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).Clear();
            driver.FindElement(By.Id("firstName")).SendKeys("Junaid");
            driver.FindElement(By.Id("lastName")).Clear();
            driver.FindElement(By.Id("lastName")).SendKeys("Patel");
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("junaid.patel93@gmail.com");
            driver.FindElement(By.Id("phone")).Clear();
            driver.FindElement(By.Id("phone")).SendKeys("437-775-8003");
            driver.FindElement(By.Id("address")).Clear();
            driver.FindElement(By.Id("address")).SendKeys("Vanier");
            driver.FindElement(By.Id("city")).Clear();
            driver.FindElement(By.Id("city")).SendKeys("Waterloo");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Province'])[1]/following::select[1]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Province'])[1]/following::option[1]")).Click();
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).Clear();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2C 1J4");
            driver.FindElement(By.Id("make")).Clear();
            driver.FindElement(By.Id("make")).SendKeys("Ford");
            driver.FindElement(By.Id("model")).Clear();
            driver.FindElement(By.Id("model")).SendKeys("Mustang");
            driver.FindElement(By.Id("year")).Clear();
            driver.FindElement(By.Id("year")).SendKeys("2014");
            driver.FindElement(By.Id("btnclearstorage")).Click();
            driver.FindElement(By.Id("btnupload")).Click();
            driver.FindElement(By.LinkText("http://www.jdpower.com/cars/Ford/Mustang/2014")).Click();
            Assert.AreEqual("2014 Ford Mustang ratings and reviews".ToLower(), driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Select Trim'])[1]/following::h1[1]")).Text.ToLower());
        }

        [Test]
        public void TheCheckMandatoryFieldsTest()
        {
            driver.Navigate().GoToUrl("http://localhost/home.html");
            driver.FindElement(By.Id("btnupload")).Click();
            Assert.AreEqual("(Please Enter First Name)", driver.FindElement(By.Id("fn-error")).Text);
            Assert.AreEqual("(Please Enter Last Name)", driver.FindElement(By.Id("ln-error")).Text);
            Assert.AreEqual("(Please Enter Email in correct format)", driver.FindElement(By.Id("email-error")).Text);
            Assert.AreEqual("(Please enter correct phone number/format)", driver.FindElement(By.Id("phone-error")).Text);
            Assert.AreEqual("(Please Enter Address)", driver.FindElement(By.Id("ad-error")).Text);
            Assert.AreEqual("(Please Enter City)", driver.FindElement(By.Id("city-error")).Text);
            Assert.AreEqual("(Please Enter Correct Postal Code)", driver.FindElement(By.Id("pc-error")).Text);
            Assert.AreEqual("(Please Enter Valid Make)", driver.FindElement(By.Id("make-error")).Text);
            Assert.AreEqual("(Please Enter Valid Model)", driver.FindElement(By.Id("model-error")).Text);
            Assert.AreEqual("(Please Enter Valid Year)", driver.FindElement(By.Id("year-error")).Text);
        }

        [Test]
        public void TheValidateSearchFilterTest()
        {
            driver.Navigate().GoToUrl("http://localhost/home.html");
            driver.FindElement(By.Id("btnclearstorage")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).Clear();
            driver.FindElement(By.Id("firstName")).SendKeys("Junaid");
            driver.FindElement(By.Id("lastName")).Clear();
            driver.FindElement(By.Id("lastName")).SendKeys("Patel");
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("abc@abc.com");
            driver.FindElement(By.Id("phone")).Clear();
            driver.FindElement(By.Id("phone")).SendKeys("437-775-8003");
            driver.FindElement(By.Id("address")).Clear();
            driver.FindElement(By.Id("address")).SendKeys("Vanier");
            driver.FindElement(By.Id("city")).Clear();
            driver.FindElement(By.Id("city")).SendKeys("Waterloo");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Province'])[1]/following::select[1]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Province'])[1]/following::option[1]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Province'])[1]/following::div[1]")).Click();
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).Clear();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2C 1J4");
            driver.FindElement(By.Id("make")).Clear();
            driver.FindElement(By.Id("make")).SendKeys("Ford");
            driver.FindElement(By.Id("model")).Clear();
            driver.FindElement(By.Id("model")).SendKeys("Mustang");
            driver.FindElement(By.Id("year")).Clear();
            driver.FindElement(By.Id("year")).SendKeys("2013");
            driver.FindElement(By.Id("btnupload")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).Clear();
            driver.FindElement(By.Id("firstName")).SendKeys("Jp");
            driver.FindElement(By.Id("lastName")).Clear();
            driver.FindElement(By.Id("lastName")).SendKeys("P");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("absdcc@abc.com");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).Clear();
            driver.FindElement(By.Id("phone")).SendKeys("437-775-8005");
            driver.FindElement(By.Id("make")).Click();
            // ERROR: Caught exception [ERROR: Unsupported command [doubleClick | id=make | ]]
            driver.FindElement(By.Id("make")).Clear();
            driver.FindElement(By.Id("make")).SendKeys("Gmc");
            driver.FindElement(By.Id("model")).Clear();
            driver.FindElement(By.Id("model")).SendKeys("Acadia");
            driver.FindElement(By.Id("btnupload")).Click();
            driver.FindElement(By.Id("myInput")).Click();
            driver.FindElement(By.Id("myInput")).Clear();
            driver.FindElement(By.Id("myInput")).SendKeys("Ford");
            driver.FindElement(By.Id("firstName")).Click();
            Assert.AreEqual("Ford", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='N2C 1J4'])[2]/following::td[1]")).Text);
            driver.FindElement(By.Id("myInput")).Click();
            // ERROR: Caught exception [ERROR: Unsupported command [doubleClick | id=myInput | ]]
            driver.FindElement(By.Id("myInput")).Clear();
            driver.FindElement(By.Id("myInput")).SendKeys("Mustang");
            Assert.AreEqual("Mustang", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Ford'])[1]/following::td[1]")).Text);
            driver.FindElement(By.Id("myInput")).Clear();
            driver.FindElement(By.Id("myInput")).SendKeys("");
            driver.FindElement(By.Id("year")).Click();
            driver.FindElement(By.Id("year")).Clear();
            driver.FindElement(By.Id("year")).SendKeys("2014");
            driver.FindElement(By.Id("btnupload")).Click();
            driver.FindElement(By.Id("myInput")).Click();
            driver.FindElement(By.Id("myInput")).Clear();
            driver.FindElement(By.Id("myInput")).SendKeys("2013");
            Assert.AreEqual("2013", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Acadia'])[1]/following::td[1]")).Text);
            Assert.AreEqual("2013", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Mustang'])[1]/following::td[1]")).Text);
        }

        [Test]
        public void TheCheckNoDataStoredIfIncorrectValueTest()
        {
            driver.Navigate().GoToUrl("http://localhost/home.html");
            driver.FindElement(By.Id("btnclearstorage")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).Clear();
            driver.FindElement(By.Id("firstName")).SendKeys("Junaid");
            driver.FindElement(By.Id("lastName")).Clear();
            driver.FindElement(By.Id("lastName")).SendKeys("Patel");
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("abc@abc.com");
            driver.FindElement(By.Id("phone")).Clear();
            driver.FindElement(By.Id("phone")).SendKeys("437-775-8003");
            driver.FindElement(By.Id("address")).Clear();
            driver.FindElement(By.Id("address")).SendKeys("Vanier");
            driver.FindElement(By.Id("city")).Clear();
            driver.FindElement(By.Id("city")).SendKeys("Kitchener");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Province'])[1]/following::select[1]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Province'])[1]/following::option[1]")).Click();
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).Clear();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2P 2N5");
            driver.FindElement(By.Id("make")).Clear();
            driver.FindElement(By.Id("make")).SendKeys("Ford");
            driver.FindElement(By.Id("model")).Clear();
            driver.FindElement(By.Id("model")).SendKeys("Mustang");
            driver.FindElement(By.Id("year")).Clear();
            driver.FindElement(By.Id("year")).SendKeys("2014");
            driver.FindElement(By.Id("btnupload")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).Clear();
            driver.FindElement(By.Id("firstName")).SendKeys("JP");
            driver.FindElement(By.Id("lastName")).Click();
            driver.FindElement(By.Id("lastName")).Clear();
            driver.FindElement(By.Id("lastName")).SendKeys("P");
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).Clear();
            driver.FindElement(By.Id("firstName")).SendKeys("MJ");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("asda@abc.com");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).Clear();
            driver.FindElement(By.Id("phone")).SendKeys("437-775-8005");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("make")).Click();
            driver.FindElement(By.Id("make")).Clear();
            driver.FindElement(By.Id("make")).SendKeys("Gmc");
            driver.FindElement(By.Id("model")).Clear();
            driver.FindElement(By.Id("model")).SendKeys("Acadia");
            driver.FindElement(By.Id("btnupload")).Click();
            driver.FindElement(By.Id("make")).Click();
            driver.FindElement(By.Id("make")).Click();
            driver.FindElement(By.Id("make")).Clear();
            driver.FindElement(By.Id("make")).SendKeys("Lamborghini");
            driver.FindElement(By.Id("model")).Click();
            driver.FindElement(By.Id("model")).Clear();
            driver.FindElement(By.Id("model")).SendKeys("Aventador");
            driver.FindElement(By.Id("btnupload")).Click();
            driver.FindElement(By.Id("make")).Click();
            driver.FindElement(By.Id("make")).Clear();
            driver.FindElement(By.Id("make")).SendKeys("Ferrari");
            driver.FindElement(By.Id("model")).Clear();
            driver.FindElement(By.Id("model")).SendKeys("");
            driver.FindElement(By.Id("btnupload")).Click();
            // Warning: assertTextNotPresent may require manual changes
            Assert.IsFalse(Regex.IsMatch(driver.FindElement(By.CssSelector("BODY")).Text, "^[\\s\\S]*xpath=\\(\\.//[\\s\\S]*\\[normalize-space\\(text\\(\\)\\) and normalize-space\\(\\.\\)='\\(Please Enter Valid Year\\)'\\]\\)\\[1\\]/following::div\\[5\\][\\s\\S]*$"));
            driver.FindElement(By.Id("make")).Click();
            driver.FindElement(By.Id("make")).Clear();
            driver.FindElement(By.Id("make")).SendKeys("Ford");
            driver.FindElement(By.Id("model")).Clear();
            driver.FindElement(By.Id("model")).SendKeys("Focus");
            driver.FindElement(By.Id("year")).Clear();
            driver.FindElement(By.Id("year")).SendKeys("1998");
            driver.FindElement(By.Id("btnupload")).Click();
            // Warning: assertTextNotPresent may require manual changes
            Assert.IsFalse(Regex.IsMatch(driver.FindElement(By.CssSelector("BODY")).Text, "^[\\s\\S]*xpath=\\(\\.//[\\s\\S]*\\[normalize-space\\(text\\(\\)\\) and normalize-space\\(\\.\\)='\\(Please Enter Valid Year\\)'\\]\\)\\[1\\]/following::div\\[5\\][\\s\\S]*$"));
        }

        [Test]
        public void TheVerifyIncorrectURLTest()
        {
            driver.Navigate().GoToUrl("http://localhost/home.html");
            driver.FindElement(By.Id("btnclearstorage")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).Clear();
            driver.FindElement(By.Id("firstName")).SendKeys("Junaid");
            driver.FindElement(By.Id("lastName")).Clear();
            driver.FindElement(By.Id("lastName")).SendKeys("Patel");
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("abc@abc.com");
            driver.FindElement(By.Id("phone")).Clear();
            driver.FindElement(By.Id("phone")).SendKeys("437-775-8003");
            driver.FindElement(By.Id("address")).Clear();
            driver.FindElement(By.Id("address")).SendKeys("Vanier");
            driver.FindElement(By.Id("city")).Clear();
            driver.FindElement(By.Id("city")).SendKeys("Kitchener");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Province'])[1]/following::select[1]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Province'])[1]/following::option[1]")).Click();
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).Clear();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2C 1J4");
            driver.FindElement(By.Id("make")).Clear();
            driver.FindElement(By.Id("make")).SendKeys("Lamborghini");
            driver.FindElement(By.Id("model")).Clear();
            driver.FindElement(By.Id("model")).SendKeys("Aventador");
            driver.FindElement(By.Id("year")).Clear();
            driver.FindElement(By.Id("year")).SendKeys("2000");
            driver.FindElement(By.Id("btnupload")).Click();
            driver.FindElement(By.LinkText("http://www.jdpower.com/cars/Lamborghini/Aventador/2000")).Click();
            Assert.AreEqual(("404 - Not Found").ToLower(), driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Careers'])[1]/following::h1[1]")).Text.ToLower());
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
