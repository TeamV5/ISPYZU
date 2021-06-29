namespace ISPYZU.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createdb3 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Students");
            AlterColumn("dbo.Students", "StudentId", c => c.String(nullable: false, maxLength: 4));
            AddPrimaryKey("dbo.Students", "StudentId");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Students");
            AlterColumn("dbo.Students", "StudentId", c => c.String(nullable: false, maxLength: 4));
            AddPrimaryKey("dbo.Students", "StudentId");
        }
    }
}
