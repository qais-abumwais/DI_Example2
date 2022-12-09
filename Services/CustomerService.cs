namespace DI_Example.Services
{
    public class CustomerService : ICustomerService
    {
        public int calculateAge(DateTime birthDate)
        {
            DateTime now = DateTime.Today;
            int age = now.Year - birthDate.Year;
            if (now < birthDate.AddYears(age))
                age--;

            return age;
        }
    }
}
