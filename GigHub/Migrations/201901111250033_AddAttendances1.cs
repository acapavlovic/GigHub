namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAttendances1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Attendances", name: "ArtistId", newName: "AttendieId");
            RenameIndex(table: "dbo.Attendances", name: "IX_ArtistId", newName: "IX_AttendieId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Attendances", name: "IX_AttendieId", newName: "IX_ArtistId");
            RenameColumn(table: "dbo.Attendances", name: "AttendieId", newName: "ArtistId");
        }
    }
}
