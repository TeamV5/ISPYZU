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
            AlterColumn("dbo.Students", "Name", c => c.String(nullable: false, maxLength: 40));
            AddPrimaryKey("dbo.Students", "StudentId");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Students");
            AlterColumn("dbo.Students", "Name", c => c.String(nullable: false, maxLength: 12));
            AlterColumn("dbo.Students", "StudentId", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Students", "StudentId");
        }
    }
}
