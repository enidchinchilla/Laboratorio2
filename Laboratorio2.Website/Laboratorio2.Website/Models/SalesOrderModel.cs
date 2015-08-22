using Laboratorio2.DataAccess;
using System;
using System.Collections.Generic;

namespace Laboratorio2.Website.Models
{
    public class SalesOrderModel
    {
        public string Name { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public List<SalesOrder> Items { get; set; }
    }
}