
using NUnit.Framework;
using SeleniumFramework;
using SeleniumFramework.Pages.SeleniumEasy1;

namespace Selenium1Tests.SeleniumEasy
{
    internal class SimpleFormDemoTests
    {
        [SetUp]

        public void SetUp()
        {
            Driver.SetupDriver();
            SimpleFormDemo.Open();
        }

        [Test]

        public void SingleInputField()
        {
            string expectedResult = "Test";

            SimpleFormDemo.EnterMessage(expectedResult);
            SimpleFormDemo.ClickShowMessageButton();
            string actualResult = SimpleFormDemo.GetSingleInputFieldMessage();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]

        public void TwoInputFields()
        {
            string expectedResult = "3";
            string inputAvalue = "1";
            string inputBvalue = "2";


            SimpleFormDemo.EnterInputA(inputAvalue);
            SimpleFormDemo.EnterInputB(inputBvalue);
            SimpleFormDemo.ClickGetTotalButton();
            string actualResult = SimpleFormDemo.GetTwoInputFieldsMessages();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TearDown]

        public void TearDown()
        {
            Driver.CloseDriver();
        }

    }
}
