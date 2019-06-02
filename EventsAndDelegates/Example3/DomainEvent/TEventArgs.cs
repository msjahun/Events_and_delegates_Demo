using System;

namespace EventsAndDelegates.Example3.DomainEvent
{
    public class TEventArgs<T> : EventArgs where T : BaseEntity
    {
        public T Entity { get; set; }
    }
}
