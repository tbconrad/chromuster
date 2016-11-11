#pragma warning disable 1591
namespace WidgetTestService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Discounts",
                c => new
                    {
                        DiscountId = c.Int(nullable: false, identity: true),
                        DiscountPercentage = c.Int(nullable: false),
                        Active = c.Boolean(),
                        CreatedBy = c.String(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Modified = c.DateTime(),
                    })
                .PrimaryKey(t => t.DiscountId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        WidgetId = c.Int(nullable: false),
                        StateId = c.Int(nullable: false),
                        OrderDate = c.DateTime(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.States", t => t.StateId, cascadeDelete: true)
                .ForeignKey("dbo.Widgets", t => t.WidgetId, cascadeDelete: true)
                .Index(t => t.WidgetId)
                .Index(t => t.StateId);
            
            CreateTable(
                "dbo.States",
                c => new
                    {
                        StateId = c.Int(nullable: false, identity: true),
                        StateName = c.String(nullable: false),
                        StateAbbreviation = c.String(nullable: false, maxLength: 2),
                        CreatedBy = c.String(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Modified = c.DateTime(),
                        TaxRateId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StateId)
                .ForeignKey("dbo.TaxRates", t => t.TaxRateId, cascadeDelete: true)
                .Index(t => t.TaxRateId);
            
            CreateTable(
                "dbo.TaxRates",
                c => new
                    {
                        TaxRateId = c.Int(nullable: false, identity: true),
                        TaxBaseRate = c.Double(nullable: false),
                        Active = c.Boolean(),
                        CreatedBy = c.String(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Modified = c.DateTime(),
                    })
                .PrimaryKey(t => t.TaxRateId);
            
            CreateTable(
                "dbo.Widgets",
                c => new
                    {
                        WidgetId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        BasePrice = c.Double(nullable: false),
                        DiscountAvailable = c.Boolean(),
                        DiscountId = c.Int(),
                        Active = c.Boolean(),
                        CreatedBy = c.String(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Modified = c.DateTime(),
                    })
                .PrimaryKey(t => t.WidgetId)
                .ForeignKey("dbo.Discounts", t => t.DiscountId)
                .Index(t => t.DiscountId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "WidgetId", "dbo.Widgets");
            DropForeignKey("dbo.Widgets", "DiscountId", "dbo.Discounts");
            DropForeignKey("dbo.Orders", "StateId", "dbo.States");
            DropForeignKey("dbo.States", "TaxRateId", "dbo.TaxRates");
            DropIndex("dbo.Widgets", new[] { "DiscountId" });
            DropIndex("dbo.States", new[] { "TaxRateId" });
            DropIndex("dbo.Orders", new[] { "StateId" });
            DropIndex("dbo.Orders", new[] { "WidgetId" });
            DropTable("dbo.Widgets");
            DropTable("dbo.TaxRates");
            DropTable("dbo.States");
            DropTable("dbo.Orders");
            DropTable("dbo.Discounts");
        }
    }
}
