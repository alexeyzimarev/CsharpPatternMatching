using System;
using NewStuff.Commands;
using NewStuff.Events;

namespace NewStuff
{
    public class Customer
    {
        public Guid Id { get; }
        private string _name;

        private Customer(Guid id)
        {
            Id = id;
        }

        public void Handle(object command)
        {
            switch (command)
            {
                case AddCustomer add:
                    When(new CustomerAdded {Name = add.Name, City = add.City, Street1 = add.Street1});
                    break;
            }
        }

        public void Apply(object @event)
        {
            // add to uncommitted changes and
            When(@event);
        }

        public void When(object @event)
        {
            switch (@event)
            {
                case CustomerAdded added:
                    _name = added.Name;
                    break;
            }
        }
    }
}