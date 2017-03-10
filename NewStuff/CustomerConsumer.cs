using System.Threading.Tasks;
using MassTransit;
using NewStuff.Commands;

namespace NewStuff
{
    public class CustomerConsumer : IConsumer<AddCustomer>
    {
        public async Task Consume(ConsumeContext<AddCustomer> context)
        {
        }
    }
}