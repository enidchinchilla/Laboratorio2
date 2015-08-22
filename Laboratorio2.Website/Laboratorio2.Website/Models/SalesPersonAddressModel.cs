using Laboratorio2.DataAccess;
using System.Collections.Generic;

namespace Laboratorio2.Website.Models
{
    public class SalesPersonAddressModel
    {
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public string Name { get; set; }
        public List<PersonAddress> Items { get; set; }
    }
}