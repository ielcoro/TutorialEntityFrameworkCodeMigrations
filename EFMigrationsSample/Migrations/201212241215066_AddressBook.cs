namespace EFMigrationsSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddressBook : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AddressBook",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AddressName = c.String(nullable: false),
                        City = c.String(nullable: false),
                        State = c.String(nullable: false),
                        AddressType = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AddressBook");
        }
    }
}
