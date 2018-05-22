namespace Warehouse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class db_updt_invoice : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Invoices", "Name", c => c.String());
            AddColumn("dbo.Invoices", "Country", c => c.String());
            AddColumn("dbo.Invoices", "City", c => c.String());
            AddColumn("dbo.Invoices", "Address", c => c.String());
            AddColumn("dbo.Invoices", "ZipCode", c => c.String());
            AddColumn("dbo.Invoices", "ProdName", c => c.String());
            AddColumn("dbo.Invoices", "Vat", c => c.Int(nullable: false));
            AddColumn("dbo.Invoices", "NettoPrice", c => c.Single(nullable: false));
            AddColumn("dbo.Invoices", "Count", c => c.Int(nullable: false));
            DropColumn("dbo.Invoices", "ClientId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Invoices", "ClientId", c => c.Int(nullable: false));
            DropColumn("dbo.Invoices", "Count");
            DropColumn("dbo.Invoices", "NettoPrice");
            DropColumn("dbo.Invoices", "Vat");
            DropColumn("dbo.Invoices", "ProdName");
            DropColumn("dbo.Invoices", "ZipCode");
            DropColumn("dbo.Invoices", "Address");
            DropColumn("dbo.Invoices", "City");
            DropColumn("dbo.Invoices", "Country");
            DropColumn("dbo.Invoices", "Name");
        }
    }
}
