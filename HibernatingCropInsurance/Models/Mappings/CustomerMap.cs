using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Mapping;

namespace HibernatingCropInsurance.Models.Mappings
{
    public class CustomerMap : ClassMap<Customer>
    {
        public CustomerMap()
        {
            Schema("SalesLT");
            Table("Customer");
            Id(m => m.CustomerID);
            Map(x => x.NameStyle);
            Map(x => x.FirstName);
            Map(x => x.MiddleName);
            Map(x => x.LastName);
            Map(x => x.Suffix);
            Map(x => x.CompanyName);
            Map(x => x.SalesPerson);
            Map(x => x.EmailAddress);
            Map(x => x.Phone);

            HasMany(x => x.SalesOrders)
                .KeyColumn("CustomerID")
                .ExtraLazyLoad();

            HasManyToMany(m => m.CustomerAddresses)
                .Schema("SalesLT")
                .Table("CustomerAddress")
                .ParentKeyColumn("CustomerID")
                .ChildKeyColumn("AddressID")
                .Cascade.SaveUpdate();
        }
    }
}