using System;

namespace NewStuff.Events
{
    public class CustomerChangedName : CustomerEvent
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}