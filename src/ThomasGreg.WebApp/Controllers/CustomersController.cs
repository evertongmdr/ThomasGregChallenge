using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ThomasGreg.Domain.Interfaces.Repositories;
using ThomasGreg.WebApp.ViewsModel;

namespace ThomasGreg.WebApp.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomersController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        [AllowAnonymous]
        [Route("lista-de-clientes")]
        public async Task<IActionResult> Index()
        {

            var lista = new List<CustomerViewModel>() { new CustomerViewModel { 
                Nome = "Cliente", Email = "cliente@hotmail.com" } };

            return View(lista);
        }

        [Route("novo-cliente")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CustomerViewModel customerViewModel)
        {

            if (ModelState.IsValid)
            {
                _customerRepository.AddAsync(customerViewModel);
            }
            return View(customerViewModel);
        }
    }
}
