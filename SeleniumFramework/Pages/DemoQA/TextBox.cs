using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework.Pages.DemoQA
{
    public class TextBox
    {
        public static void Open()
        {
            Driver.OpenURL("https://demoqa.com/text-box");
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
