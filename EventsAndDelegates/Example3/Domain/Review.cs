using System;
using System.Collections.Generic;
using System.Text;

namespace EventsAndDelegates.Example3.Domain
{
   public class Review : BaseEntity
    {
        public string ReviewText { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
