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
            // Müþteri bilgilerini oluþtur
            var customer = new Customer
            {
                Id = 1,
                FirstName = "Ahmet",
                LastName = "Yýlmaz",
                Email = "ahmet.yilmaz@example.com"
            };

            // Sipariþleri oluþtur
            var orders = new List<Order>
        {
            new Order { Id = 1, ProductName = "Laptop", Price = 5000m, Quantity = 1 },
            new Order { Id = 2, ProductName = "Phone", Price = 1500m, Quantity = 2 }
        };

            // ViewModel'i oluþtur
            var viewModel = new CustomerOrderViewModel
            {
                Customer = customer,
                Orders = orders
            };

            // View'a ViewModel gönder
            return View(viewModel);
        }
    }
}
