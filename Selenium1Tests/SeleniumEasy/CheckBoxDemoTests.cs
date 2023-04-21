

using NUnit.Framework;
using SeleniumFramework;
using SeleniumFramework.Pages.SeleniumEasy;

namespace Selenium1Tests.SeleniumEasy
{
    internal class CheckBoxDemoTests
    {
        [SetUp]

        public void SetUp()
        {
            Driver.SetupDriver();
            CheckBoxDemo.Open();
        }
        [Test]

        public void SingleCheckbox()
        {
            string expectedMessage = "Success - Check box is checked";

            CheckBoxDemo.ClickSingleCheckbox();
            string actualResult = CheckBoxDemo.GetSingleCheckBoxSuccessMessage();

            Assert.AreEqual(expectedMessage, actualResult);
        }
        [Test]

        public void MultipleCheckbox()
        {
            string expectedButtonText = "Uncheck All";

            CheckBoxDemo.ClickEachOfMultipleCheckboxes();
            string actualButtonText = CheckBoxDemo.GetMultipleCheckboxButtonText();

            Assert.AreEqual(expectedButtonText, actualButtonText);
        }

        [TearDown]

        public void TearDown()

        {
            Driver.CloseDriver();
        }
    }
}
