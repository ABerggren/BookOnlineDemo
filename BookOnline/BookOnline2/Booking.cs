namespace BookOnline
{
    public class Booking
    {
        public int id { get; set; }
        public string? name { get; set; }
        public Location? position { get; set; }
        public int distance { get; set; }
        public int score { get; set; }
    }
}