

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTestsWithoutPOM
{
    public class SeleniumEasy
    {
        [Test]

        public void SingleInputField()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Url = "https://demo.seleniumeasy.com/basic-first-form-demo.html";

            string expectedResult = "Labas";
            IWebElement inputMessage = driver.FindElement(By.XPath("//*[@id='get-input']//input"));
            IWebElement buttonShowMessage = driver.FindElement(By.XPath("//*[@id='get-input']/button"));
            IWebElement spanMessageText = driver.FindElement(By.XPath("//*[@id='display']"));

            inputMessage.SendKeys("Labas");
            buttonShowMessage.Click();
            string actualResult = spanMessageText.Text;

            Assert.AreEqual(expectedResult, actualResult);

            driver.Quit();

        }

        [Test]

        public void TwoInputFields()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Url = "https://demo.seleniumeasy.com/basic-first-form-demo.html";

            string expectedResult = "3";
            IWebElement inputValueA = driver.FindElement(By.XPath("//*[@id='sum1']"));
            IWebElement inputValueB = driver.FindElement(By.XPath("//*[@id='sum2']"));
            IWebElement buttonGetTotal = driver.FindElement(By.XPath("//*[@id='gettotal']/button"));
            IWebElement spanTotalResult = driver.FindElement(By.XPath("//*[@id='displayvalue']"));

            inputValueA.SendKeys("1");
            inputValueB.SendKeys("2");
            buttonGetTotal.Click();
            string actualResult = spanTotalResult.Text;

            Assert.AreEqual(expectedResult, actualResult);

            driver.Quit();

        }

       


    }
}
