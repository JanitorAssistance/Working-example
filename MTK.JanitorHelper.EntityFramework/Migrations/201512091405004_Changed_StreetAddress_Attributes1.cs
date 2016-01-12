namespace MTK.JanitorHelper.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Changed_StreetAddress_Attributes1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.JhStreetAddress", "CityId", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.JhStreetAddress", "CityId", c => c.Int(nullable: false));
        }
    }
}
