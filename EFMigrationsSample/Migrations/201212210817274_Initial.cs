namespace EFMigrationsSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 40),
                        Address = c.String(),
                        City = c.String(maxLength: 75),
                        State = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(x => x.City, unique: true);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clients");
        }
    }
}
