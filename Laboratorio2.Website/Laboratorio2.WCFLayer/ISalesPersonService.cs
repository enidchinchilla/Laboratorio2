using Laboratorio2.DataAccess;
using System.Collections.Generic;
using System.ServiceModel;

namespace Laboratorio2.WCFLayer
{
    [ServiceContract]
    public interface ISalesPersonService
    {
        [OperationContract]
        List<PersonAddress> GetSalesPersons(string city, string province, string country, string name);

        [OperationContract]
        List<PersonAddress> GetAddressesBySalesPersonID(int salesPersonID);
    }
}
