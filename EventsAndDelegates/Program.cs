using System;
using System.Reflection;
using EventsAndDelegates.Example2;
using EventsAndDelegates.Example3;
using EventsAndDelegates.Example3.Domain;
using EventsAndDelegates.Example3.DomainEvent;

namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            //var Video = new Video() { Title = "Video 1" };
            //var VideoEncoder = new VideoEncoder(); //publisher
            //var mailService = new MailService(); //subscriber
            //var _messageService = new MessageService();// 2nd subscriber;

            //VideoEncoder.VideoEncodedEvent += mailService.OnVideoEncoded;
            //VideoEncoder.VideoEncodedEvent += _messageService.OnVideoEncodedWithSameParams;
            ////subscribe to an event

            //VideoEncoder.Encode(Video);

            ////unsubscribe to events
            //VideoEncoder.VideoEncodedEvent -= mailService.OnVideoEncoded;
            //VideoEncoder.Encode(Video);



            //Console.WriteLine("**************End of Example 1");
            //Console.WriteLine("Example 2:*********************");

            //var user = new User() { Id = 123, UserName = "msjahun" };
            //var _userService = new UserService();//publisher
            //var _notificationService = new NotificationService();//subscriber

            ////subscribe
            //_userService.UserInsertEvent += _notificationService.OnInsertUser;
            //_userService.UserInsertEvent += _notificationService.OnInsertUser;
            //_userService.UserInsertEvent += _notificationService.OnInsertUser;
            //_userService.UserDeleteEvent += _notificationService.OnDeleteUser;
            //_userService.UserUpdateEvent += _notificationService.OnUpdateUser;


            //_userService.InsertUser(user);
            //_userService.EditUser(user);
            //_userService.DeleteUser(user);


            Console.WriteLine("************ End of Example 2");
            Console.WriteLine("Example 3: ******************");


     
            var _eventPublisherBooking = new EventPublisher<Booking>();//publisher //will register this in dependency injection container
            var _eventPublisherBookingNonEvent = new EventPublisher<Booking>();//publisher //will register this in dependency injection container
            var _eventPublisherReview = new EventPublisher<Review>();//publisher //will register this in dependency injection container
            var _eventPublisherAnnouncement = new EventPublisher<Announcement>();//publisher //will register this in dependency injection container

            var _textMessageService = new TextMessageService();//subscriber


        

            //subscribe
            for (int i = 0; i < 10; i++)
            {

                //subscribe to events
                //register them in startup.cs and make sure they are invoked on start of project
                _eventPublisherBooking.UpdateEvent += _textMessageService.OnUpdateBooking;
                _eventPublisherBooking.InsertEvent += _textMessageService.OnInsertBooking;
                _eventPublisherReview.InsertEvent += _textMessageService.OnInsertReview;
                _eventPublisherAnnouncement.DeleteEvent += _textMessageService.OnDeleteAnnouncement;



                //events occur here
                _eventPublisherBookingNonEvent.Edit(new Booking() { Id = 9923434, BookingDate = DateTime.Now, NameOfProperty = "NonEventAlfam Noah Hotel" });


            _eventPublisherBooking.Edit(new Booking() { Id = 23434, BookingDate = DateTime.Now, NameOfProperty = "Alfam Noah Hotel" });
            _eventPublisherBooking.Insert(new Booking() { Id = 23434, BookingDate = DateTime.Now, NameOfProperty = "Alfam Noah Hotel" });
            _eventPublisherBooking.Insert(new Booking() { Id = 23434, BookingDate = DateTime.Now, NameOfProperty = "Alfam Noah Hotel" });
              
            _eventPublisherReview.Insert(new Review() { Id = 34234, ReviewText = "I like this product", CreatedOn = DateTime.Now });
           // _eventReviewService.Edit(new Review() { Id = 34234, ReviewText = "I like this product", CreatedOn = DateTime.Now });
            _eventPublisherAnnouncement.Delete(new Announcement() { Id = 2343, NameOfAnnouncer = "Musa Jahun", AnnouncedMessage = "Hello world announced officially", CreatedOn = DateTime.Now });


                

            }


        }

   
    }
}
