namespace EFMigrationsSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Orders : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Address = c.String(),
                        SubTotal = c.Decimal(nullable: false, precision: 10, scale: 2),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .Index(t => t.ClientId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Orders", new[] { "ClientId" });
            DropForeignKey("dbo.Orders", "ClientId", "dbo.Clients");
            DropTable("dbo.Orders");
        }
    }
}
