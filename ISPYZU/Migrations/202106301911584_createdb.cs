namespace ISPYZU.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createdb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Colleges",
                c => new
                    {
                        CollegeId = c.String(nullable: false, maxLength: 50),
                        CollegeName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.CollegeId);
            
            CreateTable(
                "dbo.CourseEnrolleds",
                c => new
                    {
                        CEId = c.String(nullable: false, maxLength: 50),
                        StudentId = c.String(nullable: false, maxLength: 4),
                        CourseId = c.String(nullable: false, maxLength: 50),
                        TeacherId = c.String(nullable: false, maxLength: 4),
                    })
                .PrimaryKey(t => t.CEId)
                .ForeignKey("dbo.Courses", t => t.CourseId)
                .ForeignKey("dbo.Students", t => t.StudentId)
                .ForeignKey("dbo.Teachers", t => t.TeacherId)
                .Index(t => t.StudentId)
                .Index(t => t.CourseId)
                .Index(t => t.TeacherId);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseId = c.String(nullable: false, maxLength: 50),
                        CourseName = c.String(nullable: false, maxLength: 50),
                        MajorId = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.CourseId)
                .ForeignKey("dbo.Majors", t => t.MajorId)
                .Index(t => t.MajorId);
            
            CreateTable(
                "dbo.Majors",
                c => new
                    {
                        MajorId = c.String(nullable: false, maxLength: 50),
                        MajorName = c.String(nullable: false, maxLength: 50),
                        CollegeId = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.MajorId)
                .ForeignKey("dbo.Colleges", t => t.CollegeId)
                .Index(t => t.CollegeId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.String(nullable: false, maxLength: 4),
                        Name = c.String(nullable: false, maxLength: 40),
                        Gender = c.String(nullable: false),
                        MajorId = c.String(nullable: false, maxLength: 50),
                        CollageId = c.String(nullable: false, maxLength: 50),
                        Session = c.String(nullable: false, maxLength: 12),
                        Password = c.String(nullable: false),
                        Email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.StudentId)
                .ForeignKey("dbo.Colleges", t => t.CollageId)
                .ForeignKey("dbo.Majors", t => t.MajorId)
                .Index(t => t.MajorId)
                .Index(t => t.CollageId);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        TeacherId = c.String(nullable: false, maxLength: 4),
                        Name = c.String(nullable: false, maxLength: 40),
                        Gender = c.String(nullable: false),
                        CollageId = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false),
                        Email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.TeacherId)
                .ForeignKey("dbo.Colleges", t => t.CollageId)
                .Index(t => t.CollageId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleName = c.String(nullable: false, maxLength: 10),
                        Description = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 30),
                        Password = c.String(nullable: false, maxLength: 30),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.RoleId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.RunningCourses",
                c => new
                    {
                        RCId = c.String(nullable: false, maxLength: 50),
                        CourseId = c.String(nullable: false, maxLength: 50),
                        TeacherId = c.String(nullable: false, maxLength: 4),
                    })
                .PrimaryKey(t => t.RCId)
                .ForeignKey("dbo.Courses", t => t.CourseId)
                .ForeignKey("dbo.Teachers", t => t.TeacherId)
                .Index(t => t.CourseId)
                .Index(t => t.TeacherId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RunningCourses", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.RunningCourses", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.Users", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.CourseEnrolleds", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.Teachers", "CollageId", "dbo.Colleges");
            DropForeignKey("dbo.CourseEnrolleds", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Students", "MajorId", "dbo.Majors");
            DropForeignKey("dbo.Students", "CollageId", "dbo.Colleges");
            DropForeignKey("dbo.CourseEnrolleds", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.Courses", "MajorId", "dbo.Majors");
            DropForeignKey("dbo.Majors", "CollegeId", "dbo.Colleges");
            DropIndex("dbo.RunningCourses", new[] { "TeacherId" });
            DropIndex("dbo.RunningCourses", new[] { "CourseId" });
            DropIndex("dbo.Users", new[] { "RoleId" });
            DropIndex("dbo.Teachers", new[] { "CollageId" });
            DropIndex("dbo.Students", new[] { "CollageId" });
            DropIndex("dbo.Students", new[] { "MajorId" });
            DropIndex("dbo.Majors", new[] { "CollegeId" });
            DropIndex("dbo.Courses", new[] { "MajorId" });
            DropIndex("dbo.CourseEnrolleds", new[] { "TeacherId" });
            DropIndex("dbo.CourseEnrolleds", new[] { "CourseId" });
            DropIndex("dbo.CourseEnrolleds", new[] { "StudentId" });
            DropTable("dbo.RunningCourses");
            DropTable("dbo.Users");
            DropTable("dbo.Roles");
            DropTable("dbo.Teachers");
            DropTable("dbo.Students");
            DropTable("dbo.Majors");
            DropTable("dbo.Courses");
            DropTable("dbo.CourseEnrolleds");
            DropTable("dbo.Colleges");
        }
    }
}
