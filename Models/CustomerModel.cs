using DI_Example.Services;

namespace DI_Example
{
    public class CustomerModel
    {
        public DateTime BirthDate { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }

        private ICustomerService _service;

        public int calculateAge(ICustomerService service)
        {
            this._service = service;
            return this._service.calculateAge(this.BirthDate);
        }
    }
}