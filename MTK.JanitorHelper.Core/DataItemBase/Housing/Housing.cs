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
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTK.JanitorHelper.DataItemBase.Housing
{
    [Table("JhHousing")]
    public class HousingCooperative : FullAuditedEntity
    {
        public const int MaxNameLength = 32;
        public const int MaxLastNameLenght = 32;
        public const int MaxEmailAddressLength = 255;

        [Required]
        [MaxLength(MaxNameLength)]
        public virtual string FirstName { get; set; }

        [Required]
        [MaxLength(MaxLastNameLenght)]
        public virtual string LastName { get; set; }

        [MaxLength(MaxEmailAddressLength)]
        public virtual string EmailAddress { get; set; }

        public bool AreCredentialsChecked { get; set; }

        public bool AreCredentialsOkay { get; set; }

        public virtual string OtherInfo { get; set; }

    }
}