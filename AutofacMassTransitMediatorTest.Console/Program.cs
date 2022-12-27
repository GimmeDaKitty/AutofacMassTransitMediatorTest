
using System.Threading.Tasks;
using AutofacMassTransitMediatorTest.Infrastructure;

namespace AutofacMassTransitMediatorTest.Console
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            var workerService = new WorkerService();

            await workerService.StartAsync();
            await workerService.StopAsync();
        }
    }
}