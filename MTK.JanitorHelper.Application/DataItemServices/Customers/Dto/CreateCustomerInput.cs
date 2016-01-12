using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using MTK.JanitorHelper.DataItemBase.Customers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTK.JanitorHelper.DataItemServices.Customers.Dto
{
    [AutoMapTo(typeof(Customer))]
    public class CreateCustomerInput : FullAuditedEntityDto
    {

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public string StreetAddressName { get; set; }

        public string StreetAddressNrCode { get; set; }

        public int AreaCode { get; set; }

        public string CityName { get; set; }
    }

}//MTK.JanitorHelper.DataItemServices.Customers.Dto
