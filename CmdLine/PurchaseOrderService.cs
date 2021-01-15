namespace CmdLine
{
   public class PurchaseOrderService
   {
      public PurchaseOrderService()
      {
         _purchaseOrderRepository = new PurchaseOrderRepository();
      }

      public PurchaseOrder CreatePO()
      {
         var newOrder = new PurchaseOrder();
         _purchaseOrderRepository.Save(newOrder);
         return newOrder;
      }

      private readonly PurchaseOrderRepository _purchaseOrderRepository;
   }
}
