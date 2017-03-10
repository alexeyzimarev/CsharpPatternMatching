using System;

namespace NewStuff.Events
{
    public interface CustomerEvent
    {
        Guid Id { get; set; }
    }
}