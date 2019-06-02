using EventsAndDelegates.Example3.Domain;
using EventsAndDelegates.Example3.DomainEvent;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventsAndDelegates.Example3
{
    class TextMessageService
    {

        //consumer with same parameter
        public void OnUpdateBooking(Object source, TEventArgs<Booking> _T)
        {
            Console.WriteLine("Sending Text Message about bookingUpdate  of Property:{0} on BookingDate:{1}......", _T.Entity.NameOfProperty, _T.Entity.BookingDate);
            Console.WriteLine("\n");
        }

        public void OnInsertBooking(Object source, TEventArgs<Booking> _T)
        {
            Console.WriteLine("Sending Text Message about booking Insert of Property:{0} on BookingDate:{1}......", _T.Entity.NameOfProperty, _T.Entity.BookingDate);
            Console.WriteLine("\n");
        }

        public void OnInsertReview(Object source, TEventArgs<Review> _T)
        {
            Console.WriteLine("Sending Text Message on Review Insert With Id:{0} and ReviewText: {1}......", _T.Entity.Id, _T.Entity.ReviewText);
            Console.WriteLine("\n");

        }


        public void OnDeleteAnnouncement(Object source, TEventArgs<Announcement> _T)
        {
            Console.WriteLine("Sending Text Message on about announcement delete with {0} {1} {2} {3} ......", _T.Entity.Id, _T.Entity.NameOfAnnouncer, _T.Entity.AnnouncedMessage, _T.Entity.CreatedOn.ToString());
            Console.WriteLine("\n");
        }
    }
}
