namespace MTK.JanitorHelper.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Added_Customer_Attributes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.JhCustomer", "SocialSecurityNumber", c => c.String(maxLength: 13));
            AddColumn("dbo.JhCustomer", "StreetAddressNrCode", c => c.String());
            AddColumn("dbo.JhCustomer", "OtherInfo", c => c.String());
            AddColumn("dbo.JhCustomer", "StreetAddress_Id", c => c.Int());
            CreateIndex("dbo.JhCustomer", "StreetAddress_Id");
            AddForeignKey("dbo.JhCustomer", "StreetAddress_Id", "dbo.JhStreetAddress", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.JhCustomer", "StreetAddress_Id", "dbo.JhStreetAddress");
            DropIndex("dbo.JhCustomer", new[] { "StreetAddress_Id" });
            DropColumn("dbo.JhCustomer", "StreetAddress_Id");
            DropColumn("dbo.JhCustomer", "OtherInfo");
            DropColumn("dbo.JhCustomer", "StreetAddressNrCode");
            DropColumn("dbo.JhCustomer", "SocialSecurityNumber");
        }
    }
}
