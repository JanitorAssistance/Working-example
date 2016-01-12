
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using MTK.JanitorHelper.DataItemBase.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTK.JanitorHelper.DataItemServices.Customers.Dto
{
    public class GetCustomersInput : IInputDto
    {
        public string Filter { get; set; }
    }

    [AutoMapFrom(typeof(Customer))]
    public class CustomerListDto : FullAuditedEntityDto
    {
     

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public bool AreCredentialsChecked { get; set; }

        public bool AreCredentialsOkay { get; set; }

        public int StreetAddressId { get; set; }

        public string StreetAddressName { get; set; }

        public string StreetAddressNrCode { get; set; }

    }
}
