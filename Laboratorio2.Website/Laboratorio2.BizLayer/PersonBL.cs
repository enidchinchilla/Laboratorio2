using Laboratorio2.DataAccess;
using System.Collections.Generic;
using System.Linq;

namespace Laboratorio2.BizLayer
{
    public class PersonBL
    {
        public List<PersonAddress> GetPersons(short type, string city, string province, string country, string name)
        {
            using (var context = new Laboratorio2Entities())
            {
                IQueryable<PersonAddress> query = context.PersonAddresses.Where(x => x.Type == type);
                if (!string.IsNullOrEmpty(city))
                    query = query.Where(e => e.City.Contains(city));
                if (!string.IsNullOrEmpty(province))
                    query = query.Where(e => e.StateProvinceName.Contains(province));
                if (!string.IsNullOrEmpty(country))
                    query = query.Where(e => e.CountryRegionName.Contains(country));
                if (!string.IsNullOrEmpty(name))
                    query = query.Where(e => e.FirstName.Contains(name));
                var result = query
                    .GroupBy(x => new { x.BusinessEntityID, x.FirstName, x.AddressID })
                    .Select(x => new
                    {
                        BusinessEntityID = x.Key.BusinessEntityID,
                        FirstName = x.Key.FirstName,
                        AddressID = x.Key.AddressID
                    })
                    .ToList()
                    .Select(x => new PersonAddress
                    {
                        BusinessEntityID = x.BusinessEntityID,
                        FirstName = x.FirstName,
                        AddressID = x.AddressID
                    });
                return result.ToList();
            }
        }

        public List<PersonAddress> GetAddressesByPersonID(int personID)
        {
            using (var context = new Laboratorio2Entities())
            {
                return context.PersonAddresses.Where(e => e.BusinessEntityID == personID).ToList();
            }
        }
    }
}
