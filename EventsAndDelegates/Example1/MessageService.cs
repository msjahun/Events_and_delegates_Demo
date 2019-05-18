using System;
using System.Collections.Generic;
using System.Text;

namespace EventsAndDelegates
{
    class MessageService
    {

       public void OnVideoEncodedWithSameParams(Object source, EventArgs args)
        {
            Console.WriteLine("Testing events consumption");
        }
    }
}
