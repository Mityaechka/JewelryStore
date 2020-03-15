namespace JewelryStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductionEdit1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Productions", "Cost");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Productions", "Cost", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
