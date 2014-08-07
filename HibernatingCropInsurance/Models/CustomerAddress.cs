using System;
using System.Collections.Generic;

namespace HibernatingCropInsurance.Models
{
    public class CustomerAddress
    {
        public virtual int AddressID { get; set; }
        public virtual string AddressLine1 { get; set; }
        public virtual string AddressLine2 { get; set; }
        public virtual string City { get; set; }
        public virtual string StateProvince { get; set; }
        public virtual string CountryRegion { get; set; }
        public virtual string PostalCode { get; set; }
        public virtual Guid RowGuid { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
        public virtual IEnumerable<Customer> Customers { get; set; }
    }
}