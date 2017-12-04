using System;
using System.Collections.Generic;
using System.Linq;
using HotelReservation.Enums;
using HotelReservation.Models;

namespace HotelReservation.Utils
{
    public class HotelUtil
    {
        private static List<Hotel> Hotels = new List<Hotel>();
        private static List<Reservation> Reservations = new List<Reservation>();
        
        public static void GetCheapestAvailableHotel()
        {
            CreateReservations();
            var lowestRate = Reservations.Min(r => r.Rate);
            var cheapestReservation = Reservations.Where(r => r.Rate == lowestRate).OrderByDescending(r => r.Hotel.Rating).FirstOrDefault();
            Console.WriteLine(cheapestReservation != null ? cheapestReservation.Hotel.Name : "There was an error determining the best hotel for you");
        }
        
        public static void Initialize()
        {
            Hotels.Add(new Hotel("Lakewood", 3, 110, 80, 90, 80));
            Hotels.Add(new Hotel("Bridgewood", 4, 160, 110, 60, 50));
            Hotels.Add(new Hotel("Ridgewood", 5, 220, 100, 150, 40));
        }

        private static void CreateReservations()
        {
            Reservations.Clear();
            foreach (var hotel in Hotels)
            {
                Reservations.Add(new Reservation(GetHotelRate(hotel), hotel));
            }
        }

        private static int GetHotelRate(Hotel hotel)
        {
            var rate = 0;
            foreach (var date in CustomerUtil.Dates)
            {
                if (IsWeekend(date))
                {
                    if (CustomerUtil.Type == CustomerType.Regular)
                    {
                        rate += hotel.WeekendRegularRate;
                    }
                    else
                    {
                        rate += hotel.WeekendRewardsRate;
                    }
                }
                else
                {
                    if (CustomerUtil.Type == CustomerType.Regular)
                    {
                        rate += hotel.WeekdayRegularRate;
                    }
                    else
                    {
                        rate += hotel.WeekdayRewardsRate;
                    }
                }
            }
            return rate;
        }

        private static bool IsWeekend(DateTime date)
        {
            return date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;
        }
    }
}