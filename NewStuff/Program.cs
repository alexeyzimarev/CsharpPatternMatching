using System;
using System.Configuration;
using System.Threading.Tasks;
using Marten;
using MassTransit;
using NewStuff.Events;

namespace NewStuff
{
    internal class Program
    {
        public static void Main()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["postgres"].ConnectionString;
            var store = DocumentStore.For(connectionString);

            var busControl = Bus.Factory.CreateUsingInMemory(cfg =>
            {
//                cfg.ReceiveEndpoint("demo", e =>
//                {
//                    e.Consumer();
//                });
            });

            Task.WaitAll(ProjectNow(store));

            Console.WriteLine("All done");
            Console.ReadLine();
        }

        private static async Task ProjectNow(IDocumentStore store)
        {
            var projector = new CustomerProjection(store);

            await projector.Project(new CustomerAdded {Id = Guid.NewGuid(), Name = "Alexey", City = "Larvik"});
            await projector.Project(new CustomerChangedName {Name = "John"});
            await projector.Project(new CustomerMoved {City = "Oslo"});
        }
    }
}