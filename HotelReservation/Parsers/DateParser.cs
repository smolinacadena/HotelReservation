using System;
using System.Collections.Generic;
using System.Globalization;
using HotelReservation.Utils;

namespace HotelReservation.Parsers
{
    public static class DateParser
    {
        
        public static void ParseRawDates(string rawDates)
        {
            CustomerUtil.Dates.Clear();
            foreach (var date in rawDates.Split(','))
            {
                CustomerUtil.Dates.Add(DateTime.ParseExact(date.Split('(')[0].Trim(), "ddMMMyyyy", CultureInfo.InvariantCulture));
            }
        }
    }
}