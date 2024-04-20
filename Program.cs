using Microsoft.Extensions.DependencyInjection;

namespace DITTestCs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = ServiceProviderBuilder.BuildServiceProvider();
            IGreetingService? greetingService = serviceProvider.GetService<IGreetingService>();

            
            greetingService?.Greet("MinhChau");
            Console.ReadKey();
        }
    }
}
