/*
 * Copyright (C) Marko Kylmälahti
 *
 * This file is part of the JanitorHelper Core project.
 *
 * Created: 3. December 2015
 * Authors: Marko Kylmalahti
 */

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

namespace MTK.JanitorHelper.DataItemBase.SMCompanys
{
    [Table("JhSMCompany")]
    public class SMCompany : FullAuditedEntity
    {
        public const int MaxNameLength = 64;
        public const int MaxStreetAddressNroCodeLength = 7;
        public const int MaxVATId = 32;
        public const int MaxEmailAddressLength = 255;

        [Required]
        [MaxLength(MaxNameLength)]
        public virtual string Name { get; set; }

        [Required]
        [MaxLength(MaxVATId)]
        public virtual string VAT { get; set; }

        [MaxLength(MaxEmailAddressLength)]
        public virtual string EmailAddress { get; set; }

        public virtual StreetAddress StreetAddress { get; set; }

        [MaxLength(MaxStreetAddressNroCodeLength)]
        public virtual string StreetAddressNroCode { get; set; }

        public bool AreCredentialsChecked { get; set; }

        public bool AreCredentialsOkay { get; set; }

        public virtual string OtherInfo { get; set; }

    }
}