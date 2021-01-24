using WebApp.Domain;

namespace WebApp.Repositories
{
   public interface IPurchaseOrderRepository
   {
      void Save(PurchaseOrder order);
   }
}
