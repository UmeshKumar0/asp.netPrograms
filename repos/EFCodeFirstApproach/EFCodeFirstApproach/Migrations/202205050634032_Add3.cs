namespace EFCodeFirstApproach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "CreatedDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "CreatedDate", c => c.DateTime());
        }
    }
}
