using System;
using System.Security.Cryptography.X509Certificates;
using NUnit.Framework;

namespace UnitTests
{
    internal class Homework1
    {
        [Test]
        public void CheckRemainder995DividedBy3()
        {
            int expectedResult = 0;

            int actualResult = 995 % 3;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void CheckIfTodayIsWednesday()
        {
            DateTime currentDate = DateTime.Now;

            DayOfWeek currentWeekday = currentDate.DayOfWeek;

            Assert.AreEqual(DayOfWeek.Wednesday, currentWeekday);
        }

        [Test]
        public void CheckIfNowIs13hour()
        {
            DateTime currentDate = DateTime.Now;

            int currentHour = currentDate.Hour;

            Assert.AreEqual(13, currentHour);

        }
        [Test]
        public void CheckIfFourEvenNumbersAreBetween1and10Inclusive()
        {
       
            int count = 0;
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    count++;
                }
            }

            Assert.AreEqual(4, count);
        }
    }
}

