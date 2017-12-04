using System.IO;
using HotelReservation.Utils;
using NUnit.Framework;

namespace HotelReservationTest
{
    [TestFixture]
    public class FileUtilTests
    {
        [Test]
        public void ReadLinesFromFile()
        {
            string[] lines =
            {
                "Regular: 16Mar2009(mon), 17Mar2009(tues), 18Mar2009(wed)",
                "Regular: 20Mar2009(fri), 21Mar2009(sat), 22Mar2009(sun)",
                "Rewards: 26Mar2009(thur), 27Mar2009(fri), 28Mar2009(sat)"
            };
            var result = FileUtil.ReadLinesFromFile("/home/smolinacadena/Projects/HotelReservation/HotelReservation/bin/Debug/customer_dates.txt");
            Assert.AreEqual(lines, result);
        }
    }
}