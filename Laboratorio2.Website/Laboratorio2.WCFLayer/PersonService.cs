
using Laboratorio2.BizLayer;
using Laboratorio2.DataAccess;
using System.Collections.Generic;
namespace Laboratorio2.WCFLayer
{
    public class PersonService : IPersonService
    {
        public List<PersonAddress> GetPersons(short type, string city, string province, string country, string name)
        {
            return new PersonBL().GetPersons(type, city, province, country, name);
        }

        public List<PersonAddress> GetAddressesByPersonID(int salesPersonID)
        {
            return new PersonBL().GetAddressesByPersonID(salesPersonID);
        }
    }
}
