namespace project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editProduct : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Store_Id", c => c.Int());
            CreateIndex("dbo.Products", "Store_Id");
            AddForeignKey("dbo.Products", "Store_Id", "dbo.Stores", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Store_Id", "dbo.Stores");
            DropIndex("dbo.Products", new[] { "Store_Id" });
            DropColumn("dbo.Products", "Store_Id");
        }
    }
}
