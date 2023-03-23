
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
    }
}

