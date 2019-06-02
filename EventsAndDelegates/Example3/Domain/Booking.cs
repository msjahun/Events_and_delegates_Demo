using System;
using System.Collections.Generic;
using System.Text;

namespace EventsAndDelegates.Example3.Domain
{
    class Booking : BaseEntity
    {
        public string NameOfProperty { get; set; }
        public DateTime BookingDate { get; set; }
    }
}
