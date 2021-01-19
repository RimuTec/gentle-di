namespace CmdLine
{
   public class PurchaseOrderController
   {
      public PurchaseOrderController(IPurchaseOrderService service)
      {
         _purchaseOrderService = service;
      }

      public void Post(/* parameters from HTTP request here */)
      {
         _purchaseOrderService.CreatePO();
      }

      // Other members left out for brevity

      private readonly IPurchaseOrderService _purchaseOrderService;
   }
}
