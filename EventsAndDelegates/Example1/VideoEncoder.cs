using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EventsAndDelegates
{
    class VideoEncoder
    {

        // 1- Define a delegate
        // 2- Define an event based on that delegate
        // 3- Raise the event

        public delegate void VideoEncodedEventHandler(Object source, EventArgs args);
        //Delegate which determines the shape or signature of the subscriber

        public event VideoEncodedEventHandler VideoEncodedEvent;
        //Create event based on that delegate
      public void Encode(Video video)
        {


            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            OnVideoEncoded();
            //raising the event
        }

        protected virtual void OnVideoEncoded()
        {// event publisher methods should be protected virtual void

            if (VideoEncodedEvent != null)
                VideoEncodedEvent(this, EventArgs.Empty);

        }
    }
}
