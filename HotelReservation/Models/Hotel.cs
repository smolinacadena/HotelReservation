namespace HotelReservation.Models
{
    public class Hotel
    {
        public string Name;
        public int Rating;
        public int WeekdayRegularRate;
        public int WeekendRegularRate;
        public int WeekdayRewardsRate;
        public int WeekendRewardsRate;

        public Hotel(string name, int rating, int weekdayRegularRate, int weekdayRewardsRate, int weekendRegularRate, int weekendRewardsRate)
        {
            Name = name;
            Rating = rating;
            WeekdayRegularRate = weekdayRegularRate;
            WeekendRegularRate = weekendRegularRate;
            WeekdayRewardsRate = weekdayRewardsRate;
            WeekendRewardsRate = weekendRewardsRate;
        }
    }
}