namespace ISPYZU.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createdb2 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Students");
            AlterColumn("dbo.Students", "StudentId", c => c.String(nullable: false, maxLength: 4));
            AddPrimaryKey("dbo.Students", "StudentId");
            DropColumn("dbo.Students", "SerialId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "SerialId", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Students");
            AlterColumn("dbo.Students", "StudentId", c => c.String(nullable: false, maxLength: 4));
            AddPrimaryKey("dbo.Students", "SerialId");
        }
    }
}
