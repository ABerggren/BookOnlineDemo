namespace BookOnline
{
    public class SearchResult
    {
        public int totalHits { get; set; }
        public int totalDocuments { get; set; }
        public List<Booking> bookings { get; set; }

    }
}
