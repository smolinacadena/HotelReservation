using System;
using System.Collections.Generic;
using HotelReservation.Parsers;
using HotelReservation.Utils;

namespace HotelReservation
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            HotelUtil.Initialize();
            var lines = FileUtil.ReadLinesFromFile(args[0]);
            InputParser.Parse(lines);
        }
    }
}