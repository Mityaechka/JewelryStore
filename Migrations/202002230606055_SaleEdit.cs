namespace JewelryStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SaleEdit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sales", "ProductionId", c => c.Int(nullable: false));
            CreateIndex("dbo.Sales", "ProductionId");
            AddForeignKey("dbo.Sales", "ProductionId", "dbo.Productions", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sales", "ProductionId", "dbo.Productions");
            DropIndex("dbo.Sales", new[] { "ProductionId" });
            DropColumn("dbo.Sales", "ProductionId");
        }
    }
}
