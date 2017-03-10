using System;

namespace NewStuff.Events
{
    public class CustomerMoved : CustomerEvent
    {
        public Guid Id { get; set; }
        public string Street1 { get; set; }
        public string City { get; set; }
    }
}