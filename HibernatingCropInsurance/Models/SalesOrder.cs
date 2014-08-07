using System;

namespace HibernatingCropInsurance.Models
{
    public class SalesOrder
    {
        public virtual int SalesOrderID { get; set; }
        public virtual int RevisionNumber { get; set; }
        public virtual DateTime OrderDate { get; set; }
        public virtual DateTime DueDate { get; set; }
        public virtual DateTime ShipDate { get; set; }
        public virtual int Status { get; set; }
        public virtual bool OnlineOrderFlag { get; set; }
        public virtual string SalesOrderNumber { get; set; }
        public virtual string PurchaseOrderNumber { get; set; }
        public virtual string AccountNumber { get; set; }
        public virtual string ShipMethod { get; set; }
        public virtual string CreditCardApprovalCode { get; set; }
        public virtual decimal SubTotal { get; set; }
        public virtual decimal TaxAmt { get; set; }
        public virtual decimal Freight { get; set; }
        public virtual decimal TotalDue { get; set; }
        public virtual string Comment { get; set; }
        public virtual string RowGuid { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
    }
}