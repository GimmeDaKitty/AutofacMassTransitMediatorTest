using System.Threading.Tasks;
using AutofacMassTransitMediatorTest.Infrastructure.Api.Messages;
using MassTransit;

namespace AutofacMassTransitMediatorTest.Hardware.Consumers
{
    public sealed class HardwareConsumer : IConsumer<IPrintReceiptMessage>,
        IConsumer<IAnotherMessage>
    {
        
        public Task Consume(ConsumeContext<IPrintReceiptMessage> context)
        {
            throw new System.NotImplementedException();
        }

        public Task Consume(ConsumeContext<IAnotherMessage> context)
        {
            throw new System.NotImplementedException();
        }
    }
}