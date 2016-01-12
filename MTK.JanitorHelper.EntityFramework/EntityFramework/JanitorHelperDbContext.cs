using System.Data.Common;
using Abp.Zero.EntityFramework;
using MTK.JanitorHelper.Authorization.Roles;
using MTK.JanitorHelper.MultiTenancy;
using MTK.JanitorHelper.Users;
using System.Data.Entity;
using MTK.JanitorHelper.DataItemBase.Customers;
using MTK.JanitorHelper.DataItemBase.Address;
using MTK.JanitorHelper.DataItemBase.SMCompanys;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MTK.JanitorHelper.EntityFramework
{
    public class JanitorHelperDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /// <summary>Presents <c>Customers</c> collection.</summary>
        public virtual IDbSet<Customer> Customers { get; set; }

        /// <summary>Presents <c>StreetAddresses</c> collection.</summary>
        public virtual IDbSet<StreetAddress> StreetAddresses { get; set; }

        /// <summary>Presents <c>Cities</c> collection.</summary>
        public virtual IDbSet<City> Cities { get; set; }

        /// <summary>Presents <c>SMCompanys</c> collection.</summary>
        public virtual IDbSet<SMCompany> SMCompanies { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public JanitorHelperDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in JanitorHelperDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of JanitorHelperDbContext since ABP automatically handles it.
         */
        public JanitorHelperDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public JanitorHelperDbContext(DbConnection connection)
            : base(connection, true)
        {

        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        //}
    }
}
