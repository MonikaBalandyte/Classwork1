

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

        [TearDown]

        public void TearDown()

        {
            Driver.CloseDriver();
        }
    }
}
