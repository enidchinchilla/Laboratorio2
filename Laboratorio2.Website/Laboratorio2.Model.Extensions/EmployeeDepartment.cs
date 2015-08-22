namespace Laboratorio2.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class EmployeeDepartment
    {
        [DataMember]
        public int BusinessEntityID { get; set; }
        [DataMember]
        public string NationalIDNumber { get; set; }
        [DataMember]
        public string LoginID { get; set; }
        [DataMember]
        public string JobTitle { get; set; }
        [DataMember]
        public System.DateTime BirthDate { get; set; }
        [DataMember]
        public string MaritalStatus { get; set; }
        [DataMember]
        public string Gender { get; set; }
        [DataMember]
        public System.DateTime HireDate { get; set; }
        [DataMember]
        public short VacationHours { get; set; }
        [DataMember]
        public short SickLeaveHours { get; set; }
        [DataMember]
        public short DepartmentID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string GroupName { get; set; }
        [DataMember]
        public System.DateTime StartDate { get; set; }
        [DataMember]
        public Nullable<System.DateTime> EndDate { get; set; }
    }
}
