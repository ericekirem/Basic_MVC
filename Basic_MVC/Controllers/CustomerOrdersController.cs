using Basic_MVC.Models;
using Basic_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Basic_MVC.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            // M��teri bilgilerini olu�tur
            var customer = new Customer
            {
                Id = 1,
                FirstName = "Ahmet",
                LastName = "Y�lmaz",
                Email = "ahmet.yilmaz@example.com"
            };

            // Sipari�leri olu�tur
            var orders = new List<Order>
        {
            new Order { Id = 1, ProductName = "Laptop", Price = 5000m, Quantity = 1 },
            new Order { Id = 2, ProductName = "Phone", Price = 1500m, Quantity = 2 }
        };

            // ViewModel'i olu�tur
            var viewModel = new CustomerOrderViewModel
            {
                Customer = customer,
                Orders = orders
            };

            // View'a ViewModel g�nder
            return View(viewModel);
        }
    }
}
