using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework.Pages.SeleniumEasy1
{

    public class SimpleFormDemo
    {
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
    }
}
 
 
