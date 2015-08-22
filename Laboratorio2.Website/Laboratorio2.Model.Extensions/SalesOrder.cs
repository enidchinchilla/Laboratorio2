namespace Laboratorio2.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class SalesOrder
    {
        [DataMember]
        public int SalesOrderID { get; set; }
        [DataMember]
        public byte RevisionNumber { get; set; }
        [DataMember]
        public System.DateTime OrderDate { get; set; }
        [DataMember]
        public System.DateTime DueDate { get; set; }
        [DataMember]
        public System.DateTime ShipDate { get; set; }
        [DataMember]
        public byte Status { get; set; }
        [DataMember]
        public string SalesOrderNumber { get; set; }
        [DataMember]
        public string PurchaseOrderNumber { get; set; }
        [DataMember]
        public string AccountNumber { get; set; }
        [DataMember]
        public int CustomerID { get; set; }
        [DataMember]
        public Nullable<int> SalesPersonID { get; set; }
        [DataMember]
        public int BillToAddressID { get; set; }
        [DataMember]
        public int ShipToAddressID { get; set; }
        [DataMember]
        public int ShipMethodID { get; set; }
        [DataMember]
        public Nullable<int> CreditCardID { get; set; }
        [DataMember]
        public string CreditCardApprovalCode { get; set; }
        [DataMember]
        public Nullable<int> CurrencyRateID { get; set; }
        [DataMember]
        public decimal SubTotal { get; set; }
        [DataMember]
        public decimal TaxAmt { get; set; }
        [DataMember]
        public decimal Freight { get; set; }
        [DataMember]
        public decimal TotalDue { get; set; }
        [DataMember]
        public int SalesOrderDetailID { get; set; }
        [DataMember]
        public string CarrierTrackingNumber { get; set; }
        [DataMember]
        public short OrderQty { get; set; }
        [DataMember]
        public string ProductID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string ProductNumber { get; set; }
        [DataMember]
        public string Color { get; set; }
        [DataMember]
        public decimal UnitPrice { get; set; }
        [DataMember]
        public decimal UnitPriceDiscount { get; set; }
        [DataMember]
        public decimal LineTotal { get; set; }
    }
}
