using ISPYZU.Models; // TestDbContext
using System;
using System.Collections.Generic;
using System.Data.Entity; // DropCreateDatabaseAlways<DbContext>
using System.Linq;
using System.Web;


namespace ISPYZU.App_Code
{
  //ALT+Enter for twice! using two namespaces!
  public class TestDbInitialization : DropCreateDatabaseAlways<TestDbContext>
  {
    //set the seed, which is used for add data to the tables in the database!
    //  after creating the database
    protected override void Seed(TestDbContext context)
    {

            
            var roles = new List<Role>
      {
        new Role { RoleName = "Teacher", Description = "Managing_department" },
        new Role { RoleName = "Admin", Description = "Directing_department"},
        new Role { RoleName = "Student", Description = "Learning_department"}
      };
            roles.ForEach(r => context.Roles.Add(r));
            context.SaveChanges();

            var users = new List<User>
      {
        new User {UserName="Noman",  Password="123456", RoleId=2},
        new User {UserName="Shorif",  Password="123456", RoleId=2},
        new User {UserName="Siam",  Password="123456", RoleId=2},
        new User {UserName="Admin",  Password="123456", RoleId=2},
        new User {UserName="admin",  Password="admin1234", RoleId=2},


      };
            users.ForEach(u => context.Users.Add(u));
            context.SaveChanges();


            var Students = new List<Student>
      {
        new Student { StudentId ="1223", Name="MD_zahidul_Alam",Gender="Male",MajorId="1222",CollageId="1223",Session="2018",Password="zahid1234",Email="zahid@gmail.com" },
        new Student { StudentId ="2334", Name="MD AL Rayhan",Gender="Male",MajorId="1222",CollageId="1223",Session="2018",Password="rayhan1234",Email="zahid@gmail.com" },


      };
            Students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();

            var Teachers = new List<Teacher>
      {
        new Teacher { TeacherId ="3221", Name="XU ming",Gender="Male",CollageId="1223",Password="zahid1234",Email="asd@gmail.com" },
        new Teacher { TeacherId ="3222", Name="Simon",Gender="Male",CollageId="1223",Password="rayhan1234",Email="cds@gmail.com" },


      };
            Teachers.ForEach(s => context.Teachers.Add(s));
            context.SaveChanges();


            base.Seed(context);
    }
  }
}