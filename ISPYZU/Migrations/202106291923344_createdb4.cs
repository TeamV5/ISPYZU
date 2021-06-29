namespace ISPYZU.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createdb4 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Teachers");
            AddPrimaryKey("dbo.Teachers", "TeacherId");
            DropColumn("dbo.Teachers", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teachers", "Id", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Teachers");
            AddPrimaryKey("dbo.Teachers", "Id");
        }
    }
}
