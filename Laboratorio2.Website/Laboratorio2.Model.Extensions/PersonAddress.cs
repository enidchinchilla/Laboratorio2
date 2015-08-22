namespace Laboratorio2.DataAccess
{
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class PersonAddress
    {
        [DataMember]
        public int BusinessEntityID { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public Nullable<int> AddressID { get; set; }
        [DataMember]
        public string AddressLine1 { get; set; }
        [DataMember]
        public string AddressLine2 { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string CountryRegionCode { get; set; }
        [DataMember]
        public string CountryRegionName { get; set; }
        [DataMember]
        public int StateProvinceID { get; set; }
        [DataMember]
        public string StateProvinceName { get; set; }
        [DataMember]
        public string PostalCode { get; set; }
        [DataMember]
        public short Type { get; set; }

    }
}
