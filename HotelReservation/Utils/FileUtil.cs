using System;
using System.Collections.Generic;
using System.IO;

namespace HotelReservation.Utils
{
    public static class FileUtil
    {
        private static string[] _lines;
        
        public static IEnumerable<string> ReadLinesFromFile(string rawData)
        {
            try
            {
                _lines = File.ReadAllLines(rawData);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File not found. Provide the correct path.");
                Environment.Exit(2);
            }
            return _lines;
        }
    }
}