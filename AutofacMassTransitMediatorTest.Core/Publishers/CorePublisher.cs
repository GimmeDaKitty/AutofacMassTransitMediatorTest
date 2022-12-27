using System;
using System.Threading.Tasks;
using MassTransit.Mediator;

namespace AutofacMassTransitMediatorTest.Core.Publishers
{
    // TODO - register in DI
    public sealed class CorePublisher<TEventMessageInterface> : IDisposable
        where TEventMessageInterface : class
    {
        private readonly IMediator _mediator;

        public CorePublisher(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        public async Task Publish(TEventMessageInterface  message)
        {
            await _mediator.Publish(message);
        }
        
        public void Dispose()
        {
        }
    }
}