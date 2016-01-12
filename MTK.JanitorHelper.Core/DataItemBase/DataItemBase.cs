/*
 * Copyright (C) Marko Kylmälahti
 *
 * This file is part of the JanitorHelper EntityFramework project.
 *
 * Created: 3. December 2015
 * Authors: Marko Kylmalahti
 */

using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTK.JanitorHelper.DataItemBase
{
    /// <summary>Provides basic functionality for separate data items.</summary>
    public class DataItemBase : FullAuditedEntity
    {
        /// <summary>Default Constructor.</summary>
        public DataItemBase() { }
    }
}//MTK.JanitorHelper.DataItemBase
