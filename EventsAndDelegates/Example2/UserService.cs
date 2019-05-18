using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EventsAndDelegates.Example2
{
    class UserService
    {
        //define our publisher, delegates and events
        //3 one for edit user and other for delete user, insert user

        //delegate
        //event of delegate
        //publisher event

      
        public EventHandler<UserEventArgs> UserInsertEvent;
        public EventHandler<UserEventArgs> UserDeleteEvent;
        public EventHandler<UserEventArgs> UserUpdateEvent;

        public void InsertUser(User user)
        {
            Thread.Sleep(3000);
            Console.WriteLine("Inserting user with Id:{0}, UserName:{1}.....",user.Id,user.UserName);
            OnUserInsertEvent(user);
        }

        public void DeleteUser(User user)
        {
            Thread.Sleep(3000);
            Console.WriteLine("Deleting user with Id:{0}, UserName:{1}......", user.Id, user.UserName);
            OnUserDeleteEvent(user);

        }

        public void EditUser (User user)
        {
            Thread.Sleep(3000);
            Console.WriteLine("Updating user with Id:{0}, UserName:{1}......", user.Id, user.UserName);
            OnUserUpdateEvent(user);

        }

        protected virtual void OnUserInsertEvent(User _user)
        {
            //checks if there are subscribers

            if (UserInsertEvent != null)
                UserInsertEvent(this, new UserEventArgs { user = _user });
            
        }

        protected virtual void OnUserDeleteEvent(User _user)
        {
            if (UserDeleteEvent != null)
                UserDeleteEvent(this, new UserEventArgs { user = _user });
        }
        

        protected virtual void OnUserUpdateEvent(User _user)
        {
            if (UserUpdateEvent != null)
                UserUpdateEvent(this, new UserEventArgs { user = _user });
        }

    }
}
