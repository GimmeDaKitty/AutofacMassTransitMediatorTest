using System;

namespace AutofacMassTransitMediatorTest.Infrastructure.Api.Messages
{
    public sealed class PrintReceiptMessage : IPrintReceiptMessage
    {
        public PrintReceiptMessage(string receipt)
        {
            Receipt = receipt ?? throw new ArgumentNullException(nameof(receipt));
        }
        public string Receipt { get; }
    }
}