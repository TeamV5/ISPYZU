namespace ISPYZU.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createdb1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.String(nullable: false, maxLength: 4),
                        Name = c.String(nullable: false, maxLength: 12),
                        Gender = c.String(),
                        MajorId = c.String(nullable: false, maxLength: 12),
                        CollageId = c.String(nullable: false, maxLength: 12),
                        Session = c.String(nullable: false, maxLength: 12),
                        Passowrd = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Picture = c.Binary(),
                    })
                .PrimaryKey(t => t.StudentId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
