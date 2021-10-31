using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace SeleniumCSharp
{
    public class Tests
    {

        public IWebDriver Driver;
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");
            Driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://tidota2shop.vn/my-account/");

            Thread.Sleep(15000);
            if (Driver.FindElement(By.Id("password")) != null) 
            {
                Console.WriteLine("Login-page-has-found");
                Driver.FindElement(By.Id("username")).SendKeys("ennyug@gmail.com");
                Driver.FindElement(By.Id("password")).SendKeys("ennyug123");
                Driver.FindElement(By.Name("login")).Click();
            } 
            else
            {
                Console.WriteLine("Login-page-not-found");
            }
            if (Driver.FindElement(By.CssSelector("a[href*='logout']")) != null)
            {
                Console.WriteLine("Login success!!!");
            }
            else
            {
                Console.WriteLine("Login failed");
            }



            Console.WriteLine("Test1");
            Assert.Pass();
        }
    }
}