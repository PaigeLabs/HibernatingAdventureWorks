using FluentNHibernate.Mapping;

namespace HibernatingCropInsurance.Models.Mappings
{
    public class CustomerAddressMap : ClassMap<CustomerAddress>
    {
        public CustomerAddressMap()
        {
            Schema("SalesLT");
            Table("Address");
            Id(m => m.AddressID);
            Map(m => m.AddressLine1);
            Map(m => m.AddressLine2);
            Map(m => m.City);
            Map(m => m.StateProvince);
            Map(m => m.PostalCode);
            Map(m => m.CountryRegion);
            Map(m => m.RowGuid);
            Map(m => m.ModifiedDate);

            HasManyToMany(m => m.Customers)
                .Schema("SalesLT")
                .Table("CustomerAddress")
                .ParentKeyColumn("AddressID")
                .ChildKeyColumn("CustomerID")
                .Inverse();
        }
    }
}