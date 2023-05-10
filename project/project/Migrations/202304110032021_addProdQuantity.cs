namespace project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addProdQuantity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Stores", "Quantity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Stores", "Quantity");
        }
    }
}
