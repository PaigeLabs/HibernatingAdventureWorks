using System.Collections.Generic;
using HibernatingCropInsurance.Models;

namespace HibernatingCropInsurance.Data
{
    public interface ICustomerRepository
    {
        ICollection<Customer> GetAllCustomers();
        Customer GetCustomerById(int id);
    }
}
