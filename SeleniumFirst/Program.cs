using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumFirst
{
    
    class Program
    {
        //Create the reference for our browser
        readonly IWebDriver driver = new ChromeDriver(@"C:\Users\rgarzon\source\repos\SeleniumFirst\SeleniumFirst\drivers\");

        //static void Main(string[] args)
        //{   
        //}

        [SetUp]
        public void Inicialize()
        {
            //Navigate to Google page
            driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&Password=Login=Login");
            Console.WriteLine("Opened URL");
        }

        [Test]
        public void ExecuteTest()
        {
            //Find The Element
            IWebElement element = driver.FindElement(By.Name("q"));

            //Perform Ops
            element.SendKeys("executeautomation");

            Console.WriteLine("Executed Test");
            
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
            Console.WriteLine("Closed the driver");
        }
    }
}
