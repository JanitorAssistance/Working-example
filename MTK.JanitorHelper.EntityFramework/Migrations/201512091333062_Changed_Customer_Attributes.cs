namespace MTK.JanitorHelper.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Changed_Customer_Attributes : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.JhCustomer", "StreetAddress_Id", "dbo.JhStreetAddress");
            DropIndex("dbo.JhCustomer", new[] { "StreetAddress_Id" });
            AddColumn("dbo.JhCustomer", "StreetAddressId", c => c.Int());
            DropColumn("dbo.JhCustomer", "StreetAddress_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.JhCustomer", "StreetAddress_Id", c => c.Int());
            DropColumn("dbo.JhCustomer", "StreetAddressId");
            CreateIndex("dbo.JhCustomer", "StreetAddress_Id");
            AddForeignKey("dbo.JhCustomer", "StreetAddress_Id", "dbo.JhStreetAddress", "Id");
        }
    }
}
