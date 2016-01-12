/*
 * Copyright (C) Marko Kylmälahti
 *
 * This file is part of the JanitorHelper EntityFramework project.
 *
 * Created: 3. December 2015
 * Authors: Marko Kylmalahti
 */

using MTK.JanitorHelper.DataItemBase.Customers;
using MTK.JanitorHelper.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTK.JanitorHelper.Migrations.SeedData
{
    /// <summary>For creating initial test dummy <see cref="Customer"/>s to context database for functionality and unit tests.</summary>
    class CustomerBuilder
    {
        #region     CONSTRUCTORS

        /// <summary>Default constructor.</summary>
        /// <param name="context"> <see cref="this.context"/>.</param>
        public CustomerBuilder(JanitorHelperDbContext context)
        {
            this.context = context;
        }

        #endregion  CONSTRUCTORS

        #region     METHODS

        /// <summary>Creates one or more <see cref="Customer"/> to context database if they do not exist.</summary>
        public void Create()
        {
            var dummyCustomer = this.context.Customers.FirstOrDefault(c => c.EmailAddress == "dummycustomer1@dummies.com");

            //If dummy does not exist, create one.
            if (dummyCustomer == null)
            {
                this.context.Customers.Add(
                    new Customer
                    {
                        FirstName = "test1",
                        LastName = "dummies",
                        EmailAddress = "dummycustomer1@dummies.com"
                    });
            }
        } 

        #endregion  METHODS

        #region     PROPERTIES

        /// <summary>For initializing database context.</summary>
        private readonly JanitorHelperDbContext context;

        #endregion  PROPERTIES
    }
}//MTK.JanitorHelper.Migrations.SeedData