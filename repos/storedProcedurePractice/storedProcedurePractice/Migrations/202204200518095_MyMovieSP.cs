namespace storedProcedurePractice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MyMovieSP : DbMigration
    {
        public override void Up()
        {
            CreateStoredProcedure(
                "dbo.Class1_Insert",
                p => new
                    {
                        Name = p.String(),
                        ReleaseDate = p.DateTime(),
                        Category = p.String(),
                    },
                body:
                    @"INSERT [dbo].[Class1]([Name], [ReleaseDate], [Category])
                      VALUES (@Name, @ReleaseDate, @Category)
                      
                      DECLARE @ID int
                      SELECT @ID = [ID]
                      FROM [dbo].[Class1]
                      WHERE @@ROWCOUNT > 0 AND [ID] = scope_identity()
                      
                      SELECT t0.[ID]
                      FROM [dbo].[Class1] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[ID] = @ID"
            );
            
            CreateStoredProcedure(
                "dbo.Class1_Update",
                p => new
                    {
                        ID = p.Int(),
                        Name = p.String(),
                        ReleaseDate = p.DateTime(),
                        Category = p.String(),
                    },
                body:
                    @"UPDATE [dbo].[Class1]
                      SET [Name] = @Name, [ReleaseDate] = @ReleaseDate, [Category] = @Category
                      WHERE ([ID] = @ID)"
            );
            
            CreateStoredProcedure(
                "dbo.Class1_Delete",
                p => new
                    {
                        ID = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Class1]
                      WHERE ([ID] = @ID)"
            );
            
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.Class1_Delete");
            DropStoredProcedure("dbo.Class1_Update");
            DropStoredProcedure("dbo.Class1_Insert");
        }
    }
}
