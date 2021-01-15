namespace CmdLine
{
   public class PurchaseOrderController
   {
      public PurchaseOrderController()
      {
         _purchaseOrderService = new PurchaseOrderService();
      }

      public void Post(/* parameters from HTTP request here */)
      {
         _purchaseOrderService.CreatePO();
      }

      // Other members left out for brevity

      private readonly PurchaseOrderService _purchaseOrderService;
   }
}
