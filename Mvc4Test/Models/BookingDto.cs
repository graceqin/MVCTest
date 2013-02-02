using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc4Test.Models
{
    public class BookingDto
    {
        public int BookingID { get; set; }
        public string BookingDateString { get; set; }
        public DateTimeOffset BookingDate { get; set; }
        public string ReleaseDateString { get; set; }
        public DateTimeOffset? ReleaseDate { get; set; }
    }
}