namespace MTK.JanitorHelper.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Added_Customers_Table1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.JhCustomer", "StreetAddressNroCode", c => c.String(maxLength: 7));
            AddColumn("dbo.JhCustomer", "StreetAddress_Id", c => c.Int());
            CreateIndex("dbo.JhCustomer", "StreetAddress_Id");
            AddForeignKey("dbo.JhCustomer", "StreetAddress_Id", "dbo.JhStreetAddress", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.JhCustomer", "StreetAddress_Id", "dbo.JhStreetAddress");
            DropIndex("dbo.JhCustomer", new[] { "StreetAddress_Id" });
            DropColumn("dbo.JhCustomer", "StreetAddress_Id");
            DropColumn("dbo.JhCustomer", "StreetAddressNroCode");
        }
    }
}
