using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        //create webdriver
        IWebDriver driver = new ChromeDriver();
        static void Main(string[] args)
        {

           //create webdriver
            IWebDriver driver = new ChromeDriver();

            //navigate to google page

            driver.Navigate().GoToUrl("http://google.com");

            IWebElement element = driver.FindElement(By.Name("q"));

            element.SendKeys("Execute Automation");

            driver.Close();
        }

        [SetUp]
        public void Initialise()
        {
            //navigate to google page

            driver.Navigate().GoToUrl("http://www.executeautomation.com/demosite/index.html");
            Console.WriteLine("URL Opened");

        }

        [Test]
        public void ExecuteTest()
        {
            SeleniumSetMethods.DropDown(driver, "TitleId", "Mr.", "Id");

            //Initial

            SeleniumSetMethods.Entertext(driver, "Initial", "Execute Automation", "Name");

            //click

            SeleniumSetMethods.Click(driver, "Save", "Name");
            Console.WriteLine("test Executed");
           

        }
          
        [TearDown]
        public void CleanUp()
        {
            driver.Close();
            Console.WriteLine("browser closed");

        }
    }
}
