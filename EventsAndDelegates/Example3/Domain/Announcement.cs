using System;
using System.Collections.Generic;
using System.Text;

namespace EventsAndDelegates.Example3.Domain
{
   public class Announcement: BaseEntity
    {
        public string AnnouncedMessage { get; set; }
        public string NameOfAnnouncer { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
