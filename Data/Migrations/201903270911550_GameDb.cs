namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GameDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                        Admin = c.String(nullable: false, defaultValueSql: "Not Admin"),
                })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Link = c.String(),
                        Date = c.String(),
                        Developer = c.String(),
                        Genre = c.String(),
                        Image = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Games");
            DropTable("dbo.Accounts");
        }
    }
}
