using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text.RegularExpressions;
using HotelReservation.Enums;
using HotelReservation.Utils;

namespace HotelReservation.Parsers
{
    public static class InputParser
    {
        private const string _inputRegex = 
            @"(?<customer_type>Regular|Rewards):\s+(?<customer_dates>([0-9]{2}[a-zA-Z]{3}[0-9]{4}\([a-zA-Z]{3,4}\),\s)*[0-9]{2}[a-zA-Z]{3}[0-9]{4}\([a-zA-Z]{3,4}\))\n?";
        private static Match _lineMatch;
        
        public static void Parse(IEnumerable<string> lines)
        {
            foreach (var line in lines)
            {
                Console.WriteLine(line);
                _lineMatch = Regex.Match(line, _inputRegex);
                if (_lineMatch.Success)
                {
                    if (_lineMatch.Groups["customer_type"].Value.Equals("Regular"))
                    {
                        CustomerUtil.Type = CustomerType.Regular;
                    }
                    else if (_lineMatch.Groups["customer_type"].Value.Equals("Rewards"))
                    {
                        CustomerUtil.Type = CustomerType.Rewards;
                    }
                    DateParser.ParseRawDates(_lineMatch.Groups["customer_dates"].Value);
                    HotelUtil.GetCheapestAvailableHotel();
                }
                else
                {
                    Console.WriteLine("The input provided is not well formatted.");
                    Environment.Exit(13);
                }
            }
        }
    }
}