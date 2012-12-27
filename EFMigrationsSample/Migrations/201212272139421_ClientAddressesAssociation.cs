namespace EFMigrationsSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClientAddressesAssociation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "BillingAddressId", c => c.Int(nullable: false));
            AddColumn("dbo.Clients", "DeliveryAddressId", c => c.Int(nullable: false));
            AddForeignKey("dbo.Clients", "BillingAddressId", "dbo.AddressBook", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Clients", "DeliveryAddressId", "dbo.AddressBook", "Id", cascadeDelete: true);
            CreateIndex("dbo.Clients", "BillingAddressId");
            CreateIndex("dbo.Clients", "DeliveryAddressId");
            DropColumn("dbo.Clients", "Name");
            DropColumn("dbo.Clients", "Address");
            DropColumn("dbo.Clients", "City");
            DropColumn("dbo.Clients", "State");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clients", "State", c => c.String());
            AddColumn("dbo.Clients", "City", c => c.String());
            AddColumn("dbo.Clients", "Address", c => c.String());
            AddColumn("dbo.Clients", "Name", c => c.String(nullable: false, maxLength: 40));
            DropIndex("dbo.Clients", new[] { "DeliveryAddressId" });
            DropIndex("dbo.Clients", new[] { "BillingAddressId" });
            DropForeignKey("dbo.Clients", "DeliveryAddressId", "dbo.AddressBook");
            DropForeignKey("dbo.Clients", "BillingAddressId", "dbo.AddressBook");
            DropColumn("dbo.Clients", "DeliveryAddressId");
            DropColumn("dbo.Clients", "BillingAddressId");
        }
    }
}
