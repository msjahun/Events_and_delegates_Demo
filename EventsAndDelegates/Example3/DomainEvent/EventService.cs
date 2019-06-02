using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EventsAndDelegates.Example3.DomainEvent
{
    class EventPublisher<T> where T : BaseEntity
    {

        public EventHandler<TEventArgs<T>> InsertEvent;
        public EventHandler<TEventArgs<T>> DeleteEvent;
        public EventHandler<TEventArgs<T>> UpdateEvent;

        public void Insert(T entity)
        {
            Thread.Sleep(3000);
            Console.WriteLine("Inserting entity {0} with Id:{1}.....", entity.GetType().Name, entity.Id);
            OnInsertEvent(entity);
        }

        public void Delete(T entity)
        {
            Thread.Sleep(3000);
            Console.WriteLine("Deleting entity {0} with Id:{1}.....", entity.GetType().Name, entity.Id);
            OnDeleteEvent(entity);

        }

        public void Edit(T entity)
        {
            Thread.Sleep(3000);
            Console.WriteLine("Updating entity {0} with Id:{1}.....", entity.GetType().Name, entity.Id);
            OnUpdateEvent(entity);

        }


        //probably insert event should be like InsertEvent<T> !=null to check specific ?? 
        //but if you subscribe once you subscribe all
        protected virtual void OnInsertEvent(T entity)
        {
            //checks if there are subscribers

            if (InsertEvent != null) { 
                InsertEvent(this, new TEventArgs<T> { Entity = entity });
                Console.WriteLine("OnInsertEvent number of listeners {0}", InsertEvent.GetInvocationList().Length);
             
            }

        }

        protected virtual void OnDeleteEvent(T entity)
        {
            if (DeleteEvent != null)
            {
                DeleteEvent(this, new TEventArgs<T> { Entity = entity });
                Console.WriteLine("OnDeleteEvent number of listeners {0}", DeleteEvent.GetInvocationList().Length);
            }
            }


        protected virtual void OnUpdateEvent(T entity)
        {
            if (UpdateEvent != null)
            {
                UpdateEvent(this, new TEventArgs<T> { Entity = entity });
                Console.WriteLine("OnUpdateEvent number of listeners {0}, ", UpdateEvent.GetInvocationList().Length);
               
            }
            }

    }
}
