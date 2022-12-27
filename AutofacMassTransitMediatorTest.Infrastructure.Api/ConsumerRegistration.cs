using System;
using MassTransit;

namespace AutofacMassTransitMediatorTest.Infrastructure.Api
{
    public sealed class ConsumerRegistration
    {
        public ConsumerRegistration(Action<IMediatorRegistrationConfigurator> registrationAction, Type type)
        {
            RegistrationAction = registrationAction;
            Type = type;
        }

        public Action<IMediatorRegistrationConfigurator>  RegistrationAction { get; }
        public Type Type { get; }
        
    }
}