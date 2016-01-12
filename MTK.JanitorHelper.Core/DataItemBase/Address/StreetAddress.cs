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

namespace MTK.JanitorHelper.DataItemBase.Address
{
    [Table("JhStreetAddress")]
    public class StreetAddress : FullAuditedEntity
    {
        public const int MaxNameLength = 64;

        [Required]
        [MaxLength(MaxNameLength)]
        public virtual string Name { get; set; }

        public virtual string OtherInfo { get; set; }

        //Foreign key for City
        public virtual Nullable<int> CityId { get; set; }

        [ForeignKey("CityId")]
        public virtual City City { get; set; }
    }
}