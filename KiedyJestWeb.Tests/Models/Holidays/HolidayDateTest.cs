using System;
using KiedyJestWeb.Models.Holidays;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KiedyJestWeb.Tests.Models.Holidays
{
    [TestClass]
    public class HolidayDateTest
    {
        [TestMethod]
        public void GetDateForCurrentYear_HappyPathTest()
        {
            DateTime now = DateTime.Now;
            var target = new HolidayDate
            {
                Year = now.Year, Month = 1, Day = 1
            };

            var result = target.GetDateForCurrentYear();
            Assert.IsNotNull(result);
            Assert.AreEqual(now.Year, result.Value.Year);
            Assert.AreEqual(1, result.Value.Month);
            Assert.AreEqual(1, result.Value.Day);
        }

        [TestMethod]
        public void GetDateForCurrentYear_BadYearTest()
        {
            DateTime now = DateTime.Now;
            var target = new HolidayDate
            {
                Year = now.Year + 1, Month = 1, Day = 1
            };

            var result = target.GetDateForCurrentYear();
            Assert.IsNull(result);
        }

        [TestMethod]
        public void GetDateForCurrentYear_NoYearTest()
        {
            DateTime now = DateTime.Now;
            var target = new HolidayDate
            {
                Month = 1,
                Day = 1
            };

            var result = target.GetDateForCurrentYear();
            Assert.IsNotNull(result);
            Assert.AreEqual(now.Year, result.Value.Year);
            Assert.AreEqual(1, result.Value.Month);
            Assert.AreEqual(1, result.Value.Day);
        }

        [TestMethod]
        public void GetDateForYear_HappyPathTest()
        {
            var target = new HolidayDate
            {
                Year = 2000,
                Month = 1,
                Day = 1
            };

            var result = target.GetDateForYear(2000);
            Assert.IsNotNull(result);
            Assert.AreEqual(2000, result.Value.Year);
            Assert.AreEqual(1, result.Value.Month);
            Assert.AreEqual(1, result.Value.Day);
        }

        [TestMethod]
        public void GetDateForYear_BadYearTest()
        {
            var target = new HolidayDate
            {
                Year = 2001,
                Month = 1,
                Day = 1
            };

            var result = target.GetDateForYear(2000);
            Assert.IsNull(result);
        }

        [TestMethod]
        public void GetDateForYear_NoYearTest()
        {
            var target = new HolidayDate
            {
                Month = 1,
                Day = 1
            };

            var result = target.GetDateForYear(2000);
            Assert.IsNotNull(result);
            Assert.AreEqual(2000, result.Value.Year);
            Assert.AreEqual(1, result.Value.Month);
            Assert.AreEqual(1, result.Value.Day);
        }
    }
}
