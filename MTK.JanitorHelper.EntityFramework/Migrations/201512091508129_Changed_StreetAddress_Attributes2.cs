namespace MTK.JanitorHelper.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Changed_StreetAddress_Attributes2 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.JhCustomer", "StreetAddressId");
            AddForeignKey("dbo.JhCustomer", "StreetAddressId", "dbo.JhStreetAddress", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.JhCustomer", "StreetAddressId", "dbo.JhStreetAddress");
            DropIndex("dbo.JhCustomer", new[] { "StreetAddressId" });
        }
    }
}
