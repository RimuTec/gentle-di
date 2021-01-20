using Autofac;

namespace CmdLine
{
   internal static class Program
   {
      private static void Main(string[] args)
      {
         IContainer provider = ConfigureContainer();
         SimulatePostRequest(provider);
      }

      public static void SimulatePostRequest(IContainer provider)
      {
         using var scope = provider.BeginLifetimeScope();
         var controller = scope.Resolve<PurchaseOrderController>();
         controller.Post();
      }

      public static IContainer ConfigureContainer()
      {
         var builder = new ContainerBuilder();
         builder.RegisterType<PurchaseOrderRepository>().As<IPurchaseOrderRepository>();
         builder.RegisterType<PurchaseOrderService>().As<IPurchaseOrderService>();
         builder.RegisterType<PurchaseOrderController>();
         return builder.Build();
      }
   }
}
