using System;
using System.Collections.Generic;
using System.Text;

namespace EventsAndDelegates
{
    class MailService
    {
        public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("Sending Mail from the mail Service...");
        }
    }
}
