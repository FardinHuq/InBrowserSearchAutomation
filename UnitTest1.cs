using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Selenium_Automation
{
    class Program
    {
        //create reference for chrome
        IWebDriver driver = new ChromeDriver();
        public static void Main(string[] args)
        {

        }
        [SetUp]
        public void Initialize()
        {
            //go to page
            driver.Navigate().GoToUrl("https://www.google.com");
        }
        [Test]
        public void ExecuteTest()
        {
            //full screen
            driver.Manage().Window.Maximize();
            //find the  element
            IWebElement searchbox = driver.FindElement(By.Name("q"));
            //type in the searchbox
            searchbox.SendKeys("instagram");
            //submit the search box
            searchbox.Submit();
            //Wait to see the results
            //Thread.Sleep(1000);
            //find the 1st result
            //IWebElement firstresult = driver.FindElement(By.CssSelector("h2 a")); //for chrome "h3"
            //click on the 1st result
            //firstresult.Click();
            //wait to see result
            //Thread.Sleep(2000);
        }
        [TearDown]
        public void Close()
        {
            //close the browser
            driver.Quit();

        }
    }
}
