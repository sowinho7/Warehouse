namespace Warehouse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbchange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "ZipCode", c => c.String());
            AddColumn("dbo.Customers", "AccNo", c => c.String());
            AddColumn("dbo.Customers", "TaxNo", c => c.String());
            AddColumn("dbo.In_orders", "OrderDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.In_orders", "ProductId", c => c.Int(nullable: false));
            AddColumn("dbo.In_orders", "CustomerId", c => c.Int(nullable: false));
            AddColumn("dbo.Invoices", "ClientId", c => c.Int(nullable: false));
            AddColumn("dbo.Invoices", "InvoiceNo", c => c.Int(nullable: false));
            AddColumn("dbo.Invoices", "InvoiceDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Invoices", "PaymentDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Out_orders", "OrderDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Out_orders", "ProductId", c => c.Int(nullable: false));
            AddColumn("dbo.Out_orders", "SupplierId", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "NettoPrice", c => c.Single(nullable: false));
            AddColumn("dbo.Products", "CategoryId", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "SupplierId", c => c.Int(nullable: false));
            AddColumn("dbo.Suppliers", "ZipCode", c => c.String());
            AddColumn("dbo.Suppliers", "AccNo", c => c.String());
            AddColumn("dbo.Suppliers", "TaxNo", c => c.String());
            DropColumn("dbo.Customers", "Zip_code");
            DropColumn("dbo.Customers", "Acc_no");
            DropColumn("dbo.Customers", "Tax_no");
            DropColumn("dbo.In_orders", "Order_date");
            DropColumn("dbo.In_orders", "Product_id");
            DropColumn("dbo.In_orders", "Customer_id");
            DropColumn("dbo.Invoices", "Client_id");
            DropColumn("dbo.Invoices", "Invoice_no");
            DropColumn("dbo.Invoices", "Invoice_date");
            DropColumn("dbo.Invoices", "Payment_date");
            DropColumn("dbo.Out_orders", "Order_date");
            DropColumn("dbo.Out_orders", "Product_id");
            DropColumn("dbo.Out_orders", "Supplier_id");
            DropColumn("dbo.Products", "Netto_price");
            DropColumn("dbo.Products", "Category_id");
            DropColumn("dbo.Products", "Supplier_id");
            DropColumn("dbo.Suppliers", "Zip_code");
            DropColumn("dbo.Suppliers", "Acc_no");
            DropColumn("dbo.Suppliers", "Tax_no");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Suppliers", "Tax_no", c => c.String());
            AddColumn("dbo.Suppliers", "Acc_no", c => c.String());
            AddColumn("dbo.Suppliers", "Zip_code", c => c.String());
            AddColumn("dbo.Products", "Supplier_id", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "Category_id", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "Netto_price", c => c.Single(nullable: false));
            AddColumn("dbo.Out_orders", "Supplier_id", c => c.Int(nullable: false));
            AddColumn("dbo.Out_orders", "Product_id", c => c.Int(nullable: false));
            AddColumn("dbo.Out_orders", "Order_date", c => c.DateTime(nullable: false));
            AddColumn("dbo.Invoices", "Payment_date", c => c.DateTime(nullable: false));
            AddColumn("dbo.Invoices", "Invoice_date", c => c.DateTime(nullable: false));
            AddColumn("dbo.Invoices", "Invoice_no", c => c.Int(nullable: false));
            AddColumn("dbo.Invoices", "Client_id", c => c.Int(nullable: false));
            AddColumn("dbo.In_orders", "Customer_id", c => c.Int(nullable: false));
            AddColumn("dbo.In_orders", "Product_id", c => c.Int(nullable: false));
            AddColumn("dbo.In_orders", "Order_date", c => c.DateTime(nullable: false));
            AddColumn("dbo.Customers", "Tax_no", c => c.String());
            AddColumn("dbo.Customers", "Acc_no", c => c.String());
            AddColumn("dbo.Customers", "Zip_code", c => c.String());
            DropColumn("dbo.Suppliers", "TaxNo");
            DropColumn("dbo.Suppliers", "AccNo");
            DropColumn("dbo.Suppliers", "ZipCode");
            DropColumn("dbo.Products", "SupplierId");
            DropColumn("dbo.Products", "CategoryId");
            DropColumn("dbo.Products", "NettoPrice");
            DropColumn("dbo.Out_orders", "SupplierId");
            DropColumn("dbo.Out_orders", "ProductId");
            DropColumn("dbo.Out_orders", "OrderDate");
            DropColumn("dbo.Invoices", "PaymentDate");
            DropColumn("dbo.Invoices", "InvoiceDate");
            DropColumn("dbo.Invoices", "InvoiceNo");
            DropColumn("dbo.Invoices", "ClientId");
            DropColumn("dbo.In_orders", "CustomerId");
            DropColumn("dbo.In_orders", "ProductId");
            DropColumn("dbo.In_orders", "OrderDate");
            DropColumn("dbo.Customers", "TaxNo");
            DropColumn("dbo.Customers", "AccNo");
            DropColumn("dbo.Customers", "ZipCode");
        }
    }
}
