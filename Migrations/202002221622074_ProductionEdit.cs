namespace JewelryStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductionEdit : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Materials", "Production_Id", "dbo.Productions");
            DropIndex("dbo.Materials", new[] { "Production_Id" });
            CreateTable(
                "dbo.MaterialCosts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Weight = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MaterialId = c.Int(nullable: false),
                        Production_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Materials", t => t.MaterialId, cascadeDelete: true)
                .ForeignKey("dbo.Productions", t => t.Production_Id)
                .Index(t => t.MaterialId)
                .Index(t => t.Production_Id);
            
            DropColumn("dbo.Materials", "Production_Id");
            DropColumn("dbo.Productions", "Weight");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Productions", "Weight", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Materials", "Production_Id", c => c.Int());
            DropForeignKey("dbo.MaterialCosts", "Production_Id", "dbo.Productions");
            DropForeignKey("dbo.MaterialCosts", "MaterialId", "dbo.Materials");
            DropIndex("dbo.MaterialCosts", new[] { "Production_Id" });
            DropIndex("dbo.MaterialCosts", new[] { "MaterialId" });
            DropTable("dbo.MaterialCosts");
            CreateIndex("dbo.Materials", "Production_Id");
            AddForeignKey("dbo.Materials", "Production_Id", "dbo.Productions", "Id");
        }
    }
}
