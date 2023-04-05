
using System;
using OpenQA.Selenium;
using SeleniumFramework;

namespace SeleniumFramework.Pages.SeleniumEasy1
{

    public class SimpleFormDemo
    {
        public static void Open()
        {
            Driver.OpenURL("https://demo.seleniumeasy.com/basic-first-form-demo.html");
        }

        public static void EnterMessage(string message)
        {
            string locator = "//*[@id='get-input']//input";
            Common.SendKeys(locator, message);
        }

        public static void ClickShowMessageButton()
        {
            string locator = "//*[@id='get-input']/button";
            Common.ClickElement(locator);
        }

        public static string GetSingleInputFieldMessage()
        {
            string locator = "//*[@id='display']";
            return Common.GetElementText(locator);
        }
        public static void EnterInputA(string inputAvalue)
        {
           string locator = "//*[@id='sum1']";
            Common.SendKeys(locator, inputAvalue);
        }

        public static void EnterInputB(string inputBvalue)
        {
            string locator = "//*[@id='sum2']";
            Common.SendKeys(locator, inputBvalue);
        }

        public static void ClickGetTotalButton()
        {
            string locator = "//*[@id='gettotal']/button";
            Common.ClickElement(locator);
        }

        public static string GetTwoInputFieldsMessages()
        {
            string locator = "//*[@id='displayvalue']";
            return Common.GetElementText(locator);
        }

        public static void EnterFullName(string fullName)
        {
            string locator = "//*[@id='userName']";
            Common.SendKeys(locator, fullName);
        }

        public static void EnterEmail(string email)
        {
            string locator = "//*[@id='userEmail']";
            Common.SendKeys(locator, email);
        }

        public static void EnterCurrentAddress(string currentAddress)
        {
            string locator = "//*[@id='currentAddress']";
            Common.SendKeys(locator, currentAddress);
        }

        public static void EnterPermanentAddress(string permanentAddress)
        {
            string locator = "//*[@id='permanentAddress']";
            Common.SendKeys(locator, permanentAddress);
        }

        public static void ScrollDownThePage()
        {
           // Common.ScrollDown();
        }

        public static void ClickButtonSubmit()
        {
            string locator = "//*[@id='submit']";
            Common.ClickElement(locator);
        }

        public static string GetOutputMessage()
        {
            string locator = "//*[@id='output']";
            return Common.GetElementText(locator);
        }
    }
}

/* IWebElement inputFullName = driver.FindElement(By.XPath("//*[@id='userName']"));
IWebElement inputEmail = driver.FindElement(By.XPath("//*[@id='userEmail']"));
IWebElement inputCurrentAddress = driver.FindElement(By.XPath("//*[@id='currentAddress']"));
IWebElement inputPermanentAddress = driver.FindElement(By.XPath("//*[@id='permanentAddress']"));
IWebElement buttonSumbit = driver.FindElement(By.XPath("//*[@id='submit']"));
IWebElement output = driver.FindElement(By.XPath("//*[@id='output']"));*/