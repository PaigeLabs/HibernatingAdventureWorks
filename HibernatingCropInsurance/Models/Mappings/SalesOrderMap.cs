using FluentNHibernate.Mapping;

namespace HibernatingCropInsurance.Models.Mappings
{
    public class SalesOrderMap : ClassMap<SalesOrder>
    {
        public SalesOrderMap()
        {
            Schema("SalesLT");
            Table("SalesOrderHeader");
            Id(x => x.SalesOrderID);
            Map(x => x.RevisionNumber);
            Map(x => x.OrderDate);
            Map(x => x.DueDate);
            Map(x => x.ShipDate);
            Map(x => x.Status);
            Map(x => x.OnlineOrderFlag);
            Map(x => x.SalesOrderNumber);
            Map(x => x.PurchaseOrderNumber);
            Map(x => x.AccountNumber);
            Map(x => x.ShipMethod);
            Map(x => x.CreditCardApprovalCode);
            Map(x => x.SubTotal);
            Map(x => x.TaxAmt);
            Map(x => x.Freight);
            Map(x => x.TotalDue);
            Map(x => x.Comment);
            Map(x => x.RowGuid);
            Map(x => x.ModifiedDate);
        }
    }
}