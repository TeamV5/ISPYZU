namespace ISPYZU.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createdb1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "Gender", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Gender", c => c.String());
        }
    }
}
