using System.Collections.Generic;
using HotelReservation.Enums;
using HotelReservation.Parsers;
using HotelReservation.Utils;
using NUnit.Framework;

namespace HotelReservationTest
{
    [TestFixture]
    public class InputParserTests
    {
        [Test]
        public void ParseRegularCustomerTest()
        {
            HotelUtil.Initialize();
            string[] lines =
            {
                "Regular: 16Mar2009(mon), 17Mar2009(tues), 18Mar2009(wed)"
            };
            InputParser.Parse(lines);
            Assert.AreEqual(CustomerType.Regular, CustomerUtil.Type);
        }
        
        [Test]
        public void ParseRewardsCustomerTest()
        {
            HotelUtil.Initialize();
            string[] lines =
            {
                "Rewards: 16Mar2009(mon), 17Mar2009(tues), 18Mar2009(wed)"
            };
            InputParser.Parse(lines);
            Assert.AreEqual(CustomerType.Rewards, CustomerUtil.Type);
        }
    }
}