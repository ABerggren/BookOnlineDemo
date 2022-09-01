using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BookOnline.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookingController : ControllerBase
    {
        private readonly ILogger<BookingController> _logger;

        public BookingController(ILogger<BookingController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetBookingList")]
        public List<Booking> Get(string criteria)
        {
            List<Booking>? BookingsList = new List<Booking>();
            List<Booking> FilteredList = new List<Booking>();

            using (StreamReader r = new StreamReader("data.json"))
            {
                string json = r.ReadToEnd();
                BookingsList = JsonConvert.DeserializeObject<List<Booking>>(json);

                FilteredList = BookingsList.Where(p => p.name.ToUpper().Contains(criteria.ToUpper())).ToList();
            }

            return FilteredList;
        }
    }
}