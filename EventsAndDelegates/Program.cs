using System;
using EventsAndDelegates.Example2;


namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var Video = new Video() { Title = "Video 1" };
            var VideoEncoder = new VideoEncoder(); //publisher
            var mailService = new MailService(); //subscriber
            var _messageService = new MessageService();// 2nd subscriber;

            VideoEncoder.VideoEncodedEvent += mailService.OnVideoEncoded;
            VideoEncoder.VideoEncodedEvent += _messageService.OnVideoEncodedWithSameParams;
            //subscribe to an event

            VideoEncoder.Encode(Video);

            //unsubscribe to events
            VideoEncoder.VideoEncodedEvent -= mailService.OnVideoEncoded;
            VideoEncoder.Encode(Video);



            Console.WriteLine("**************End of Example 1");
            Console.WriteLine("Example 2:*********************");

            var user = new User() { Id = 123, UserName = "msjahun" };
            var _userService = new UserService();//publisher
            var _notificationService = new NotificationService();//subscriber

            //subscribe
            _userService.UserInsertEvent += _notificationService.OnInsertUser;
            _userService.UserInsertEvent += _notificationService.OnInsertUser;
            _userService.UserInsertEvent += _notificationService.OnInsertUser;
            _userService.UserDeleteEvent += _notificationService.OnDeleteUser;
            _userService.UserUpdateEvent += _notificationService.OnUpdateUser;


            _userService.InsertUser(user);
            _userService.EditUser(user);
            _userService.DeleteUser(user);

        }
    }
}
