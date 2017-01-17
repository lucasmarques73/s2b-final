namespace S2B_Final.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLatLong : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DenunciaModels", "Latitude", c => c.String());
            AddColumn("dbo.DenunciaModels", "Longitude", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.DenunciaModels", "Longitude");
            DropColumn("dbo.DenunciaModels", "Latitude");
        }
    }
}
