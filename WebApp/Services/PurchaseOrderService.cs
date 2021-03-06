using WebApp.Domain;
using WebApp.Repositories;

namespace WebApp.Services
{
   public class PurchaseOrderService : IPurchaseOrderService
   {
      public PurchaseOrderService(IPurchaseOrderRepository repository)
      {
         _purchaseOrderRepository = repository;
      }

      public PurchaseOrder CreatePO()
      {
         var newOrder = new PurchaseOrder();
         _purchaseOrderRepository.Save(newOrder);
         return newOrder;
      }

      private readonly IPurchaseOrderRepository _purchaseOrderRepository;
   }
}
