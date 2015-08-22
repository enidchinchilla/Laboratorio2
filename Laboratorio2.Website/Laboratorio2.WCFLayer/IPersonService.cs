using Laboratorio2.DataAccess;
using System.Collections.Generic;
using System.ServiceModel;

namespace Laboratorio2.WCFLayer
{
    [ServiceContract]
    public interface IPersonService
    {
        [OperationContract]
        List<PersonAddress> GetPersons(short type, string city, string province, string country, string name);

        [OperationContract]
        List<PersonAddress> GetAddressesByPersonID(int salesPersonID);
    }
}
