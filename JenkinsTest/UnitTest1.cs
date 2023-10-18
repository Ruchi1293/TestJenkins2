using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using Newtonsoft.Json.Linq;

namespace JenkinsTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [Category("smoke")]
        public void Test1()
        {
            //IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("https://www.facebook.com/");
            //IWebElement CreateAccount = driver.FindElement(By.XPath("//a[text()='Create new account']"));
            //CreateAccount.Click();
            //driver.Dispose();
            JObject q = JObject.Parse(File.ReadAllText("test.JSON"));
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
        [Test]
        public void Test4()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            IWebElement CreateAccount = driver.FindElement(By.XPath("//a[text()='Create new account']"));
            CreateAccount.Click();
            driver.Dispose();
        }
        [Test]
        public void Test5()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            IWebElement CreateAccount = driver.FindElement(By.XPath("//a[text()='Create new account']"));
            CreateAccount.Click();
            driver.Dispose();
        }
    }
}
