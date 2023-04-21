
using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SeleniumFramework.Pages
{
    internal class Common
    {
        private static IWebElement GetElement(string locator) 
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }
        internal static void ClickElement(string locator)
        {
            GetElement(locator).Click();
        }
        private static List<IWebElement> GetElements(string locator)
        {
            return Driver.GetDriver().FindElements(By.XPath(locator)).ToList();
        }

        internal static string GetElementText(string locator)
        {
            return GetElement(locator).Text;
        }

        internal static void SendKeys(string locator, string message)
        {
            GetElement(locator).SendKeys(message);
        }

        internal static void ScrollDown(IJavaScriptExecutor driver)
        {
            IJavaScriptExecutor jse = driver;
            jse.ExecuteScript("window.scrollBy(0, 200)");
        }

        internal static void ClickElements(string locator)
        {
           List<IWebElement> elements = GetElements(locator);

            foreach (IWebElement element in elements)
            {
                element.Click();
            }
        }

        internal static void ClickElements(object inputsMultipleCheckbox)
        {
            throw new NotImplementedException();
        }

        internal static string GetAttributeValue(string buttonMultipleCheckBoxes, string v)
        {
            throw new NotImplementedException();
        }

        internal static void WaitForElementToBeClickable(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(locator)));
        }

        internal static bool CheckIfElementIsEnabled(string locator)
        {
            return GetElement(locator).Enabled;
        }
    }
}
