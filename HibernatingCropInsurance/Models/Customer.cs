using System.Collections.Generic;
using Ninject.Parameters;

namespace HibernatingCropInsurance.Models
{
    public class Customer
    {
        public virtual int CustomerID { get; set; }
        public virtual bool NameStyle { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string MiddleName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Suffix { get; set; }
        public virtual string CompanyName { get; set; }
        public virtual string SalesPerson { get; set; }
        public virtual string EmailAddress { get; set; }
        public virtual string Phone { get; set; }
        public virtual IEnumerable<SalesOrder> SalesOrders { get; set; }
        public virtual IEnumerable<CustomerAddress> CustomerAddresses { get; set; }

    }
}