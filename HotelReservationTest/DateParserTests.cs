using System;
using HotelReservation.Parsers;
using HotelReservation.Utils;
using NUnit.Framework;

namespace HotelReservationTest
{
    [TestFixture]
    public class DateParserTests
    {
        [Test]
        public void CheckParsedDates()
        {
            DateParser.ParseRawDates("31Aug1992(mon),  05Dec2015(tues),   22Sep2012(wed)");
            Assert.IsNotEmpty(CustomerUtil.Dates);
            Assert.Contains(new DateTime(1992,08,31), CustomerUtil.Dates);
            Assert.Contains(new DateTime(2015,12,05), CustomerUtil.Dates);
            Assert.Contains(new DateTime(2012,09,22), CustomerUtil.Dates);
        }
    }
}