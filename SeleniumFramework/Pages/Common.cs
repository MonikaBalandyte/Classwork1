
using System;
using System.Collections.Generic;
using OpenQA.Selenium;

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
            return Driver.GetDriver().FindElement(By.XPath(locator)).ToList();
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
    }
}
