namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAttendances : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Attendies", newName: "Attendances");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Attendances", newName: "Attendies");
        }
    }
}
