namespace LandingPageMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedb3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Information", "CreateAt", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Information", "CreateAt");
        }
    }
}
