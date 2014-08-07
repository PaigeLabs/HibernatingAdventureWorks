using System.Collections.Generic;
using System.Linq;
using HibernatingCropInsurance.Models;

namespace HibernatingCropInsurance.Data.NHibernate
{
    public class NHibernateCustomerRepository :ICustomerRepository
    {
        private readonly IRepository _repository;

        public NHibernateCustomerRepository(IRepository repository)
        {
            _repository = repository;
        }

        public ICollection<Customer> GetAllCustomers()
        {
            return _repository.All<Customer>().List();
        }

        public Customer GetCustomerById(int id)
        {
            /*
            return _repository.All<Customer>()
                .Fetch(c=>c.SalesOrders).Eager
                .Fetch(c=>c.CustomerAddresses).Eager
                .Where(cust => cust.CustomerID == id)
                .SingleOrDefault();
            */

            var cust1 = _repository.All<Customer>()
               .Where(customer => customer.CustomerID == id)
               .Future<Customer>();

            var cust2 = _repository.All<Customer>()
                .Where(customer => customer.CustomerID == id)
                .Fetch(c => c.CustomerAddresses).Eager
                .Future<Customer>();

            var cust3 = _repository.All<Customer>()
                .Where(customer => customer.CustomerID == id)
                .Fetch(x => x.SalesOrders).Eager
                .Future<Customer>();

            return cust1.SingleOrDefault();
        }
    }
}