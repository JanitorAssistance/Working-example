using Abp.Domain.Repositories;
using MTK.JanitorHelper.DataItemBase.Address;
using MTK.JanitorHelper.EntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTK.JanitorHelper.EntityFramework.Repositories
{
    public interface IStreetAddressRepository :  IRepository<StreetAddress>
    {
        int FindOrAddStreetAddress(string name);
    }
}
