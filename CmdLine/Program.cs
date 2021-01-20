using System;
using Microsoft.Extensions.DependencyInjection;

namespace CmdLine
{
   internal static class Program
   {
      private static void Main(string[] args)
      {
         IServiceCollection services = new ServiceCollection();
         IServiceProvider provider = ConfigureServices(services);
         SimulatePostRequest(provider);
      }

      public static void SimulatePostRequest(IServiceProvider provider)
      {
         var controller = provider.GetRequiredService<PurchaseOrderController>();
         controller.Post();
      }

      public static IServiceProvider ConfigureServices(IServiceCollection serviceCollection)
      {
         serviceCollection.AddScoped<IPurchaseOrderRepository, PurchaseOrderRepository>();
         serviceCollection.AddScoped<IPurchaseOrderService, PurchaseOrderService>();
         serviceCollection.AddScoped<PurchaseOrderController, PurchaseOrderController>();
         return serviceCollection.BuildServiceProvider();
      }
   }
}
