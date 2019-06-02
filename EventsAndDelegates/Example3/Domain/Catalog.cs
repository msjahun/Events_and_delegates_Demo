using System;
using System.Collections.Generic;
using System.Text;

namespace EventsAndDelegates.Example3.Domain
{
    class Catalog : BaseEntity
    {
        public string NameOfItem { get; set; }
        public int Quantity { get; set; }
    }
}
