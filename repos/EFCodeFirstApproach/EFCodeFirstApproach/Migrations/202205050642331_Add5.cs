namespace EFCodeFirstApproach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.Students", "UpdatedDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "UpdatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Students", "CreatedDate", c => c.DateTime(nullable: false));
        }
    }
}
