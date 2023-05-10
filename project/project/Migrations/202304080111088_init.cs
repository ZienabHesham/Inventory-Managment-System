namespace project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Phone = c.String(),
                        Fax = c.String(),
                        Mobile = c.String(),
                        Email = c.String(),
                        Website = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        Salary = c.Double(nullable: false),
                        Phone = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Stores", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Stores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Address = c.String(),
                        PersonInChargeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TransferOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderNumber = c.String(),
                        OrderDate = c.DateTime(nullable: false, storeType: "date"),
                        SourceStoreId = c.Int(nullable: false),
                        DestinationStoreId = c.Int(nullable: false),
                        SupplierId = c.Int(nullable: false),
                        ProductionDate = c.DateTime(nullable: false, storeType: "date"),
                        ExpiryDate = c.DateTime(nullable: false, storeType: "date"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Stores", t => t.DestinationStoreId)
                .ForeignKey("dbo.Suppliers", t => t.SupplierId, cascadeDelete: true)
                .ForeignKey("dbo.Stores", t => t.SourceStoreId)
                .Index(t => t.SourceStoreId)
                .Index(t => t.DestinationStoreId)
                .Index(t => t.SupplierId);
            
            CreateTable(
                "dbo.TransferOrderItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TransferOrderId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.TransferOrders", t => t.TransferOrderId)
                .Index(t => t.TransferOrderId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(nullable: false),
                        MeasuringUnit = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Phone = c.String(),
                        Fax = c.String(),
                        Mobile = c.String(),
                        Email = c.String(),
                        Website = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IssueOrderItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        IssueOrderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.IssueOrders", t => t.IssueOrderId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.IssueOrderId);
            
            CreateTable(
                "dbo.IssueOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderNumber = c.String(),
                        OrderDate = c.DateTime(nullable: false, storeType: "date"),
                        StoreId = c.Int(nullable: false),
                        SupplierId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Stores", t => t.StoreId, cascadeDelete: true)
                .ForeignKey("dbo.Suppliers", t => t.SupplierId, cascadeDelete: true)
                .Index(t => t.StoreId)
                .Index(t => t.SupplierId);
            
            CreateTable(
                "dbo.SupplyOrderItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        SupplyOrderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.SupplyOrders", t => t.SupplyOrderId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.SupplyOrderId);
            
            CreateTable(
                "dbo.SupplyOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderNumber = c.String(),
                        OrderDate = c.DateTime(nullable: false, storeType: "date"),
                        StoreId = c.Int(nullable: false),
                        SupplierId = c.Int(nullable: false),
                        ProductionDate = c.DateTime(nullable: false, storeType: "date"),
                        ExpiryDate = c.DateTime(nullable: false, storeType: "date"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Stores", t => t.StoreId, cascadeDelete: true)
                .ForeignKey("dbo.Suppliers", t => t.SupplierId, cascadeDelete: true)
                .Index(t => t.StoreId)
                .Index(t => t.SupplierId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SupplyOrderItems", "SupplyOrderId", "dbo.SupplyOrders");
            DropForeignKey("dbo.SupplyOrders", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.SupplyOrders", "StoreId", "dbo.Stores");
            DropForeignKey("dbo.SupplyOrderItems", "ProductId", "dbo.Products");
            DropForeignKey("dbo.IssueOrderItems", "ProductId", "dbo.Products");
            DropForeignKey("dbo.IssueOrderItems", "IssueOrderId", "dbo.IssueOrders");
            DropForeignKey("dbo.IssueOrders", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.IssueOrders", "StoreId", "dbo.Stores");
            DropForeignKey("dbo.TransferOrders", "SourceStoreId", "dbo.Stores");
            DropForeignKey("dbo.TransferOrders", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.TransferOrderItems", "TransferOrderId", "dbo.TransferOrders");
            DropForeignKey("dbo.TransferOrderItems", "ProductId", "dbo.Products");
            DropForeignKey("dbo.TransferOrders", "DestinationStoreId", "dbo.Stores");
            DropForeignKey("dbo.Employees", "Id", "dbo.Stores");
            DropIndex("dbo.SupplyOrders", new[] { "SupplierId" });
            DropIndex("dbo.SupplyOrders", new[] { "StoreId" });
            DropIndex("dbo.SupplyOrderItems", new[] { "SupplyOrderId" });
            DropIndex("dbo.SupplyOrderItems", new[] { "ProductId" });
            DropIndex("dbo.IssueOrders", new[] { "SupplierId" });
            DropIndex("dbo.IssueOrders", new[] { "StoreId" });
            DropIndex("dbo.IssueOrderItems", new[] { "IssueOrderId" });
            DropIndex("dbo.IssueOrderItems", new[] { "ProductId" });
            DropIndex("dbo.TransferOrderItems", new[] { "ProductId" });
            DropIndex("dbo.TransferOrderItems", new[] { "TransferOrderId" });
            DropIndex("dbo.TransferOrders", new[] { "SupplierId" });
            DropIndex("dbo.TransferOrders", new[] { "DestinationStoreId" });
            DropIndex("dbo.TransferOrders", new[] { "SourceStoreId" });
            DropIndex("dbo.Employees", new[] { "Id" });
            DropTable("dbo.SupplyOrders");
            DropTable("dbo.SupplyOrderItems");
            DropTable("dbo.IssueOrders");
            DropTable("dbo.IssueOrderItems");
            DropTable("dbo.Suppliers");
            DropTable("dbo.Products");
            DropTable("dbo.TransferOrderItems");
            DropTable("dbo.TransferOrders");
            DropTable("dbo.Stores");
            DropTable("dbo.Employees");
            DropTable("dbo.Customers");
        }
    }
}
