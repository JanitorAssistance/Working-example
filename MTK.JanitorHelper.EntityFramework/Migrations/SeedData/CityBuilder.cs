/*
 * Copyright (C) Marko Kylmälahti
 *
 * This file is part of the JanitorHelper EntityFramework project.
 *
 * Created: 3. December 2015
 * Authors: Marko Kylmalahti
 */

using MTK.JanitorHelper.DataItemBase.Address;
using MTK.JanitorHelper.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTK.JanitorHelper.Migrations.SeedData
{
    /// <summary>For creating initial test dummy <see cref="City"/>s to context database for functionality and unit tests.</summary>
    class CityBuilder
    {
        #region     CONSTRUCTORS

        /// <summary>Default constructor.</summary>
        /// <param name="context"> <see cref="this.context"/>.</param>
        public CityBuilder(JanitorHelperDbContext context)
        {
            this.context = context;
        }

        #endregion  CONSTRUCTORS

        #region     METHODS

        /// <summary>Creates one or more <see cref="City"/> to context database if they do not exist.</summary>
        public void Create()
        {
            var dummyCity = this.context.Cities.FirstOrDefault(c => c.AreaCode == 40270);

            //If dummy does not exist, create one.
            if (dummyCity == null)
            {
                this.context.Cities.Add(
                    new City
                    {
                        AreaCode = 40270,
                        Name = "Palokka"
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