namespace HMS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class commentaccomodationprop : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AccomodationTypes", "AccomodationPackageID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AccomodationTypes", "AccomodationPackageID", c => c.Int(nullable: false));
        }
    }
}
