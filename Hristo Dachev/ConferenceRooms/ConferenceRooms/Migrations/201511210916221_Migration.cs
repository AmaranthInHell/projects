namespace ConferenceRooms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ConfRooms", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ConfRooms", "Name");
        }
    }
}
