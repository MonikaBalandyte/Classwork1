
using NUnit.Framework;
using SeleniumFramework.Pages.SeleniumEasy1;
using SeleniumFramework;
using SeleniumFramework.Pages.DemoQA;

namespace Selenium1Tests.DemoQA
{
    internal class TextBoxTests
    {
        [SetUp]

        public void SetUp()
        {
            Driver.SetupDriver();
            TextBox.Open();
        }
        [Test]

        public void FillTextBoxes()
        {
            string expectedResult = "Name:Monika Balandyte\r\nEmail:m.balandyte@gmail.com\r\nCurrent Address :Gatves 24-2, Vilnius\r\nPermananet Address :Gatves 24-2, Vilnius";
            string fullName = "Monika Balandyte";
            string email = "m.balandyte@gmail.com";
            string currentAddress = "Gatves 24-2, Vilnius";
            string permanentAddress = "Gatves 24-2, Vilnius";

            TextBox.EnterFullName(fullName);
            TextBox.EnterEmail(email);
            TextBox.EnterCurrentAddress(currentAddress);
            TextBox.EnterPermanentAddress(permanentAddress);
            //Driver.ExecuteJavaScript("window.scrollBy(0,800)");
            TextBox.ClickButtonSubmit();
            string actualResult = TextBox.GetOutputMessage();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TearDown]

        public void TearDown()
        {
           //Driver.CloseDriver();
        }
    }
}
