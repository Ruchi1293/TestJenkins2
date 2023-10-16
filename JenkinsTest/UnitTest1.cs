using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace JenkinsTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            IWebElement CreateAccount = driver.FindElement(By.XPath("//a[text()='Create new account']"));
            CreateAccount.Click();
            driver.Dispose();
        }

        [Test]
        public void Test2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            IWebElement CreateAccount = driver.FindElement(By.XPath("//a[text()='Create new account']"));
            CreateAccount.Click();
            driver.Dispose();
        }
        [Test]
        public void Test3()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            IWebElement CreateAccount = driver.FindElement(By.XPath("//a[text()='Create new account']"));
            CreateAccount.Click();
            driver.Dispose();
        }
    }
}
