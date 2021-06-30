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


            // college******

            var colleges = new List<Colleges>
      {
        new Colleges { CollegeId ="1000", CollegeName="Information Eng"},
        new Colleges { CollegeId ="1001", CollegeName="Collge of Physics"},


      };
            colleges.ForEach(s => context.Colleges.Add(s));
            context.SaveChanges();

            // major*******

            var maj = new List<Majors>
      {
        new Majors { MajorId ="2000", MajorName="Software Eng",CollegeId="1000"},
        new Majors { MajorId ="2001", MajorName="Mechanical Eng",CollegeId="1001"},


      };
            maj.ForEach(s => context.Majors.Add(s));
            context.SaveChanges();


            //courses *********

            var Cours = new List<Courses>
      {
        new Courses { CourseId ="3000", CourseName="Data Structure",MajorId="2000"},
        new Courses { CourseId ="3001", CourseName="Quantum Physics",MajorId="2001"},


      };
            Cours.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();

            // GEnder ***
/*
            var gen = new List<Genders>
      {
        new Genders { Gender ="1", GenderName="Male"},
        new Genders { Gender ="2", GenderName="Fe-male"},


      };
            gen.ForEach(s => context.Genders.Add(s));
            context.SaveChanges();
*/


            var Students = new List<Student>
      {
        new Student {StudentId="4000", Name="zahid",Gender="Male",MajorId="2000",CollageId="1000",Session="2018",Password="zahid1234",Email="zahid@gmail.com" },
        new Student { StudentId ="4001", Name="MD AL Rayhan",Gender="Male",MajorId="2000",CollageId="1000",Session="2018",Password="rayhan1234",Email="rayhan@gmail.com" },
         new Student {StudentId="4002", Name="Rohim",Gender="Male",MajorId="2001",CollageId="1001",Session="2018",Password="zahid1234",Email="rohim@gmail.com" },

      };
            Students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();

            var Teachers = new List<Teacher>
      {
        new Teacher { TeacherId ="5000", Name="XU ming",Gender="Male",CollageId="1000",Password="zahid1234",Email="asd@gmail.com" },
        new Teacher { TeacherId ="3222", Name="Simon",Gender="Male",CollageId="1001",Password="zahid1234",Email="cds@gmail.com" },


      };
            Teachers.ForEach(s => context.Teachers.Add(s));
            context.SaveChanges();

          



            base.Seed(context);
    }
  }
}