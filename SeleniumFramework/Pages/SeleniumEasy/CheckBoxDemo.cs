
using System;

namespace SeleniumFramework.Pages.SeleniumEasy
{
    public class CheckBoxDemo
    {
        private static string inputSingleCheckbox = "//*[@id='isAgeSelected']";
        private static string fieldSingleCheckboxSuccessMessage = "//*[@id='txtAge']";

        public static void Open()
        {
            Driver.OpenURL("http://demo.seleniumeasy.com/basic-checkbox-demo.html");
        }
        public static void ClickSingleCheckbox()
        {
            Common.ClickElement(inputSingleCheckbox);
        }

        public static string GetSingleCheckBoxSuccessMessage()
        {
            return Common.GetElementText(fieldSingleCheckboxSuccessMessage);

        }
    }
}
