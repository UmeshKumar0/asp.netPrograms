namespace EFCodeFirstApproach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Students", "UpdatedDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Students", "CreatedAt");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "CreatedAt", c => c.DateTime());
            DropColumn("dbo.Students", "UpdatedDate");
            DropColumn("dbo.Students", "CreatedDate");
        }
    }
}
