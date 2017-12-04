namespace HotelReservation.Models
{
    public class Reservation
    {
        public int Rate;
        public Hotel Hotel;

        public Reservation(int rate, Hotel hotel)
        {
            Rate = rate;
            Hotel = hotel;
        }
    }
}