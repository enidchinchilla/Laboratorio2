
using Laboratorio2.BizLayer;
using Laboratorio2.DataAccess;
using System.Collections.Generic;
namespace Laboratorio2.WCFLayer
{
    public class SalesPersonService : ISalesPersonService
    {
        public List<PersonAddress> GetSalesPersons(string city, string province, string country, string name)
        {
            return new SalesPersonBL().GetSalesPersons(city, province, country, name);
        }

        public List<PersonAddress> GetAddressesBySalesPersonID(int salesPersonID)
        {
            return new SalesPersonBL().GetAddressesBySalesPersonID(salesPersonID);
        }
    }
}
