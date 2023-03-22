using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SeleniumFramework;
using SeleniumFramework.Pages.SeleniumEasy1;

namespace Selenium1Tests.SeleniumEasy
{
    internal class SimpleFormDemoTests
    {
        [Test]

        public void SingleInputField()
        {
            Driver.SetupDriver();
            Driver.OpenURL("https://demo.seleniumeasy.com/basic-first-form-demo.html");

            string expectedResult = "Test";

            SimpleFormDemo.EnterMessage(expectedResult);
            SimpleFormDemo.ClickShowMessageButton();
            string actualResult = SimpleFormDemo.GetSingleInputFieldMessage();

            
            Assert.AreEqual(expectedResult, actualResult);
            Driver.CloseDriver();

        }

        [Test]

        public void TwoInputFields()
        {
            Driver.SetupDriver();
            Driver.OpenURL("https://demo.seleniumeasy.com/basic-first-form-demo.html");

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
