using ASPNetCoreIntro.Entities;
using ASPNetCoreIntro.Models;
using ASPNetCoreIntro.Services.Logging;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreIntro.Controllers
{
    [Route(template: "deneme")]
    public class CustomerController : Controller
    {
        private ILogger _logger;

        public CustomerController(ILogger logger)
        {
            _logger = logger;
        }
        //HTTP GET
        [Route(template: "index")]
        [Route(template: "")]
        [Route(template: "~/anasayfa")] //başı önemli değil sonrası anasayfa olucak
        public IActionResult Index3()
        {
            _logger.Log("");
            List<Customer> customers = new List<Customer>
            {
                new Customer{Id=1, FirstName="Emre",LastName="Gündoğdu", City="Eskişehir"},
                new Customer{Id=2, FirstName="Derin",LastName="Gündoğdu", City="Eskişehir"},
                new Customer{Id=3, FirstName="Yaren",LastName="Gündoğdu", City="Eskişehir"}
            };
            List<string> shops = new List<string> { "Ankara", "İstanbul", "İzmir" };
            var model = new CustomerListViewModel
            {
                Customers = customers,
                Shops = shops
            };
            return View(customers);
        }

        [HttpGet]
        [Route(template: "save")]
        public IActionResult SaveCustomer()
        {
            return View(new SaveCustomerViewModel
            {
                Cities = new List<SelectListItem>
                {
                    new SelectListItem{Text="Ankara",Value="06"},
                    new SelectListItem{Text="Eskişehir",Value="26"},
                    new SelectListItem{Text="İstanbul",Value="34"}
                }
            });
        }

        [HttpPost]
        [Route(template: "save")]
        public string SaveCustomer(Customer customer)
        {
            return "Kaydedildi";
        }
    }
}
