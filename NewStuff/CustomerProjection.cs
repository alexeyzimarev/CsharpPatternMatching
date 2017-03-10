using System;
using System.Threading.Tasks;
using Marten;
using NewStuff.Events;

namespace NewStuff
{
    public class CustomerProjection
    {
        private readonly IDocumentStore _store;

        public CustomerProjection(IDocumentStore store)
        {
            _store = store;
        }

        public async Task Project(CustomerEvent @event)
        {
            var session = _store.LightweightSession();
            var doc = !(@event is CustomerAdded)
                ? await session.LoadAsync<ReadSide.Customer>(@event.Id)
                : null;

            switch (@event)
            {
                case CustomerAdded added:
                    doc = new ReadSide.Customer
                    {
                        Id = added.Id,
                        Name = added.Name,
                        City = added.City,
                        Street1 = added.Street1
                    };
                    Console.WriteLine($"Added {added.Name}");
                    break;
                case CustomerChangedName changedName:
                    doc.Name = changedName.Name;
                    Console.WriteLine($"Changed name to {changedName.Name}");
                    break;
                case CustomerMoved moved:
                    doc.City = moved.City;
                    doc.Street1 = moved.Street1;
                    Console.WriteLine($"Moved to {moved.City}");
                    break;
                default:
                    throw new InvalidOperationException("Unknown event type");
            }
            session.Store(doc);
            await session.SaveChangesAsync();
        }
    }
}