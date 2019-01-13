namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAttendi : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attendies",
                c => new
                    {
                        GigId = c.Int(nullable: false),
                        ArtistId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.GigId, t.ArtistId })
                .ForeignKey("dbo.AspNetUsers", t => t.ArtistId, cascadeDelete: true)
                .ForeignKey("dbo.Gigs", t => t.GigId)
                .Index(t => t.GigId)
                .Index(t => t.ArtistId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Attendies", "GigId", "dbo.Gigs");
            DropForeignKey("dbo.Attendies", "ArtistId", "dbo.AspNetUsers");
            DropIndex("dbo.Attendies", new[] { "ArtistId" });
            DropIndex("dbo.Attendies", new[] { "GigId" });
            DropTable("dbo.Attendies");
        }
    }
}
