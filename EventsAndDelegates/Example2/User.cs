using System;
using System.Collections.Generic;
using System.Text;

namespace EventsAndDelegates.Example2
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
    }

    public class UserEventArgs: EventArgs
    {
        public User user { get; set; }
    }
}
