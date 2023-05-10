namespace project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeProdQuantity : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Stores", "Quantity");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Stores", "Quantity", c => c.Int(nullable: false));
        }
    }
}
