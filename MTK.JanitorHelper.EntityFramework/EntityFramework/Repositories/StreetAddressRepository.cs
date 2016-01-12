using Abp.EntityFramework;
using MTK.JanitorHelper.DataItemBase.Address;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTK.JanitorHelper.EntityFramework.Repositories
{
    class StreetAddressRepository : JanitorHelperRepositoryBase<StreetAddress>, IStreetAddressRepository
    {

        public StreetAddressRepository(IDbContextProvider<JanitorHelperDbContext> dbContextProvider)
        : base(dbContextProvider)
        {
        }

        public int FindOrAddStreetAddress(string name)
        {
            var query = GetAll().Where(p => p.Name.Contains(name));

            query = query.Where(streetAddress => streetAddress.Name == name);

            if (query == null)
            {
                StreetAddress newAddress = new StreetAddress { Name = name };
                return InsertOrUpdateAndGetId(newAddress);
            }

            return query.FirstOrDefault().Id;
        }
    }
}