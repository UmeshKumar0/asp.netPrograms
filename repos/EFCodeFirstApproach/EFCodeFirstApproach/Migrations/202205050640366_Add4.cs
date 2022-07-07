namespace EFCodeFirstApproach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "UpdatedDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "UpdatedDate", c => c.DateTime());
        }
    }
}
