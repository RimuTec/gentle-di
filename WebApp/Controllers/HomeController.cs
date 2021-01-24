using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApp.Models;
using WebApp.Services;

namespace WebApp.Controllers
{
   public class HomeController : Controller
   {
      public HomeController(ILogger<HomeController> logger, IPurchaseOrderService purchaseOrderService)
      {
         _logger = logger;
         _purchaseOrderService = purchaseOrderService;
      }

      public IActionResult Index()
      {
         return View();
      }

      public IActionResult Privacy()
      {
         return View();
      }

      public IActionResult Post()
      {
         _purchaseOrderService.CreatePO();
         return View();
      }

      [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
      public IActionResult Error()
      {
         return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
      }

      private readonly ILogger<HomeController> _logger;
      private readonly IPurchaseOrderService _purchaseOrderService;
   }
}
