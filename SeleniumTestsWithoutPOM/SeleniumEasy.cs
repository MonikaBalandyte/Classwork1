

using System.Threading;
using System.Xml.Linq;
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

        [Test]

        public void FillTextBoxes()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Url = "https://demoqa.com/text-box";

            IWebElement inputFullName = driver.FindElement(By.XPath("//*[@id='userName']"));
            IWebElement inputEmail = driver.FindElement(By.XPath("//*[@id='userEmail']"));
            IWebElement inputCurrentAddress = driver.FindElement(By.XPath("//*[@id='currentAddress']"));
            IWebElement inputPermanentAddress = driver.FindElement(By.XPath("//*[@id='permanentAddress']"));
            IWebElement buttonSumbit = driver.FindElement(By.XPath("//*[@id='submit']"));
            IWebElement output = driver.FindElement(By.XPath("//*[@id='output']"));

            inputFullName.SendKeys("Monika Balandyte");
            inputEmail.SendKeys("m.balandyte@gmail.com");
            inputCurrentAddress.SendKeys("Gatves 24-2, Vilnius");
            inputPermanentAddress.SendKeys("Gatves 24-2, Vilnius");
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver; //method to scroll down the page because of ad banners covering "Submit" button 
            js.ExecuteScript("window.scrollBy(0,1000)");
            buttonSumbit.Click();
            string expectedResult = "Name:Monika Balandyte\r\nEmail:m.balandyte@gmail.com\r\nCurrent Address :Gatves 24-2, Vilnius\r\nPermananet Address :Gatves 24-2, Vilnius";
            string actualResult = output.Text;

            Assert.AreEqual(expectedResult, actualResult);

            driver.Quit();
        }

        [Test]

        public void checkIfEmailTextBoxIsMarkedInRed()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Url = "https://demoqa.com/text-box";

            IWebElement inputEmail = driver.FindElement(By.XPath("//*[@id='userEmail']"));
            IWebElement buttonSumbit = driver.FindElement(By.XPath("//*[@id='submit']"));
            //IWebElement incorrectEmailField = driver.FindElement(By.XPath("//input[@class='mr-sm-2 field-error form-control']"));
            string expectedClassResult = "mr-sm-2 field-error form-control";
            string actualClassResult = inputEmail.GetAttribute("class");

            inputEmail.SendKeys("m");
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver; //method to scroll down the page because of ad banners covering "Submit" button 
            js.ExecuteScript("window.scrollBy(0,800)");
            buttonSumbit.Click();
            //Thread.Sleep(10);

            Assert.AreEqual(expectedClassResult, actualClassResult);
           

            //driver.Quit();
        }



    } 
}
