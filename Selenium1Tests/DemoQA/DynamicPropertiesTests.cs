

using NUnit.Framework;
using SeleniumFramework;
using SeleniumFramework.Pages.DemoQA;

namespace Selenium1Tests.DemoQA
{
    public class DynamicPropertiesTests
    {
        [SetUp]

        public void SetUp() 
        {
            Driver.SetupDriver();
            DynamicProperties.Open();
        }
        [Test]
        public void WaitForButtonToBeClickable()
        {
           // DynamicProperties.WaitForButtonToBeClickable();
            Assert.IsTrue(DynamicProperties.WaitForButtonToBeClickable()); 
        }
        
        
        [TearDown]

        public void TearDown() 
        {
            Driver.CloseDriver();
        }
    }
}
