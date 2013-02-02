using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc4Test.Models
{
    public class BookingRecord
    {
        public int BookingID { get; set; }
        public DateTimeOffset BookingDate { get; set; }
        public DateTimeOffset? ReleaseDate { get; set; }
    }
}