using System;
using System.Collections.Generic;
using System.Text;

namespace EventsAndDelegates.Example2
{
    class NotificationService
    {
        //consumer with same parameter
        public void OnUpdateUser(Object source, UserEventArgs eventArgs)
        {
            Console.WriteLine("Sending notification about UserUpdate {0}{1}......", eventArgs.user.Id, eventArgs.user.UserName);
        }

        public void OnInsertUser(Object source, UserEventArgs eventArgs)
        {
            Console.WriteLine("Sending notification about Inserting new user {0}{1}......", eventArgs.user.Id, eventArgs.user.UserName);


        }


        public void OnDeleteUser (Object source, UserEventArgs eventArgs)
        {
            Console.WriteLine("Sending notification about deleted user {0}{1}......", eventArgs.user.Id, eventArgs.user.UserName);
        }
    }
}
