using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace lab6trpo
{
    [TestFixture]
    public class Class1
    {
        IWebDriver WebDriver = new ChromeDriver();
        [TestCase]
        public void maintTitle()
        {

            WebDriver.Url = "https://yandex.ru/";
            Assert.AreEqual("Яндекс", WebDriver.Title);
            WebDriver.Close();

        }
        [TestCase]
        public void request()
        {
            WebDriver.Url = "https://yandex.ru/";
            IWebElement search = WebDriver.FindElement(By.XPath("//*[@id=\"text\"]"));
            search.SendKeys("Новосибирск");
            search.SendKeys(Keys.Return);
            

        }
        [TestCase]
        public void vidimost()
        {
            WebDriver.Url = "https://yandex.ru/";
            IWebElement element = WebDriver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[1]/div/div[1]/div/a[2]"));
            bool status = element.Displayed;
            Assert.IsTrue(status);





        }

        [TestCase]
        public void link()
        {
            WebDriver.Url = "https://yandex.ru/";
            IWebElement search = WebDriver.FindElement(By.XPath("//*[@id=\"text\"]"));
            search.SendKeys("Новосибирск");
            search.SendKeys(Keys.Return);
            IWebElement element = WebDriver.FindElement(By.XPath("/html/body/div[3]/div[1]/div[2]/div[1]/div[1]/ul/li[1]/div/h2/a/div[2]/b"));
            element.Click();

        }
        [TearDown]
        public void testEnd()
        {
            WebDriver.Quit();
        }
    }
}
