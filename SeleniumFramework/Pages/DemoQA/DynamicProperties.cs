

using System;

namespace SeleniumFramework.Pages.DemoQA
{
    public class DynamicProperties
    {
        public static bool WaitForButtonToBeClickable()
        {
            string locator = "//*[@id='enableAfter']";
            Common.WaitForElementToBeClickable(locator);
            return Common.CheckIfElementIsEnabled(locator);
        }

        public static void Open()
        {
            Driver.OpenURL("https://demoqa.com/dynamic-properties");
        }

       /* public static void WaitForButtonToBeClickable()
        {
            string locator = "//*[@id='enableAfter']";
            Common.WaitForButtonToBeClickable(locator);
        }*/
    }
}
