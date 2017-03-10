using System;

namespace NewStuff.ReadSide
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Street1 { get; set; }
        public string City { get; set; }
    }
}