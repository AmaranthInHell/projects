namespace ConferenceRooms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ConfEvents", "RoomID", c => c.Int(nullable: false));
            AddColumn("dbo.ConfEvents", "Attendees", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ConfEvents", "Attendees");
            DropColumn("dbo.ConfEvents", "RoomID");
        }
    }
}
