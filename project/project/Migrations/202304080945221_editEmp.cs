namespace project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editEmp : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employees", "Id", "dbo.Stores");
            DropIndex("dbo.Employees", new[] { "Id" });
            DropPrimaryKey("dbo.Employees");
            AddColumn("dbo.Stores", "PersonInCharge_Id", c => c.Int());
            AlterColumn("dbo.Employees", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Employees", "Id");
            CreateIndex("dbo.Stores", "PersonInCharge_Id");
            AddForeignKey("dbo.Stores", "PersonInCharge_Id", "dbo.Employees", "Id");
            DropColumn("dbo.Stores", "PersonInChargeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Stores", "PersonInChargeId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Stores", "PersonInCharge_Id", "dbo.Employees");
            DropIndex("dbo.Stores", new[] { "PersonInCharge_Id" });
            DropPrimaryKey("dbo.Employees");
            AlterColumn("dbo.Employees", "Id", c => c.Int(nullable: false));
            DropColumn("dbo.Stores", "PersonInCharge_Id");
            AddPrimaryKey("dbo.Employees", "Id");
            CreateIndex("dbo.Employees", "Id");
            AddForeignKey("dbo.Employees", "Id", "dbo.Stores", "Id");
        }
    }
}
