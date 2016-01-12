using Abp.Authorization.Users;
using Abp.Domain.Entities.Auditing;
using MTK.JanitorHelper.DataItemBase.Address;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTK.JanitorHelper.DataItemBase.Customers
{
    [Table("JhCustomer")]
    public class Customer : FullAuditedEntity
    {

        public const int MaxNameLength = 32;
        public const int MaxLastNameLenght = 32;
        public const int MaxEmailAddressLength = 255;
        public const int MaxSocialSecurityLenght = 13;

        [Required]
        [MaxLength(MaxNameLength)]
        public virtual string FirstName { get; set; }

        [Required]
        [MaxLength(MaxLastNameLenght)]
        public virtual string LastName { get; set; }

        [MaxLength(MaxEmailAddressLength)]
        public virtual string EmailAddress { get; set; }

        public virtual bool AreCredentialsChecked { get; set; }

        public virtual bool AreCredentialsOkay { get; set; }

        [MaxLength(MaxSocialSecurityLenght)]
        public virtual string SocialSecurityNumber { get; set; }


        [ForeignKey("StreetAddressId")]
        public virtual StreetAddress StreetAddress { get; set; }
        public virtual int? StreetAddressId { get; set; }

        //public virtual int? StreetAddressId { get; set; }

        public virtual string StreetAddressNrCode { get; set; }

        public virtual string OtherInfo { get; set; }
    }
}