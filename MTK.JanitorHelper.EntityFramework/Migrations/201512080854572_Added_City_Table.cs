namespace MTK.JanitorHelper.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class Added_City_Table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.JhCity",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 64),
                        AreaCode = c.Int(nullable: false),
                        OtherInfo = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_City_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.JhSMCompany",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 64),
                        VAT = c.String(nullable: false, maxLength: 32),
                        EmailAddress = c.String(maxLength: 255),
                        StreetAddressNroCode = c.String(maxLength: 7),
                        AreCredentialsChecked = c.Boolean(nullable: false),
                        AreCredentialsOkay = c.Boolean(nullable: false),
                        OtherInfo = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                        StreetAddress_Id = c.Int(),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_SMCompany_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.JhStreetAddress", t => t.StreetAddress_Id)
                .Index(t => t.StreetAddress_Id);
            
            CreateTable(
                "dbo.JhStreetAddress",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 64),
                        OtherInfo = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                        City_Id = c.Int(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_StreetAddress_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.JhCity", t => t.City_Id, cascadeDelete: true)
                .Index(t => t.City_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.JhSMCompany", "StreetAddress_Id", "dbo.JhStreetAddress");
            DropForeignKey("dbo.JhStreetAddress", "City_Id", "dbo.JhCity");
            DropIndex("dbo.JhStreetAddress", new[] { "City_Id" });
            DropIndex("dbo.JhSMCompany", new[] { "StreetAddress_Id" });
            DropTable("dbo.JhStreetAddress",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_StreetAddress_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.JhSMCompany",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_SMCompany_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.JhCity",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_City_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
        }
    }
}
