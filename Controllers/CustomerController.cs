using DI_Example.Services;
using Microsoft.AspNetCore.Mvc;

namespace DI_Example.Controllers
{
    [Route("api/customer")]
    public class CustomerController : Controller
    {
        private ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("getAge")]
        public int calculateAge()
        {
            CustomerModel customer = new CustomerModel();
            customer.BirthDate = new DateTime(1997, 7, 1);

            customer.Id = 22;
            customer.Name = "Qais Abu-Mwais";
            return customer.calculateAge(_customerService);
        }
    }
}