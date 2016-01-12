using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using MTK.JanitorHelper.DataItemBase.Address;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTK.JanitorHelper.DataItemServices.Addresses.Dto
{
    public class GetAddressInput : IInputDto
    {
        public string Filter { get; set; }
    }

    [AutoMapFrom(typeof(StreetAddress))]
    public class StreetAddressListDto : FullAuditedEntityDto
    {


        public string Name { get; set; }

        public City City { get; set; }

    }
}
