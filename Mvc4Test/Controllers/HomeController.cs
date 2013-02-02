using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;

using Mvc4Test.Models;

namespace Mvc4Test.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Jump Start.";

            return View();
        }

        public ActionResult Bookings_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(GetBookingDtos().ToDataSourceResult(request));
        }

        private static IEnumerable<BookingDto> GetBookingDtos()
        {
            var bookings = GetBookingRecords().Select(b => new BookingDto
            {
                BookingID = b.BookingID,
                BookingDate = b.BookingDate,
                ReleaseDate = b.ReleaseDate,
                BookingDateString = b.BookingDate.ToString("MM/dd/yyyy HH:mm"),
                ReleaseDateString = b.ReleaseDate.HasValue ? b.ReleaseDate.Value.ToString("MM/dd/yyyy HH:mm") : string.Empty
            });

            return bookings;
        }

        private static IEnumerable<BookingRecord> GetBookingRecords()
        {
            var bookings = new List<BookingRecord>() 
                {
                    new BookingRecord(){ BookingID = 1, BookingDate = DateTimeOffset.Now, ReleaseDate = DateTimeOffset.UtcNow},
                    new BookingRecord(){ BookingID = 2, BookingDate = DateTimeOffset.Now, ReleaseDate = DateTimeOffset.UtcNow},
                    new BookingRecord(){ BookingID = 3, BookingDate = DateTimeOffset.Now, ReleaseDate = null},
                    new BookingRecord(){ BookingID = 4, BookingDate = DateTimeOffset.Now, ReleaseDate = DateTimeOffset.UtcNow},
                    new BookingRecord(){ BookingID = 5, BookingDate = DateTimeOffset.Now, ReleaseDate = DateTimeOffset.UtcNow},
                    new BookingRecord(){ BookingID = 6, BookingDate = DateTimeOffset.Now, ReleaseDate = DateTimeOffset.UtcNow},
                    new BookingRecord(){ BookingID = 7, BookingDate = DateTimeOffset.Now, ReleaseDate = null},
                    new BookingRecord(){ BookingID = 8, BookingDate = DateTimeOffset.Now, ReleaseDate = DateTimeOffset.UtcNow},
                    new BookingRecord(){ BookingID = 9, BookingDate = DateTimeOffset.Now, ReleaseDate = DateTimeOffset.UtcNow},
                    new BookingRecord(){ BookingID = 10, BookingDate = DateTimeOffset.Now, ReleaseDate = null},
                    new BookingRecord(){ BookingID = 11, BookingDate = DateTimeOffset.Now, ReleaseDate = null},
                    new BookingRecord(){ BookingID = 12, BookingDate = DateTimeOffset.Now, ReleaseDate = DateTimeOffset.UtcNow}
                };

            return bookings;
        }

        public ActionResult About()
        {
            ViewBag.Message = "About.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
